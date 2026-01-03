using SistemaDeCaixa.Models;
using SistemaDeCaixa.Services;
using SistemaDeCaixa.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCaixa
{
    public partial class BoodStrap : Form
    {
        public BoodStrap()
        {
            InitializeComponent();

            ShowInTaskbar = false;
            Opacity = 0;
            Shown += BoodStrap_Shown;
        }

        private void BoodStrap_Load(object sender, EventArgs e)
        {

        }

        private void BoodStrap_Shown(object sender, EventArgs e)
        {
            Hide();

            var lojaRepo = new LojaRepository();
            var loja = lojaRepo.listaLoja();

            // 1️⃣ Primeira execução → cadastrar loja
            if (loja == null)
            {
                var resposta = MessageBox.Show(
                      "Nenhuma empresa cadastrada foi encontrada.\n\n" +
                      "Você precisa cadastrar uma empresa para continuar.",
                      "Primeiro acesso",
                      MessageBoxButtons.OKCancel,
                      MessageBoxIcon.Information
                );

                if (resposta != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }

                using var cadastro = new CadastroDeEmpresa();
                if (cadastro.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }

                loja = lojaRepo.listaLoja();
                if (loja == null)
                {
                    Application.Exit();
                    return;
                }
            }

            // 2️⃣ Login
            var login = new Login(loja.ID);
            if (login.ShowDialog() != DialogResult.OK)
            {
                Close();
                return;
            }

            // 3️⃣ Tela principal
            Form telaPrincipal =
                login.Role == "gerente" || login.Role == "admin"
                    ? new TelaDeGerente()
                    : new Caixa(Sessao.UsuarioLogado);

            telaPrincipal.FormClosed += (_, __) => Close();
            telaPrincipal.ShowDialog();
        }
    }
}