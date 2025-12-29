namespace SistemaDeCaixa.Telas
{
    partial class CadastroDeProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblPreco;
        private TextBox txtPreco;
        private Label lblCategoria;
        private ComboBox cbCategoria;
        private Button btnSalvar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblPreco = new Label();
            txtPreco = new TextBox();
            lblCategoria = new Label();
            cbCategoria = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtDesconto = new TextBox();
            label1 = new Label();
            cbTipoDeProduto = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(255, 128, 0);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(284, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de Produto";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = SystemColors.Control;
            lblNome.Location = new Point(20, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 27);
            txtNome.TabIndex = 2;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = SystemColors.Control;
            lblCodigo.Location = new Point(20, 137);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(112, 20);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Código Interno:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(20, 160);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 27);
            txtCodigo.TabIndex = 4;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.ForeColor = SystemColors.Control;
            lblPreco.Location = new Point(20, 200);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(49, 20);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(20, 223);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(150, 27);
            txtPreco.TabIndex = 6;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.ForeColor = SystemColors.Control;
            lblCategoria.Location = new Point(21, 396);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.Items.AddRange(new object[] { "Roupas", "Calçados", "Acessórios", "Outros" });
            cbCategoria.Location = new Point(21, 419);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(200, 28);
            cbCategoria.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(30, 90, 160);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(21, 471);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 32);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(147, 471);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 32);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(21, 349);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(150, 27);
            txtDesconto.TabIndex = 13;
            txtDesconto.KeyPress += txtDesconto_KeyPress;
            txtDesconto.Leave += txtDesconto_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(21, 326);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 14;
            label1.Text = "Desconto:";
            // 
            // cbTipoDeProduto
            // 
            cbTipoDeProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDeProduto.Items.AddRange(new object[] { "Roupas", "Calçados", "Acessórios", "Outros" });
            cbTipoDeProduto.Location = new Point(21, 286);
            cbTipoDeProduto.Name = "cbTipoDeProduto";
            cbTipoDeProduto.Size = new Size(200, 28);
            cbTipoDeProduto.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(20, 265);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 16;
            label2.Text = "Tipo de produto:";
            // 
            // CadastroDeProdutos
            // 
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(420, 514);
            Controls.Add(label2);
            Controls.Add(cbTipoDeProduto);
            Controls.Add(label1);
            Controls.Add(txtDesconto);
            Controls.Add(lblTitulo);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblPreco);
            Controls.Add(txtPreco);
            Controls.Add(lblCategoria);
            Controls.Add(cbCategoria);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CadastroDeProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += CadastroDeProdutos_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtDesconto;
        private Label label1;
        private ComboBox cbTipoDeProduto;
        private Label label2;
    }
}