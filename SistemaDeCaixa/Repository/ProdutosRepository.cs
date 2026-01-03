using SistemaDeCaixa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace SistemaDeCaixa.Services
{
    public class ProdutosRepository
    {
        public void criar(
            int loja_id, 
            string nome, 
            decimal preco, 
            string codigodebarras, 
            int categoria_id, 
            string tipo_de_produto,
            decimal desconto,
            string? api_id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    INSERT INTO Produtos 
                    (api_id, loja_id, nome, preco, codigo_de_barras, tipo_de_produto, categoria_id, Desconto ,created_at, updated_at)
                    VALUES
                    (@api_id, @loja_id, @nome, @preco, @codigodebarras, @tipo_de_produto ,@categoria_id, @Desconto , CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                ";

                cmd.Parameters.AddWithValue("@loja_id", loja_id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@codigodebarras", codigodebarras);
                cmd.Parameters.AddWithValue("@categoria_id", categoria_id);
                cmd.Parameters.AddWithValue("@api_id", api_id);
                cmd.Parameters.AddWithValue("@tipo_de_produto", tipo_de_produto);
                cmd.Parameters.AddWithValue("@Desconto", desconto);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarProdutosPorLoja(int loja_id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var da = new SQLiteDataAdapter(
            @"SELECT  
            p.id                AS ProdutoId,
            p.nome              AS Nome,
            p.preco             AS Preco,
            p.codigo_de_barras  AS CodigoDeBarras,
            p.tipo_de_produto   AS TipoDeProduto,
            p.Desconto          AS Desconto,
            c.nome              AS Categoria,
              FROM Produtos p
              INNER JOIN Categoria c ON c.id = p.categoria_id
              WHERE p.loja_id = @loja_id", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@loja_id", loja_id);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public Produtos BuscarPorCodigo(string codigo)
        {
            using(var conn = LocalDB.DbConnection()) 
            using(var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT id, nome, preco, Desconto, tipo_de_produto
                    FROM produtos 
                    WHERE codigo_de_barras = @codigo";

                cmd.Parameters.AddWithValue("@codigo", codigo);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Produtos
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            Preco = Convert.ToDecimal(reader["preco"]),
                            Desconto = Convert.ToDecimal(reader["Desconto"]),
                            TipoDeProduto = reader["tipo_de_produto"].ToString()
                        };
                    }
                }
            }

            return null;
        }

        public void atualizarProduto(int id,
            string? nome = null, 
            decimal? preco = null, 
            string? codigodebarras = null, 
            int? categoria_id = null, 
            string? api_id = null, 
            string? tipo_de_produto = null,
            decimal? desconto = 0)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                List<string> updates = new List<string>();

                if (nome != null)
                {
                    updates.Add("nome = @nome");
                    cmd.Parameters.AddWithValue("@nome", nome);
                }

                if (preco != null)
                {
                    updates.Add("preco = @preco");
                    cmd.Parameters.AddWithValue("@preco", preco);
                }

                if (codigodebarras != null)
                {
                    updates.Add("codigodebarras = @codigodebarras");
                    cmd.Parameters.AddWithValue("@codigodebarras", codigodebarras);
                }

                if (categoria_id != null)
                {
                    updates.Add("categoria_id = @categoria_id");
                    cmd.Parameters.AddWithValue("@categoria_id", categoria_id);
                }

                if (api_id != null)
                {
                    updates.Add("api_id = @api_id");
                    cmd.Parameters.AddWithValue("@api_id", api_id);
                }

                if(tipo_de_produto != null)
                {
                    updates.Add("tipo_de_produto = @tipo_de_produto");
                    cmd.Parameters.AddWithValue("@tipo_de_produto", tipo_de_produto);
                }

                if (desconto != 0)
                {
                    updates.Add("Desconto = @desconto");
                    cmd.Parameters.AddWithValue("@desconto", desconto);
                }

                updates.Add("updated_at = CURRENT_TIMESTAMP");

                cmd.CommandText = $@"
                    UPDATE Produtos 
                    SET {string.Join(", ", updates)}
                    WHERE ID = @id
                ";

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeletarProduto(int id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Produtos WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}