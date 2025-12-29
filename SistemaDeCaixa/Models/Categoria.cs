using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        public int LojaId { get; set; }
        public int? ApiId { get; set; }

        public string Nome { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
