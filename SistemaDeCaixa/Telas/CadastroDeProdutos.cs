using SistemaDeCaixa.Models;
using SistemaDeCaixa.Services;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace SistemaDeCaixa.Telas
{
    public partial class CadastroDeProdutos : Form
    {
        private readonly ProdutosRepository produtoService = new ProdutosRepository();
        private readonly CategoriaService categoriaService = new CategoriaService();
        private int loja_id = Sessao.LojaId;

        public CadastroDeProdutos()
        {
            InitializeComponent();
        }

        private void CarregarCategorias()
        {
            var categorias = categoriaService.ListarCategorias();

            if (categorias == null || categorias.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Nenhuma categoria cadastrada. Cadastre uma categoria antes de criar produtos.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                btnSalvar.Enabled = false;
                return;
            }

            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "Id";
            cbCategoria.SelectedIndex = 0;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do produto");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Informe o código do produto");
                txtCodigo.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPreco.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("Preço inválido");
                txtPreco.Focus();
                return false;
            }

            if (cbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCodigo.Clear();
            txtPreco.Clear();
            cbCategoria.SelectedIndex = 0;
        }

        private void CadastroDeProdutos_Load_1(object sender, EventArgs e)
        {
            var usuario = Sessao.UsuarioLogado.role; 

            List<string> lista = new List<string>
            {
                "UNIDADE", "KG"
            };

            cbTipoDeProduto.Items.AddRange(lista);
            cbTipoDeProduto.SelectedIndex = 0;

            if (usuario != "admin" && usuario != "gerente")
            {
                MessageBox.Show(
                    "Você não tem permissão para cadastrar produtos.",
                    "Acesso negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Close();
                return;
            }

            CarregarCategorias();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            decimal desconto = decimal.Parse(txtDesconto.Text,CultureInfo.CurrentCulture);

            produtoService.criar(
                loja_id,
                txtNome.Text,
                decimal.Parse(txtPreco.Text, CultureInfo.InvariantCulture),
                txtCodigo.Text,
                Convert.ToInt32(cbCategoria.SelectedValue), 
                cbTipoDeProduto.Text,
                desconto,
                ""
            );

            MessageBox.Show("Produto cadastrado com sucesso!");
            LimparCampos();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesconto.Text))
                return;

            if (decimal.TryParse(
                txtDesconto.Text.Replace('.', ','),
                NumberStyles.Any,
                CultureInfo.CurrentCulture,
                out decimal valor))
            {
                // Formata sempre com 2 casas
                txtDesconto.Text = valor.ToString("N2");
            }
            else
            {
                MessageBox.Show("Desconto inválido.");
                txtDesconto.Focus();
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            // Permite números
            if (char.IsDigit(e.KeyChar))
                return;

            // Permite separador decimal (vírgula ou ponto)
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                TextBox txt = (TextBox)sender;

                // Só um separador
                if (txt.Text.Contains(',') || txt.Text.Contains('.'))
                    e.Handled = true;

                return;
            }

            // Bloqueia qualquer outra coisa
            e.Handled = true;
        }
    }
}