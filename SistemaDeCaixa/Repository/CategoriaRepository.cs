using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Services
{
    public class CategoriaService
    {
        public void criarCategoria(string loja_id, string nome, int api_id)
        {
            using(var conn = LocalDB.DbConnection())
            using(var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    INSERT INTO Categoria
                    (loja_id, nome, api_id, created_at, updated_at) VALUES (@loja_id, @nome, @api_id, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                ";

                cmd.Parameters.AddWithValue("@loja_id", loja_id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@api_id", api_id);

                cmd.ExecuteNonQuery();
            }
        }

        public DataRow ListarCategoriaPorLoja(string loja_id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = new SQLiteDataAdapter("SELECT * FROM Categoria WHERE loja_id = @loja_id", conn))
            {
                cmd.SelectCommand.Parameters.AddWithValue("@loja_id", loja_id);

                DataTable dt = new DataTable();
                cmd.Fill(dt);

                if (dt.Rows.Count == 0)
                    return null;

                return dt.Rows[0];
            }
        }

        public DataTable ListarCategorias()
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT id, nome
            FROM Categoria
            ORDER BY nome
        ";

                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }


        public void atualizaCategoria(int id, string nome)
        {
            using (var conn = LocalDB.DbConnection())
            using (var la = new SQLiteDataAdapter("UPDATE Categoria SET nome = @nome WHERE id = @id", conn))
            {
                la.SelectCommand.Parameters.AddWithValue("@nome", nome);
                la.SelectCommand.Parameters.AddWithValue("@id", id);

                la.SelectCommand.ExecuteNonQuery();
            }
        } 

        public  void deletarCategoria(int id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Categoria WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
