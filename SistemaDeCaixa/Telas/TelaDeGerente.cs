using SistemaDeCaixa.Models;
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
    public partial class TelaDeGerente : Form
    {
        public TelaDeGerente()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            int loja_id = Sessao.LojaId;
            Sessao.Limpar();
            this.Close();
            new Login(loja_id).ShowDialog();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            var produotos = new Telas.CadastroDeProdutos();
            produotos.ShowDialog();
        }

        private void btnCriarCategoria_Click(object sender, EventArgs e)
        {
            var categoria = new Telas.CadastroDeCategorias();
            categoria.ShowDialog();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            var funcionario = new Telas.CadastroFuncionario(Sessao.LojaId);
            funcionario.ShowDialog();
        }

        private void btnListarFuncionarios_Click(object sender, EventArgs e)
        {
            var listaFuncionario = new ListaFuncionarioscs();
            listaFuncionario.ShowDialog();
        }

        private void btnListarProdutos_Click(object sender, EventArgs e)
        {
            var listaProdutos = new ListarProdutos();
            listaProdutos.ShowDialog();
        }

        private void btnCriarDescontos_Click(object sender, EventArgs e)
        {
            var criarDescontos = new CriarDesconto();
            criarDescontos.ShowDialog();
        }
    }
}
