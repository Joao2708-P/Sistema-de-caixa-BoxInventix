using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Models
{
    public class Variacao
    {
        public int ID { get; set; }
        public int? ApiId { get; set; }
        public int ProdutoId { get; set; }

        public string Nome { get; set; } = string.Empty;
        public string Valor { get; set; } = string.Empty;
        public string? CodigoDeBarras { get; set; }
        public decimal Preco { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
