using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Models
{
    public class Produtos
    {
        public int ID { get; set; }
        public int? ApiId { get; set; }
        public int LojaId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public string CodigoDeBarras { get; set; } = string.Empty;
        public string TipoDeProduto { get; set; } = string.Empty;
        public decimal Desconto { get; set; }
        public int CategoriaId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
