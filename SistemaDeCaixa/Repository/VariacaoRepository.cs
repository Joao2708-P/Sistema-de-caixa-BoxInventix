using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Services
{
    public class VariacaoRepository
    {
        // Criar nova variação
        public void Criar(int api_id, int produtoId, string nome, string valor, string? codigoDeBarras, double preco)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    INSERT INTO Variacao
                        (api_id, produto_id, nome, valor, codigo_de_barras, preco, created_at, updated_at)
                    VALUES
                        (@produto_id, @nome, @valor, @codigo, @preco, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                ";

                cmd.Parameters.AddWithValue("@api_id", api_id);
                cmd.Parameters.AddWithValue("@produto_id", produtoId);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@codigo", (object?)codigoDeBarras ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@preco", preco);

                cmd.ExecuteNonQuery();
            }
        }

        // Buscar variações pelo produto
        public DataTable BuscarPorProduto(int produtoId)
        {
            using (var conn = LocalDB.DbConnection())
            using (var da = new SQLiteDataAdapter(
                "SELECT * FROM Variacao WHERE produto_id = @produtoid", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@produtoid", produtoId);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Buscar por ID
        public DataRow? BuscarPorId(int id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var da = new SQLiteDataAdapter(
                "SELECT * FROM Variacao WHERE id = @id", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@id", id);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                    return null;

                return dt.Rows[0];
            }
        }

        // Atualizar uma variação
        public void Atualizar(
            int id,
            string? nome = null,
            string? valor = null,
            string? codigo = null,
            double? preco = null
        )
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                List<string> updates = new List<string>();

                if (!string.IsNullOrEmpty(nome))
                {
                    updates.Add("nome = @nome");
                    cmd.Parameters.AddWithValue("@nome", nome);
                }

                if (!string.IsNullOrEmpty(valor))
                {
                    updates.Add("valor = @valor");
                    cmd.Parameters.AddWithValue("@valor", valor);
                }

                if (codigo != null)
                {
                    updates.Add("codigo_de_barras = @codigo");
                    cmd.Parameters.AddWithValue("@codigo", (object?)codigo ?? DBNull.Value);
                }

                if (preco.HasValue)
                {
                    updates.Add("preco = @preco");
                    cmd.Parameters.AddWithValue("@preco", preco.Value);
                }

                if (updates.Count == 0)
                    return;

                updates.Add("updated_at = CURRENT_TIMESTAMP");

                cmd.CommandText = $@"
                    UPDATE Variacao
                    SET {string.Join(", ", updates)}
                    WHERE id = @id
                ";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Deletar variação
        public void Deletar(int id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"DELETE FROM Variacao WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}