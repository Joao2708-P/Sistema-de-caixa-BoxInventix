using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Models
{
    public class Loja
    {

        public int ID { get; set; }
        public string? ApiId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
