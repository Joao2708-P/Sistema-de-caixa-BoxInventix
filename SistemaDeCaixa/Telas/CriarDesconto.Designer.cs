namespace SistemaDeCaixa.Telas
{
    partial class CriarDesconto
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlCabecalho;
        private Panel pnlGrid;

        private Label lblNome;
        private Label lblCodigo;
        private Label lblValor;
        private Label lblValidade;
        private Label lblDescricao;
        private Label lblPesquisar;

        private TextBox txtNome;
        private TextBox txtCodigo;
        private TextBox txtValor;
        private TextBox txtDescricao;
        private TextBox txtPesquisar;

        private DataGridView dgvDescontos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlCabecalho = new Panel();
            datValidation = new DateTimePicker();
            btnSalvar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblValor = new Label();
            txtValor = new TextBox();
            lblValidade = new Label();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            pnlGrid = new Panel();
            dgvDescontos = new DataGridView();
            btnDeletar = new DataGridViewButtonColumn();
            chkItem = new DataGridViewCheckBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            colCodigo = new DataGridViewTextBoxColumn();
            colDescricao = new DataGridViewTextBoxColumn();
            colValidade = new DataGridViewTextBoxColumn();
            pnlCabecalho.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDescontos).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.Controls.Add(datValidation);
            pnlCabecalho.Controls.Add(btnSalvar);
            pnlCabecalho.Controls.Add(lblNome);
            pnlCabecalho.Controls.Add(txtNome);
            pnlCabecalho.Controls.Add(lblCodigo);
            pnlCabecalho.Controls.Add(txtCodigo);
            pnlCabecalho.Controls.Add(lblValor);
            pnlCabecalho.Controls.Add(txtValor);
            pnlCabecalho.Controls.Add(lblValidade);
            pnlCabecalho.Controls.Add(lblDescricao);
            pnlCabecalho.Controls.Add(txtDescricao);
            pnlCabecalho.Controls.Add(lblPesquisar);
            pnlCabecalho.Controls.Add(txtPesquisar);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Padding = new Padding(10);
            pnlCabecalho.Size = new Size(1379, 220);
            pnlCabecalho.TabIndex = 1;
            // 
            // datValidation
            // 
            datValidation.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            datValidation.Format = DateTimePickerFormat.Custom;
            datValidation.Location = new Point(633, 30);
            datValidation.Name = "datValidation";
            datValidation.Size = new Size(297, 27);
            datValidation.TabIndex = 13;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(936, 28);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(10, 6);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do Desconto";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(10, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(260, 27);
            txtNome.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Location = new Point(290, 4);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(100, 23);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(290, 30);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(180, 27);
            txtCodigo.TabIndex = 3;
            // 
            // lblValor
            // 
            lblValor.ForeColor = Color.White;
            lblValor.Location = new Point(490, 4);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(100, 23);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor (%) ou R$";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(490, 30);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(120, 27);
            txtValor.TabIndex = 5;
            // 
            // lblValidade
            // 
            lblValidade.ForeColor = Color.White;
            lblValidade.Location = new Point(630, 6);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(100, 23);
            lblValidade.TabIndex = 6;
            lblValidade.Text = "Validade";
            // 
            // lblDescricao
            // 
            lblDescricao.ForeColor = Color.White;
            lblDescricao.Location = new Point(10, 60);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(100, 23);
            lblDescricao.TabIndex = 8;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(10, 90);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(600, 60);
            txtDescricao.TabIndex = 9;
            // 
            // lblPesquisar
            // 
            lblPesquisar.ForeColor = Color.White;
            lblPesquisar.Location = new Point(10, 154);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(100, 23);
            lblPesquisar.TabIndex = 10;
            lblPesquisar.Text = "Pesquisar Desconto";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(10, 180);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(600, 27);
            txtPesquisar.TabIndex = 11;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dgvDescontos);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(0, 220);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(10);
            pnlGrid.Size = new Size(1379, 320);
            pnlGrid.TabIndex = 0;
            // 
            // dgvDescontos
            // 
            dgvDescontos.AllowUserToAddRows = false;
            dgvDescontos.AllowUserToDeleteRows = false;
            dgvDescontos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDescontos.ColumnHeadersHeight = 29;
            dgvDescontos.Columns.AddRange(new DataGridViewColumn[] { btnDeletar, chkItem, colId, colNome, colValor, colCodigo, colDescricao, colValidade });
            dgvDescontos.Dock = DockStyle.Fill;
            dgvDescontos.Location = new Point(10, 10);
            dgvDescontos.Name = "dgvDescontos";
            dgvDescontos.ReadOnly = true;
            dgvDescontos.RowHeadersWidth = 51;
            dgvDescontos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDescontos.Size = new Size(1359, 300);
            dgvDescontos.TabIndex = 0;
            dgvDescontos.CellContentClick += dgvDescontos_CellContentClick;
            // 
            // btnDeletar
            // 
            btnDeletar.HeaderText = "Deletar";
            btnDeletar.MinimumWidth = 6;
            btnDeletar.Name = "btnDeletar";
            btnDeletar.ReadOnly = true;
            // 
            // chkItem
            // 
            chkItem.HeaderText = "";
            chkItem.MinimumWidth = 6;
            chkItem.Name = "chkItem";
            chkItem.ReadOnly = true;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colValor
            // 
            colValor.HeaderText = "Valor";
            colValor.MinimumWidth = 6;
            colValor.Name = "colValor";
            colValor.ReadOnly = true;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colDescricao
            // 
            colDescricao.HeaderText = "Descrição";
            colDescricao.MinimumWidth = 6;
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            // 
            // colValidade
            // 
            colValidade.HeaderText = "Validade";
            colValidade.MinimumWidth = 6;
            colValidade.Name = "colValidade";
            colValidade.ReadOnly = true;
            // 
            // CriarDesconto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(1379, 540);
            Controls.Add(pnlGrid);
            Controls.Add(pnlCabecalho);
            Name = "CriarDesconto";
            Text = "Descontos";
            Load += CriarDesconto_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDescontos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalvar;
        private DateTimePicker datValidation;
        private DataGridViewButtonColumn btnDeletar;
        private DataGridViewCheckBoxColumn chkItem;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDescricao;
        private DataGridViewTextBoxColumn colValidade;
    }
}
