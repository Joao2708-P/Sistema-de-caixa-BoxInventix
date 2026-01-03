namespace SistemaDeCaixa.Telas
{
    partial class Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            lblProduto = new Label();
            txtProduto = new TextBox();
            btnAdicionar = new Button();
            lblSubtotal = new Label();
            lblTotal = new Label();
            btnFinalizar = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            btnCancelarVenda = new Button();
            lbTotal = new Label();
            lbSubTotal = new Label();
            panel2 = new Panel();
            dgvCarrinho = new DataGridView();
            btnCancelar = new DataGridViewButtonColumn();
            colName = new DataGridViewTextBoxColumn();
            colPreco = new DataGridViewTextBoxColumn();
            colQuantidade = new DataGridViewTextBoxColumn();
            colPesoPorKG = new DataGridViewTextBoxColumn();
            colDesconto = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            SuspendLayout();
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 11F);
            lblProduto.ForeColor = SystemColors.Control;
            lblProduto.Location = new Point(9, 1);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(145, 25);
            lblProduto.TabIndex = 0;
            lblProduto.Text = "Código / Nome:";
            // 
            // txtProduto
            // 
            txtProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProduto.Font = new Font("Segoe UI", 11F);
            txtProduto.Location = new Point(9, 29);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(661, 32);
            txtProduto.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.Font = new Font("Segoe UI", 11F);
            btnAdicionar.Location = new Point(692, 28);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(236, 32);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubtotal.Font = new Font("Segoe UI", 12F);
            lblSubtotal.ForeColor = Color.FromArgb(255, 128, 0);
            lblSubtotal.Location = new Point(706, 19);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(121, 25);
            lblSubtotal.TabIndex = 5;
            lblSubtotal.Text = "Subtotal: R$ ";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.ForeColor = SystemColors.Control;
            lblTotal.Location = new Point(690, 64);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(137, 35);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "TOTAL: R$";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnFinalizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFinalizar.Location = new Point(13, 139);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(914, 45);
            btnFinalizar.TabIndex = 7;
            btnFinalizar.Text = "FINALIZAR VENDA";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(419, 16);
            label1.Name = "label1";
            label1.Size = new Size(132, 35);
            label1.TabIndex = 8;
            label1.Text = "SUCESSO! ";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(343, 64);
            label2.Name = "label2";
            label2.Size = new Size(258, 35);
            label2.TabIndex = 9;
            label2.Text = "ERRO AO FINALIZAR! ";
            label2.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtProduto);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(lblProduto);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 89);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancelarVenda);
            panel3.Controls.Add(lbTotal);
            panel3.Controls.Add(lbSubTotal);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnFinalizar);
            panel3.Controls.Add(lblSubtotal);
            panel3.Controls.Add(lblTotal);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 573);
            panel3.Name = "panel3";
            panel3.Size = new Size(940, 204);
            panel3.TabIndex = 12;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.Font = new Font("Segoe UI", 12F);
            btnCancelarVenda.Location = new Point(41, 58);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(123, 43);
            btnCancelarVenda.TabIndex = 12;
            btnCancelarVenda.Text = "Cancelar";
            btnCancelarVenda.UseVisualStyleBackColor = true;
            btnCancelarVenda.Click += btnCancelarVenda_Click;
            // 
            // lbTotal
            // 
            lbTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTotal.ForeColor = SystemColors.Control;
            lbTotal.Location = new Point(818, 64);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(63, 35);
            lbTotal.TabIndex = 11;
            lbTotal.Text = "0,00";
            lbTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbSubTotal
            // 
            lbSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbSubTotal.Font = new Font("Segoe UI", 12F);
            lbSubTotal.ForeColor = Color.FromArgb(255, 128, 0);
            lbSubTotal.Location = new Point(818, 19);
            lbSubTotal.Name = "lbSubTotal";
            lbSubTotal.Size = new Size(50, 25);
            lbSubTotal.TabIndex = 10;
            lbSubTotal.Text = "0,00";
            lbSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dgvCarrinho);
            panel2.Location = new Point(8, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 472);
            panel2.TabIndex = 13;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Columns.AddRange(new DataGridViewColumn[] { btnCancelar, colName, colPreco, colQuantidade, colPesoPorKG, colDesconto, colSubtotal });
            dgvCarrinho.Location = new Point(-8, 3);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.RowHeadersWidth = 51;
            dgvCarrinho.Size = new Size(937, 462);
            dgvCarrinho.TabIndex = 0;
            dgvCarrinho.CellContentClick += dgvCarrinho_CellContentClick;
            // 
            // btnCancelar
            // 
            btnCancelar.HeaderText = "Cancelar";
            btnCancelar.MinimumWidth = 6;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Width = 125;
            // 
            // colName
            // 
            colName.HeaderText = "Nome";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 125;
            // 
            // colPreco
            // 
            colPreco.HeaderText = "Preço";
            colPreco.MinimumWidth = 6;
            colPreco.Name = "colPreco";
            colPreco.Width = 125;
            // 
            // colQuantidade
            // 
            colQuantidade.HeaderText = "Quantidade";
            colQuantidade.MinimumWidth = 6;
            colQuantidade.Name = "colQuantidade";
            colQuantidade.Width = 125;
            // 
            // colPesoPorKG
            // 
            colPesoPorKG.HeaderText = "KG";
            colPesoPorKG.MinimumWidth = 6;
            colPesoPorKG.Name = "colPesoPorKG";
            colPesoPorKG.Width = 125;
            // 
            // colDesconto
            // 
            colDesconto.HeaderText = "Desconto";
            colDesconto.MinimumWidth = 6;
            colDesconto.Name = "colDesconto";
            colDesconto.Width = 125;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "SubTotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.Width = 125;
            // 
            // Caixa
            // 
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(940, 777);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Caixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caixa (PDV)";
            Load += Caixa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFinalizar;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvCarrinho;
        private Label lbSubTotal;
        private Label lbTotal;
        private DataGridViewButtonColumn btnCancelar;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPreco;
        private DataGridViewTextBoxColumn colQuantidade;
        private DataGridViewTextBoxColumn colPesoPorKG;
        private DataGridViewTextBoxColumn colDesconto;
        private DataGridViewTextBoxColumn colSubtotal;
        private Button btnCancelarVenda;
    }
}