using SistemaDeCaixa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Repository
{
    public class DescontosRepository
    {
        public void Criar(
            string api_id, 
            int funcionario_id,
            string Nome,
            decimal Valor,
            string Codigo,
            string Descricao,
            DateTime Validade)
        {
            using(var conn = LocalDB.DbConnection())
            using(var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                       INSERT INTO Descontos
                       (api_id, funcionario_id, Nome, Valor, Codigo, Descricao, Validade)
                       VALUES
                       (@api_id, @funcionario_id, @Nome, @Valor, @Codigo, @Descricao, @Validade)
                ";

                cmd.Parameters.AddWithValue("@api_id", api_id);
                cmd.Parameters.AddWithValue("@funcionario_id", funcionario_id);
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Valor", Valor);
                cmd.Parameters.AddWithValue("@Codigo", Codigo);
                cmd.Parameters.AddWithValue("@Descricao", Descricao);
                cmd.Parameters.AddWithValue("@Validade", Validade);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable descontoPorLoja(int loja_id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var da = new SQLiteDataAdapter(
            @"SELECT  
            d.ID                AS DescontoId,
            d.Nome              AS Nome,
            d.Valor             AS Valor,
            d.Codigo            AS Codigo,
            d.Descricao         AS Descricao,
            d.Validade          AS Validade
              FROM Descontos d
              WHERE d.loja_id = @loja_id", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@loja_id", loja_id);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public decimal ObterValorDesconto(string codigo)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT Valor
                    FROM Descontos
                    WHERE Codigo = @codigo
                ";

                cmd.Parameters.AddWithValue("@codigo", codigo);

                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return 0m;

                return Convert.ToDecimal(result);
            }
        }


        public void Deletar(int id)
        {
            using(var conn = LocalDB.DbConnection())
            using(var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"DELETE FROM Descontos WHERE ID = @id";

                cmd.Parameters.AddWithValue ("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
