using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentValidator;
using SistemaDeCaixa.Services;

namespace SistemaDeCaixa.Telas
{
    public partial class CadastroDeEmpresa : Form
    {
        LojaRepository LojaService;
        public int LojaIdCriada;

        public CadastroDeEmpresa()
        {
            InitializeComponent();
        }

        public void LimpaErros()
        {
            lbNome.Visible = false;
            lbEndereco.Visible = false;
            lbCnpj.Visible = false;
        }

        public bool ValidarCampos()
        {
            LimpaErros();

            if(string.IsNullOrEmpty(txtNomeLoja.Text))
            {
                lbNome.Visible = true;
                txtNomeLoja.Focus();
                return false;
            }

            if(string.IsNullOrEmpty(txtEndereo.Text))
            {
                lbEndereco.Visible = true;
                txtEndereo.Focus();
                return false;
            }

            if(string.IsNullOrEmpty(txtCnpjLoja.Text))
            {
                lbCnpj.Visible = true;
                txtCnpjLoja.Focus();
                return false;
            }

            if(CnpjValidation.Validate(txtCnpjLoja.Text) != true)
            {
                MessageBox.Show("CNPJ Inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void Criar()
        {
            if(ValidarCampos())
            {
                LojaService = new LojaRepository();

                int lojaId = LojaService.cadastrarLoja(
                      null,
                      txtNomeLoja.Text,
                      txtCnpjLoja.Text,
                      txtEndereo.Text
                );

                if(lojaId > 0)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar sua loja por favor tente novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LojaIdCriada = lojaId;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Criar();
        }
    }
}
