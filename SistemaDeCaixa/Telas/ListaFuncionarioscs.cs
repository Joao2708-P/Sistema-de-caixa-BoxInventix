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
    public partial class ListaFuncionarioscs : Form
    {
        public ListaFuncionarioscs()
        {
            InitializeComponent();
            if (Sessao.UsuarioLogado.role != "gerente" && Sessao.UsuarioLogado.role != "admin")
            {
                MessageBox.Show("Você não posssui autorização para acessar essa tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        FuncionarioRepository funcionarioService;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaFuncionarioscs_Load(object sender, EventArgs e)
        {
            var listFunc = new FuncionarioRepository();
            dgvFuncionario.AutoGenerateColumns = true;
            dgvFuncionario.DataSource = listFunc.ListarPorLoja(Sessao.LojaId);
        }
    }
}
