using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Models
{
    public class HelperDePesquisa
    {
        public static void Filtrar(DataGridView grid, DataTable tabela, string pesquisa, params string[] colunas)
        {
            if(tabela == null || grid == null) return;

            DataView view = tabela.DefaultView;

            if (string.IsNullOrWhiteSpace(pesquisa) )
            {
                view.RowFilter = string.Empty;
                grid.DataSource = view;
                return;
            }

            if (colunas == null || colunas.Length == 0) return;

            string filtro = string.Join(" OR ", colunas.Select(c => $"{c} LIKE '%{pesquisa.Replace("'", "''")}'"));

            view.RowFilter = filtro;
            grid.DataSource = view;
        }
    }
}