using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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