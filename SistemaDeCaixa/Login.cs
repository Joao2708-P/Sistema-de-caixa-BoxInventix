using SistemaDeCaixa.Models;
using SistemaDeCaixa.Services;
using SistemaDeCaixa.Telas;

namespace SistemaDeCaixa
{
    public partial class Login : Form
    {
        private int loja_id;

        public Login(int _loja_id)
        {
            InitializeComponent();
            loja_id = _loja_id;
        }

        FuncionarioRepository funcionario = new FuncionarioRepository();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string getLogin = txtLogin.Text;
            string getSenha = txtSenha.Text;

            if (getLogin != "" && getSenha != "")
            {
                FuncionarioRepository funcionarioService = new FuncionarioRepository();

                var usuario = funcionarioService.ValidarLogin(getLogin, getSenha);

                if (usuario != null)
                {
                    Sessao.UsuarioLogado = usuario;
                    Sessao.LojaId = loja_id;

                    Form proximaTela;

                    if (usuario.role == "gerente" || usuario.role == "admin")
                    {
                        proximaTela = new TelaDeGerente();
                    }
                    else
                    {
                        proximaTela = new Telas.Caixa(usuario);
                    }

                    proximaTela.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha o login e senha corretamente");
            }
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

                this.Hide();

                CadastroFuncionario func = new CadastroFuncionario(loja_id);
                func.ShowDialog(); // modal

                if (func.ShowDialog() == DialogResult.OK)
                {
                    // gerente foi cadastrado → volta para login
                    this.Show();
                }
            }
        }
    }
}