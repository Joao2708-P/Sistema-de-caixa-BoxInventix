using SistemaDeCaixa.Models;
using SistemaDeCaixa.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeCaixa.Telas
{
    public partial class Caixa : Form
    {
        Funcionario Funcionario;
        ProdutosRepository produtosService;
        List<ItemCaixa> itens;
        VendaService vendaService;
        int vendaId = 0;

        public Caixa(Funcionario funcionario2)
        {
            InitializeComponent();
            Funcionario = funcionario2;
            produtosService = new ProdutosRepository();
            itens = new List<ItemCaixa>();
            vendaService = new VendaService();
        }

        private void AtualizarGrid()
        {
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = CaixaService.ProjetarParaGrid(itens);

            lbSubTotal.Text = CaixaService.subTotal(itens).ToString("F2");
            lbTotal.Text = CaixaService.total(itens).ToString("F2");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var codigo = txtProduto.Text.Trim();

            if (!CaixaService.Ean13Validator(codigo))
            {
                MessageBox.Show("Código inválido!");
                return;
            }

            var ean = CaixaService.EanParser(codigo);

            var produto = produtosService.BuscarPorCodigo(ean.CodigoProduto);
            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado!");
                return;
            }

            // abre venda na primeira inserção
            if (vendaId == 0)
            {
                vendaId = vendaService.IniciarVenda(
                    Funcionario.LojaId,
                    Funcionario.ID
                );
            }

            ItemCaixa item;

            if (ean.ProdutoPorPeso)
            {
                item = new ItemCaixa
                {
                    Produtos = produto,
                    Quantidade = 1,
                    PesoKg = ean.PesoKg.Value,
                    PrecoUnitario = produto.Preco,
                    DescontoItem = produto.Desconto
                };

                itens.Add(item);
            }
            else
            {
                item = itens.FirstOrDefault(i => i.Produtos.ID == produto.ID);

                if (item != null)
                {
                    item.Quantidade++;
                }
                else
                {
                    itens.Add(new ItemCaixa
                    {
                        Produtos = produto,
                        Quantidade = 1,
                        PesoKg = 0,
                        PrecoUnitario = produto.Preco,
                        DescontoItem = produto.Desconto
                    });
                }
            }

            AtualizarGrid();

            txtProduto.Clear();
            txtProduto.Focus();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            //DataGridViewButtonColumn btnCancelar = new DataGridViewButtonColumn();
            //btnCancelar.Name = "btnCancelar";
            //btnCancelar.HeaderText = "Cancelar";
            //btnCancelar.Text = "Cancelar";
            //btnCancelar.UseColumnTextForButtonValue = true;
            //dgvCarrinho.Columns.Add(btnCancelar);
            dgvCarrinho.Columns["btnCancelar"].DataPropertyName = "Cancelar";
            dgvCarrinho.Columns["colName"].DataPropertyName = "Nome";
            dgvCarrinho.Columns["colPreco"].DataPropertyName = "Preço";
            dgvCarrinho.Columns["colQuantidade"].DataPropertyName = "Quantidade";
            dgvCarrinho.Columns["colPesoPorKG"].DataPropertyName = "KG";
            dgvCarrinho.Columns["colDesconto"].DataPropertyName = "Desconto";
            dgvCarrinho.Columns["colSubtotal"].DataPropertyName = "Subtotal";

            dgvCarrinho.DataSource = itens;
        }

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvCarrinho.Columns[e.ColumnIndex].Name == "btnCancelar")
            {
                var confirmar = MessageBox.Show(
                    "Deseja mesmo cancelar este item?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmar == DialogResult.Yes)
                {
                    itens.RemoveAt(e.RowIndex);
                    AtualizarGrid();
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (!itens.Any() || vendaId == 0)
            {
                MessageBox.Show("Carrinho vazio");
                return;
            }

            decimal sub = CaixaService.subTotal(itens);
            decimal total = CaixaService.total(itens);

            using (var pagamento = new FormaDePagamento(total))
            {
                if (pagamento.ShowDialog() == DialogResult.OK)
                {
                    vendaService.AtualizarTotais(
                        vendaId,
                        sub,
                        0,
                        total
                    );

                    vendaService.FinalizarVenda(
                        vendaId,
                        pagamento.FormaPagamento
                    );

                    itens.Clear();
                    vendaId = 0;
                    AtualizarGrid();

                    MessageBox.Show("Venda finalizada");
                }
            }
        }
    }
}