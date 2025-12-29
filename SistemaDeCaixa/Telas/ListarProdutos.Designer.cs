namespace SistemaDeCaixa.Telas
{
    partial class ListarProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            panel2 = new Panel();
            dgvProdutos = new DataGridView();
            colMarca = new DataGridViewCheckBoxColumn();
            colProdutoId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colPreco = new DataGridViewTextBoxColumn();
            colCodigoDeBarras = new DataGridViewTextBoxColumn();
            colCategoriaNome = new DataGridViewTextBoxColumn();
            colCategoriaId = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(txtPesquisa);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1374, 65);
            panel1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.White;
            btnEditar.Location = new Point(1027, 20);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(103, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackColor = Color.White;
            btnExcluir.Location = new Point(1136, 20);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(103, 29);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackColor = Color.White;
            btnPesquisar.Location = new Point(1245, 20);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(103, 29);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar ";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(12, 20);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(975, 27);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dgvProdutos);
            panel2.Location = new Point(0, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(1374, 485);
            panel2.TabIndex = 1;
            // 
            // dgvProdutos
            // 
            dgvProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { colMarca, colProdutoId, colNome, colPreco, colCodigoDeBarras, colCategoriaNome, colCategoriaId });
            dgvProdutos.Location = new Point(3, 14);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 100;
            dgvProdutos.Size = new Size(1368, 468);
            dgvProdutos.TabIndex = 0;
            // 
            // colMarca
            // 
            colMarca.HeaderText = "Marcar";
            colMarca.MinimumWidth = 6;
            colMarca.Name = "colMarca";
            colMarca.Width = 125;
            // 
            // colProdutoId
            // 
            colProdutoId.HeaderText = "Produto Id";
            colProdutoId.MinimumWidth = 6;
            colProdutoId.Name = "colProdutoId";
            colProdutoId.Width = 125;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.Width = 125;
            // 
            // colPreco
            // 
            colPreco.HeaderText = "Preço";
            colPreco.MinimumWidth = 6;
            colPreco.Name = "colPreco";
            colPreco.Width = 125;
            // 
            // colCodigoDeBarras
            // 
            colCodigoDeBarras.HeaderText = "Código de barras";
            colCodigoDeBarras.MinimumWidth = 6;
            colCodigoDeBarras.Name = "colCodigoDeBarras";
            colCodigoDeBarras.Width = 125;
            // 
            // colCategoriaNome
            // 
            colCategoriaNome.HeaderText = "Categoria";
            colCategoriaNome.MinimumWidth = 6;
            colCategoriaNome.Name = "colCategoriaNome";
            colCategoriaNome.Width = 125;
            // 
            // colCategoriaId
            // 
            colCategoriaId.HeaderText = "Categoria ID";
            colCategoriaId.MinimumWidth = 6;
            colCategoriaId.Name = "colCategoriaId";
            colCategoriaId.Visible = false;
            colCategoriaId.Width = 125;
            // 
            // ListarProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(1374, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ListarProdutos";
            Text = "Listar Produtos";
            Load += ListarProdutos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvProdutos;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private Button btnExcluir;
        private Button btnEditar;
        private DataGridViewCheckBoxColumn colMarca;
        private DataGridViewTextBoxColumn colProdutoId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colPreco;
        private DataGridViewTextBoxColumn colCodigoDeBarras;
        private DataGridViewTextBoxColumn colCategoriaNome;
        private DataGridViewTextBoxColumn colCategoriaId;
    }
}