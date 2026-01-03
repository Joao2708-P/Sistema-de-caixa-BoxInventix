using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Models
{
    public class ItemCaixa
    {
        public Produtos Produtos { get; set; }
        public int Quantidade { get; set; }
        public decimal PesoKg { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal DescontoItem { get; set; } 
        public decimal Subtotal { get; set; }
    }
}
