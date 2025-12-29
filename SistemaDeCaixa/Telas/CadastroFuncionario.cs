using SistemaDeCaixa.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaDeCaixa.Telas
{
    public partial class CadastroFuncionario : Form
    {
        private readonly FuncionarioRepository funcionarioService = new FuncionarioRepository();
        private readonly ErrorProvider errorProvider = new ErrorProvider();

        private int loja_id;

        public CadastroFuncionario(int _loja_id)
        {
            InitializeComponent();
            loja_id = _loja_id;
            txtLojaIdFunc.Text = loja_id.ToString();
        }

        private bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void LimparErros()
        {
            lbLoginError.Visible = false;
            lbLoginExiste.Visible = false;
            lbNomeNulo.Visible = false;
            lbSenhaError.Visible = false;
            lbConfirmarNulo.Visible = false;
            errorProvider.Clear();
        }

        private bool MostrarErro(Label label, Control campo)
        {
            LimparErros();
            label.Visible = true;
            campo.Focus();
            return false;
        }

        private void LimparCampos()
        {
            txtLojaIdFunc.Clear();
            txtNomeFunc.Clear();
            txtLoginFunc.Clear();
            txtEmailFunc.Clear();
            txtSenhaFunc.Clear();
            txtConfirmSenha.Clear();
            cbCargo.SelectedIndex = 0;
        }

        private bool ValidarCampos()
        {
            LimparErros();

            if (string.IsNullOrWhiteSpace(txtLoginFunc.Text))
                return MostrarErro(lbLoginError, txtLoginFunc);

            if (funcionarioService.validarLoginUnico(txtLoginFunc.Text))
                return MostrarErro(lbLoginExiste, txtLoginFunc);

            if (string.IsNullOrWhiteSpace(txtNomeFunc.Text))
                return MostrarErro(lbNomeNulo, txtNomeFunc);

            if (!EmailValido(txtEmailFunc.Text))
            {
                errorProvider.SetError(txtEmailFunc, "Digite um email válido!");
                txtEmailFunc.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSenhaFunc.Text))
                return MostrarErro(lbSenhaError, txtSenhaFunc);

            if (string.IsNullOrWhiteSpace(txtConfirmSenha.Text))
                return MostrarErro(lbConfirmarNulo, txtConfirmSenha);

            if (txtSenhaFunc.Text != txtConfirmSenha.Text)
            {
                MessageBox.Show(
                    "As senhas não coincidem",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtConfirmSenha.Focus();
                return false;
            }

            return true;
        }

        private void Cadastrar()
        {
            if (!ValidarCampos())
                return;

            funcionarioService.Criar(
                loja_id.ToString(),
                txtNomeFunc.Text,
                txtLoginFunc.Text,
                txtEmailFunc.Text,
                txtSenhaFunc.Text,
                cbCargo.Text,
                ""
            );

            MessageBox.Show(
                "Funcionário cadastrado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            //var login = new Login(loja_id);
            //login.Show();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
                List<string> cargos = new List<string>
                {
                    "admin",
                    "gerente",
                    "caixa"
                };

                cbCargo.Items.AddRange(cargos.ToArray());
                cbCargo.SelectedIndex = 0;
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCargo.SelectedItem != null)
            {
                cbCargo.Text = cbCargo.SelectedItem.ToString();
            }
        }

        private void txtEmailFunc_Validating(object sender, CancelEventArgs e)
        {
            if (!EmailValido(txtEmailFunc.Text))
            {
                errorProvider.SetError(txtEmailFunc, "Digite um email válido!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmailFunc, "");
            }
        }

        private void AtualizarCargos()
        {
            cbCargo.Items.Clear();
            cbCargo.Enabled = true;

            if (!funcionarioService.ExisteGerente())
            {
                cbCargo.Items.Add("gerente");
                cbCargo.Items.Add("admin");
                cbCargo.SelectedIndex = 0;
                cbCargo.Enabled = false;
            }
            else
            {
                cbCargo.Items.AddRange(new string[]
                {
                    "admin",
                    "gerente",
                    "caixa"
                });

                cbCargo.SelectedIndex = 0;
            }
        }


        private void CadastroFuncionario_Shown(object sender, EventArgs e)
        {
            AtualizarCargos();
        }
    }
}
