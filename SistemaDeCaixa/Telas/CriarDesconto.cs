using SistemaDeCaixa.Models;
using SistemaDeCaixa.Repository;
using System.Data;

namespace SistemaDeCaixa.Telas
{
    public partial class CriarDesconto : Form
    {
        private readonly DescontosRepository _repo = new DescontosRepository();
        DataTable dt;

        public CriarDesconto()
        {
            InitializeComponent();
        }

        private void MapearGrid()
        {
            dgvDescontos.AutoGenerateColumns = false;

            dgvDescontos.Columns["colId"].DataPropertyName = "ID";
            dgvDescontos.Columns["colNome"].DataPropertyName = "Nome";
            dgvDescontos.Columns["colValor"].DataPropertyName = "Valor";
            dgvDescontos.Columns["colCodigo"].DataPropertyName = "Codigo";
            dgvDescontos.Columns["colDescricao"].DataPropertyName = "Descricao";
            dgvDescontos.Columns["colValidade"].DataPropertyName = "Validade";
        }

        private void CarregarGrid()
        {
             dt = _repo.descontoPorLoja(Sessao.LojaId);
            dgvDescontos.DataSource = dt;
        }

        private bool CamposValidos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtCodigo.Text)) return false;
            if (!decimal.TryParse(txtValor.Text, out _)) return false;
            if (datValidation.Value.Date < DateTime.Today) return false;

            return true;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCodigo.Clear();
            txtValor.Clear();
            txtDescricao.Clear();
            datValidation.Value = DateTime.Today;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CamposValidos())
                {
                    MessageBox.Show(
                        "Preencha todos os campos corretamente.",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                _repo.Criar(
                    api_id: null,
                    funcionario_id: Sessao.UsuarioLogado.ID, // usando sessão corretamente
                    Nome: txtNome.Text.Trim(),
                    Valor: decimal.Parse(txtValor.Text),
                    Codigo: txtCodigo.Text.Trim(),
                    Descricao: txtDescricao.Text.Trim(),
                    Validade: datValidation.Value
                );

                MessageBox.Show(
                    "Desconto salvo com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimparCampos();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao salvar desconto:\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            HelperDePesquisa.Filtrar(dgvDescontos, dt, txtPesquisar.Text, "Nome");
        }

        private void CriarDesconto_Load(object sender, EventArgs e)
        {
            dgvDescontos.AutoGenerateColumns = false;
            dgvDescontos.AllowUserToAddRows = false;

            MapearGrid();
            CarregarGrid();
        }

        private void dgvDescontos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvDescontos.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var linha = dgvDescontos.Rows[e.RowIndex];

                bool marcado = Convert.ToBoolean(linha.Cells["colCheck"].Value);

                if (!marcado)
                {
                    MessageBox.Show("Selecione o desconto para excluir.");
                    return;
                }

                int id = Convert.ToInt32(linha.Cells["colId"].Value);

                var confirmar = MessageBox.Show(
                    "Deseja realmente excluir este desconto?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmar == DialogResult.Yes)
                {
                    _repo.Deletar(id); // 🔥 chama o repository

                    MessageBox.Show("Desconto excluído com sucesso!");

                    CarregarGrid();
                }
            }
        }
    }
}
