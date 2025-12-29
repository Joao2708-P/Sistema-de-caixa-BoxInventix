using System;
using System.Data.SQLite;
using System.IO;

namespace SistemaDeCaixa
{
    public class LocalDB
    {
        private static string dbPath = @"C:\dados\SistemaDeCaixa.sqlite";
        private static string connectionString = $"Data Source={dbPath};Version=3;";

        public static SQLiteConnection DbConnection()
        {
            string folder = Path.GetDirectoryName(dbPath);

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            if (!File.Exists(dbPath))
                SQLiteConnection.CreateFile(dbPath);

            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static void CriarLoja()
        {
            using (var conn = DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Loja (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        api_id TEXT,
                        nome TEXT NOT NULL,
                        CNPJ TEXT NOT NULL,
                        endereco TEXT NOT NULL,
                        created_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        updated_at TEXT DEFAULT CURRENT_TIMESTAMP
                    );
                ";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CriarFuncionario()
        {
            using (var conn = DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Funcionario (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        api_id INTEGER,
                        loja_id INTEGER NOT NULL,
                        nome TEXT NOT NULL,
                        login TEXT NOT NULL,
                        email TEXT,
                        senha_hash TEXT NOT NULL,
                        role TEXT NOT NULL,
                        created_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        updated_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (loja_id) REFERENCES Loja(ID)
                    );
                ";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CriarCategoria()
        {
            using (var conn = DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Categoria (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        loja_id INTEGER,
                        api_id INTEGER,
                        nome TEXT NOT NULL,
                        created_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        updated_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (loja_id) REFERENCES Loja(ID)
                    );
                ";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CriarProdutos()
        {
            using (var conn = DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Produtos (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        api_id INTEGER,
                        loja_id INTEGER NOT NULL,
                        nome TEXT NOT NULL,
                        preco NUMERIC NOT NULL,
                        codigo_de_barras TEXT NOT NULL,
                        tipo_de_produto TEXT NOT NULL,
                        categoria_id INTEGER NOT NULL,
                        Desconto NUMERIC NOT NULL DEFAULT 0,
                        created_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        updated_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (loja_id) REFERENCES Loja(ID),
                        FOREIGN KEY (categoria_id) REFERENCES Categoria(ID)
                    );
                ";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CriarVariacao()
        {
            using (var conn = DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Variacao (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        api_id INTEGER,
                        produto_id INTEGER NOT NULL,
                        nome TEXT NOT NULL,
                        valor TEXT NOT NULL,
                        codigo_de_barras TEXT,
                        preco NUMERIC NOT NULL,
                        created_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        updated_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (produto_id) REFERENCES Produtos(ID)
                    );
                ";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CriarVenda()
        {
            using (var conn = DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Venda (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        api_id TEXT,
                        loja_id INTEGER NOT NULL,
                        data TEXT NOT NULL,
                        valorTotal NUMERIC NOT NULL DEFAULT 0,
                        valorSubTotal NUMERIC NOT NULL DEFAULT 0,
                        status TEXT NOT NULL DEFAULT 'aberta',
                        desconto NUMERIC NOT NULL DEFAULT 0,
                        funcionario_id INTEGER NOT NULL,
                        formadepagamento TEXT,
                        created_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        updated_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (loja_id) REFERENCES Loja(ID),
                        FOREIGN KEY (funcionario_id) REFERENCES Funcionario(ID)
                    );
                ";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CriarVendaItem()
        {
            using (var conn = DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS VendaItem (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        api_id INTEGER,
                        venda_id INTEGER NOT NULL,
                        produto_id INTEGER NOT NULL,
                        quantidade INTEGER NOT NULL,
                        peso_kg NUMERIC,
                        preco_unitario NUMERIC NOT NULL,
                        subtotal NUMERIC NOT NULL,
                        created_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        updated_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (venda_id) REFERENCES Venda(ID),
                        FOREIGN KEY (produto_id) REFERENCES Produtos(ID)
                    );
                ";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CriarDescontos()
        {
            using (var conn = DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Descontos(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        api_id TEXT,
                        funcionario_id INTEGER NOT NULL,
                        Nome TEXT NOT NULL,
                        Valor NUMERIC NOT NULL,
                        Codigo TEXT NOT NULL,
                        Descricao TEXT NOT NULL,
                        Validade TEXT NOT NULL,
                        created_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        updated_at TEXT DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (funcionario_id) REFERENCES Funcionario(ID)
                    )
                ";
            }
        }

        public static void ResetDatabase()
        {
            #if DEBUG
            using (var conn = DbConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    DROP TABLE IF EXISTS VendaItem;
                    DROP TABLE IF EXISTS Venda;
                    DROP TABLE IF EXISTS Produtos;
                    DROP TABLE IF EXISTS Funcionario;
                    DROP TABLE IF EXISTS Loja;
                ";
                cmd.ExecuteNonQuery();
            }

            InicializarBanco();
            #else
                throw new InvalidOperationException("ResetDatabase só pode ser usado em DEV.");
            #endif
        }

        public static void InicializarBanco()
        {
            CriarLoja();
            CriarFuncionario();
            CriarCategoria();
            CriarProdutos();
            CriarVariacao();
            CriarVenda();
            CriarVendaItem();
            CriarDescontos();
        }
    }
}