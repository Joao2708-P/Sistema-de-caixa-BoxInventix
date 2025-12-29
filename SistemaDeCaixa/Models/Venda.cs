using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Models
{
    public class Venda
    {
        public int ID { get; set; }
        public string? ApiId { get; set; }
        public int LojaId { get; set; }
        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorSubTotal { get; set; }
        public decimal Desconto { get; set; }
        public string Status { get; set; } = "aberta";
        public string? FormaDePagamento { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}