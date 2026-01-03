using SistemaDeCaixa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Services
{
    public class LojaRepository
    {
        public int cadastrarLoja(string? api_id, string nome, string CNPJ, string endereco)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            INSERT INTO Loja (api_id, nome, CNPJ, endereco, created_at, updated_at) 
            VALUES (@api_id, @nome, @CNPJ, @endereco, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
            SELECT last_insert_rowid();
        ";

                cmd.Parameters.AddWithValue("@api_id", api_id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                cmd.Parameters.AddWithValue("@endereco", endereco);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public Loja? listaLoja()
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Loja LIMIT 1";

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    return new Loja
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        ApiId = reader.IsDBNull(reader.GetOrdinal("api_id"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("api_id")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        CNPJ = reader.GetString(reader.GetOrdinal("CNPJ"))
                    };
                }
            }
        }

        public DataRow ListaLojaPorId(string id)
        {
            using(var conn = LocalDB.DbConnection())
            using (var cmd = new SQLiteDataAdapter("SELECT * FROM Loja WHERE id = @id", conn))
            {
                cmd.SelectCommand.Parameters.AddWithValue("@id", id);

                DataTable dt = new DataTable();

                cmd.Fill(dt);

                if (dt.Rows.Count == 0)
                    return null;

                return dt.Rows[0];
            }
        }
    }
}
