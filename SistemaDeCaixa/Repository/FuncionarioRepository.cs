using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SistemaDeCaixa.Services
{
    public class FuncionarioRepository
    {
        public void Criar(string loja_id, string nome, string login, string? email, string senha_hash, string role, string? api_id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    INSERT INTO Funcionario
                    (loja_id, nome, login, email, senha_hash, role, api_id, created_at, updated_at)
                    VALUES
                    (@loja_id, @nome, @login, @email, @senha_hash, @role, @api_id, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                ";

                cmd.Parameters.AddWithValue("@loja_id", loja_id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha_hash", senha_hash);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@api_id", api_id);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarPorLoja(int loja_id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var da = new SQLiteDataAdapter(
                @"SELECT 
                    nome   AS 'Nome',
                    login  AS 'Login',
                    role   AS 'Cargo',
                    senha_hash AS 'Senha'
                  FROM Funcionario
                  WHERE loja_id = @loja_id", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@loja_id", loja_id);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }


        public DataRow? ObterPorId(int id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var da = new SQLiteDataAdapter(
                "SELECT * FROM Funcionario WHERE ID = @id", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@id", id);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                    return null;

                return dt.Rows[0];
            }
        }

        public void AtualizarFuncionario(
            int id,
            string? nome = null,
            string? login = null,
            string? email = null,
            string? role = null,
            string? api_id = null
        )
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                List<string> campos = new List<string>();

                if (!string.IsNullOrEmpty(nome))
                {
                    campos.Add("nome = @nome");
                    cmd.Parameters.AddWithValue("@nome", nome);
                }

                if (!string.IsNullOrEmpty(login))
                {
                    campos.Add("login = @login");
                    cmd.Parameters.AddWithValue("@login", login);
                }

                if (!string.IsNullOrEmpty(email))
                {
                    campos.Add("email = @email");
                    cmd.Parameters.AddWithValue("@email", email);
                }

                if (!string.IsNullOrEmpty(role))
                {
                    campos.Add("role = @role");
                    cmd.Parameters.AddWithValue("@role", role);
                }

                if (!string.IsNullOrEmpty(api_id))
                {
                    campos.Add("api_id = @api_id");
                    cmd.Parameters.AddWithValue("@api_id", api_id);
                }

                if (campos.Count == 0) return;

                campos.Add("updated_at = CURRENT_TIMESTAMP");

                cmd.CommandText = $@"
                    UPDATE Funcionario
                    SET {string.Join(", ", campos)}
                    WHERE ID = @id
                ";

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void AtualizarSenha(int id, string novaSenhaHash)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    UPDATE Funcionario
                    SET senha_rash = @senha,
                        updated_at = CURRENT_TIMESTAMP
                    WHERE ID = @id
                ";

                cmd.Parameters.AddWithValue("@senha", novaSenhaHash);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Funcionario WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public bool validarLoginUnico(string login)
        {
            using(var conn = LocalDB.DbConnection())
            using(var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT COUNT(*) FROM Funcionario WHERE login = @login
                ";

                cmd.Parameters.AddWithValue("@login", login);

                long count = (long)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public bool ExisteGerente()
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"SELECT COUNT(*) FROM Funcionario WHERE role in ('admin', 'gerente')";

                long count = (long)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public Funcionario ValidarLogin(string login, string senha)
        {
            using (var conn = LocalDB.DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT * FROM Funcionario
            WHERE login = @login AND senha_hash = @senha
        ";

                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    return new Funcionario
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        LojaId = reader.GetInt32(reader.GetOrdinal("loja_id")),
                        Nome = reader["nome"].ToString(),
                        Login = reader["login"].ToString(),
                        Email = reader["email"].ToString(),
                        SenhaHash = reader["senha_hash"].ToString(),
                        role = reader["role"].ToString(),
                        ApiId = reader["api_id"] == DBNull.Value
                                    ? 0
                                    : Convert.ToInt32(reader["api_id"])
                    };
                }
            }
        }

    }
}