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

        // Estado da venda
        public int Quantidade { get; set; }
        public decimal PesoKg { get; set; }

        // Snapshot
        public decimal PrecoUnitario { get; set; }
        public decimal DescontoItem { get; set; } // %

        // Campos auxiliares pra grid (opcional)
        public decimal Subtotal { get; set; }
    }
}
