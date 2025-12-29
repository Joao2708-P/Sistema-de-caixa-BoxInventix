using SistemaDeCaixa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Services
{
    public class CaixaService
    {
        public static decimal CalcularValorTotal(List<ItemCaixa> item, bool aplicarDesconto)
        {
            decimal total = 0;

            foreach (var itemCaixa in item)
            {
                decimal valorSubtotal = 0;

                if(itemCaixa.Produtos.TipoDeProduto == "UNIDADE")
                {
                  valorSubtotal = itemCaixa.Produtos.Preco * itemCaixa.Quantidade;
                }

                if(itemCaixa.Produtos.TipoDeProduto == "KG")
                {
                    valorSubtotal = itemCaixa.Produtos.Preco * itemCaixa.PesoKg;
                }
                
                if(aplicarDesconto == true)
                {
                    valorSubtotal -= valorSubtotal * (itemCaixa.Produtos.Desconto / 100m); 
                }

                total += valorSubtotal;
            }

            return total;
        }

        public static decimal subTotal(List<ItemCaixa> item)
        {   
            return CalcularValorTotal(item, false);
        }

        public static decimal total(List<ItemCaixa> item)
        {
           return CalcularValorTotal(item, true);
        }

        public static List<object> ProjetarParaGrid(List<ItemCaixa> itens)
        {
            return itens.Select(i => new
            {
                Nome = i.Produtos.Nome,
                Preco = i.PrecoUnitario,
                Quantidade = i.Produtos.TipoDeProduto == "UNIDADE" ? i.Quantidade : 0,
                KG = i.Produtos.TipoDeProduto == "KG" ? i.PesoKg : 0,
                Desconto = i.DescontoItem,
                Subtotal = i.Produtos.TipoDeProduto == "UNIDADE"
                    ? i.PrecoUnitario * i.Quantidade
                    : i.PrecoUnitario * i.PesoKg
            }).ToList<object>();
        }


        public static bool Ean13Validator(string valor)
        {
            if (string.IsNullOrEmpty(valor) || valor.Length != 13 || !valor.All(char.IsDigit))
                return false;

            int sum = 0;

            // usa os primeiros 12 dígitos
            for (int i = 0; i < 12; i++)
            {
                int digit = valor[i] - '0';

                // posições pares multiplicam por 1, ímpares por 3
                sum += (i % 2 == 0) ? digit : digit * 3;
            }

            int digitoCalculado = (10 - (sum % 10)) % 10;
            int digitoInformado = valor[12] - '0'; // 👈 AQUI está o dígito certo

            return digitoCalculado == digitoInformado;
        }

        public static EanParser EanParser(string valor)
        {
           var result = new EanParser();

            if(valor.StartsWith("2"))
            {
                //Produto de balança
                result.ProdutoPorPeso = true;

                result.CodigoProduto = valor.Substring(1, 5);

                int pesoEmGramas = int.Parse(valor.Substring(6, 5));
                result.PesoKg = pesoEmGramas / 1000m;

                return result;
            }

            //Produto por unidade
            result.ProdutoPorPeso = false;
            result.CodigoProduto = valor;
            result.PesoKg = null;

            return result;
        }
    }
}