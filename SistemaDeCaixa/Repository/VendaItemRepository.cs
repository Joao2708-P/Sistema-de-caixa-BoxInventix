using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Services
{
    public class VendaItemRepository
    {
        public void Criar(int vendaId, int produtoId, int qtd, decimal preco, decimal? pesoKg, decimal subtotal)
        {
            using var conn = LocalDB.DbConnection();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
            INSERT INTO VendaItem
            (venda_id, produto_id, quantidade, peso_kg ,preco_unitario, subtotal)
            VALUES
            (@venda, @produto, @qtd, @pesoKg ,@preco, @subtotal)
        ";

            cmd.Parameters.AddWithValue("@venda", vendaId);
            cmd.Parameters.AddWithValue("@produto", produtoId);
            cmd.Parameters.AddWithValue("@qtd", qtd);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@subtotal", subtotal);

            cmd.ExecuteNonQuery();
        }

        public void Remover(int vendaItemId)
        {
            using var conn = LocalDB.DbConnection();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = "DELETE FROM VendaItem WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", vendaItemId);
            cmd.ExecuteNonQuery();
        }

        public decimal CalcularSubtotal(int vendaId)
        {
            using var conn = LocalDB.DbConnection();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT IFNULL(SUM(subtotal), 0)
                FROM VendaItem
                WHERE venda_id = @venda
            ";

            cmd.Parameters.AddWithValue("@venda", vendaId);
            return Convert.ToDecimal(cmd.ExecuteScalar());
        }
    }
}
