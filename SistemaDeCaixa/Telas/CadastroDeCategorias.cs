using SistemaDeCaixa.Models;
using SistemaDeCaixa.Services;
using System;
using System.Windows.Forms;

namespace SistemaDeCaixa.Telas
{
    public partial class CadastroDeCategorias : Form
    {
        private readonly CategoriaService categoriaService = new CategoriaService();

        public CadastroDeCategorias()
        {
            InitializeComponent();
        }

        private void CadastroDeCategorias_Load(object sender, EventArgs e)
        {
            // Proteção básica de sessão
            if (Sessao.UsuarioLogado == null)
            {
                MessageBox.Show(
                    "Sessão inválida. Faça login novamente.",
                    "Sessão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                new Login(Sessao.LojaId).Show();
                Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                categoriaService.criarCategoria(
                    Sessao.LojaId.ToString(),
                    txtNomeCategoria.Text.Trim(),
                    0 // api_id — você pode evoluir isso depois
                );

                MessageBox.Show(
                    "Categoria cadastrada com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao cadastrar categoria.\n\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomeCategoria.Text))
            {
                MessageBox.Show(
                    "Informe o nome da categoria.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNomeCategoria.Focus();
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            txtNomeCategoria.Clear();
            txtNomeCategoria.Focus();
        }
    }
}
