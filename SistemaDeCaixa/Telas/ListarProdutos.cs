using SistemaDeCaixa.Models;
using SistemaDeCaixa.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCaixa.Telas
{
    public partial class ListarProdutos : Form
    {
        ProdutosRepository produtosService = new ProdutosRepository();
        private DataTable lista;

        public ListarProdutos()
        {
            InitializeComponent();
        }

        private void PesquisaProduto()
        {
            string textoDaPesquisa = txtPesquisa.Text.Trim();

            DataView view = lista.DefaultView;

            if (string.IsNullOrEmpty(textoDaPesquisa))
            {
                view.RowFilter = string.Empty;
                dgvProdutos.DataSource = lista;
                return;
            }

            DataView dv = lista.DefaultView;

            // filtra pelo nome (ajuste o nome da coluna se precisar)
            dv.RowFilter = $"Nome LIKE '%{textoDaPesquisa}%'";

            dgvProdutos.DataSource = dv;
        }

        private void ListarProdutos_Load(object sender, EventArgs e)
        {
            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.AllowUserToAddRows = false;

            lista = produtosService.ListarProdutosPorLoja(Sessao.LojaId);

            dgvProdutos.DataSource = lista;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            HelperDePesquisa.Filtrar(dgvProdutos, lista, txtPesquisa.Text, "Nome");
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            HelperDePesquisa.Filtrar(dgvProdutos, lista, txtPesquisa.Text, "Nome");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = dgvProdutos.Rows.Count - 1; i >= 0; i--)
            {
                var row = dgvProdutos.Rows[i];
                if (row.IsNewRow) continue;

                if (Convert.ToBoolean(row.Cells["colMarca"].Value))
                {
                    int produtoId = Convert.ToInt32(row.Cells["colProdutoId"].Value);

                    produtosService.DeletarProduto(produtoId);

                    ((DataRowView)row.DataBoundItem).Row.Delete();
                }
            }

            lista.AcceptChanges();
        }
    }
}
