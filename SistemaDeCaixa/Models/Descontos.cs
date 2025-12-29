using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Models
{
    public class Descontos
    {
        public int ID { get; set; }

        public string? ApiId { get; set; }

        public int FuncionarioId { get; set; }

        public string Nome { get; set; } = string.Empty;

        public decimal Valor { get; set; }

        public string Codigo { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public string Validade { get; set; } = string.Empty;

        public string CreatedAt { get; set; } = string.Empty;

        public string UpdatedAt { get; set; } = string.Empty;
    }
}
