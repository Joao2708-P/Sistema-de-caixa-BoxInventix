using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa
{
    public class Funcionario
    {
        public int ID { get; set; }
        public int? ApiId { get; set; }
        public int LojaId { get; set; }

        public string Nome { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string SenhaHash { get; set; } = string.Empty;
        public string role { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}