using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeCaixa.Models;

namespace SistemaDeCaixa.Services
{
    public class VendaRepository
    {
        // Criar uma venda
        public int Criar(int lojaId, int funcionarioId)
        {
            using var conn = LocalDB.DbConnection();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
            INSERT INTO Venda
            (loja_id, data, status, valorSubTotal, desconto, valorTotal, funcionario_id)
            VALUES
            (@loja, @data, 'aberta', 0, 0, 0, @func);
            SELECT last_insert_rowid();
        ";

            cmd.Parameters.AddWithValue("@loja", lojaId);
            cmd.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@func", funcionarioId);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void AtualizarValores(int vendaId, decimal sub, decimal desconto, decimal total)
        {
            using var conn = LocalDB.DbConnection();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
            UPDATE Venda
            SET valorSubTotal = @sub,
                desconto = @desconto,
                valorTotal = @total,
                updated_at = CURRENT_TIMESTAMP
            WHERE ID = @id
        ";

            cmd.Parameters.AddWithValue("@sub", sub);
            cmd.Parameters.AddWithValue("@desconto", desconto);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@id", vendaId);

            cmd.ExecuteNonQuery();
        }

        public (int vendaId, List<ItemCaixa> itens) ObterVendaAberta(int lojaId)
        {
            using var conn = LocalDB.DbConnection();
            conn.Open();

            // 1️⃣ Venda aberta
            var cmdVenda = new SQLiteCommand(@"
                    SELECT ID 
                    FROM Venda 
                    WHERE loja_id = @lojaId 
                      AND status = 'aberta'
                    LIMIT 1
            ", conn);

            cmdVenda.Parameters.AddWithValue("@lojaId", lojaId);

            var vendaIdObj = cmdVenda.ExecuteScalar();
            if (vendaIdObj == null)
                return (0, new List<ItemCaixa>());

            int vendaId = Convert.ToInt32(vendaIdObj);

            var cmdItens = new SQLiteCommand(@"
                SELECT
                     p.ID AS ID,
                     p.Nome AS Nome,
                     vi.preco_unitario AS Preco,
                     vi.Quantidade AS Quantidade,
                     vi.peso_kg AS KG,
                     P.Desconto AS Desconto,
                     vi.subtotal AS Subtotal
                FROM VendaItem vi
                INNER JOIN Produtos p ON p.ID = vi.produto_id
                WHERE vi.venda_id = @vendaId
            ", conn);

            cmdItens.Parameters.AddWithValue("@vendaId", vendaId);

            var itens = new List<ItemCaixa>();

            using var reader = cmdItens.ExecuteReader();
            while (reader.Read())
            {
                itens.Add(new ItemCaixa
                {
                    Produtos = new Produtos
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nome = reader["Nome"].ToString(),
                        Desconto = Convert.ToDecimal(reader["Desconto"])
                    },
                    Quantidade = Convert.ToInt32(reader["Quantidade"]),
                    PesoKg = Convert.ToDecimal(reader["KG"]),
                    PrecoUnitario = Convert.ToDecimal(reader["Preco"]),
                    Subtotal = Convert.ToDecimal(reader["Subtotal"]),
                    DescontoItem = Convert.ToDecimal(reader["Desconto"])
                });
            }

            return (vendaId, itens);
        }


        public void AtualizarStatus(int vendaId, string status, string? formaPagamento)
        {
            using var conn = LocalDB.DbConnection();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
            UPDATE Venda
            SET status = @status,
                formadepagamento = @forma,
                updated_at = CURRENT_TIMESTAMP
            WHERE ID = @id
        ";

            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@forma", formaPagamento);
            cmd.Parameters.AddWithValue("@id", vendaId);

            cmd.ExecuteNonQuery();
        }

        public bool VendaExiste(int vendaId)
        {
            using var conn = LocalDB.DbConnection();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT COUNT(1) FROM Venda WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", vendaId);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }
}