using SistemaDeCaixa.Models;
using SistemaDeCaixa.Services;
using SistemaDeCaixa.Telas;

namespace SistemaDeCaixa
{
    public partial class Login : Form
    {
        private int loja_id;
        public bool Autenticado;
        public string Role;

        public Login(int _loja_id)
        {
            InitializeComponent();
            loja_id = _loja_id;
        }

        FuncionarioRepository funcionario = new FuncionarioRepository();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                 string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha login e senha");
                return;
            }

            var usuario = funcionario.ValidarLogin(txtLogin.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado");
                return;
            }

            Sessao.UsuarioLogado = usuario;
            Sessao.LojaId = loja_id;

            Autenticado = true;
            Role = usuario.role;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!funcionario.ExisteGerente())
            {
                MessageBox.Show(
                    "Ainda não existe um gerente cadastrado!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                using(var func = new CadastroFuncionario(loja_id))
                {
                    var result = func.ShowDialog();

                    if(result != DialogResult.OK)
                    {
                        Close();
                        return;
                    }
                }
            }
        }
    }
}