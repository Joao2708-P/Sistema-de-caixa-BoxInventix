using SistemaDeCaixa.Repository;
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
    public partial class FormaDePagamento : Form
    {
        DescontosRepository descontos = new DescontosRepository();
        private decimal valor_total;
        private string FormaPagamento;
        private decimal ValorRecebido;
        private decimal Troco;
        private decimal desconto;

        public FormaDePagamento(decimal total)
        {
            InitializeComponent();
            valor_total = total;
        }

        private void FormaDePagamento_Load(object sender, EventArgs e)
        {
            lbTotal.Text = valor_total.ToString("C");

            cbPagamento.Items.AddRange(new string[]
            {
                "Débito",
                "Crédito",
                "Dinheiro"
            });

            cbPagamento.SelectedIndex = 0;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!ProcessarPagamento())
                return;

                FormaPagamento = cbPagamento.Text;
                ValorRecebido = FormaPagamento == "Dinheiro"
                ? decimal.Parse(txtValorRecebido.Text)
                : valor_total;

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ProcessarPagamento()
        {
            desconto = descontos.ObterValorDesconto(txtDesconto.Text);

            if(desconto > 0)
            {
                valor_total = valor_total - desconto;
            }

            if (cbPagamento.Text == "Dinheiro")
            {
                if (!decimal.TryParse(txtValorRecebido.Text, out decimal recebido))
                {
                    MessageBox.Show("Informe um valor válido");
                    return false;
                }

                if (recebido < valor_total)
                {
                    MessageBox.Show("Valor recebido menor que o total");
                    return false;
                }

                Troco = recebido - valor_total;
                lbTroco.Text = Troco.ToString("C");
            }
            else
            {
                Troco = 0;
                lbTroco.Text = "R$ 0,00";
            }

            return true;
        }
    }
}