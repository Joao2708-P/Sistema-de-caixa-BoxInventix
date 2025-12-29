using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Models
{
    public class EanParser
    {
            public bool Valido { get; set; }

            // Produto padrão
            public string CodigoProduto { get; set; }

            // Balança
            public bool ProdutoPorPeso { get; set; }
            public decimal? PesoKg { get; set; }

            // Opcional: mensagem de erro
            public string Erro { get; set; }

    }
}
