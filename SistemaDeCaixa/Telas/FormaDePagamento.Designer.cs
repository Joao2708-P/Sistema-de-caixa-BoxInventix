namespace SistemaDeCaixa.Telas
{
    partial class FormaDePagamento
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label label;
        private ComboBox cbPagamento;
        private Label lblForma;
        private Label lblRecebido;
        private TextBox txtValorRecebido;
        private Label lblTroco;
        private Button btnConfirmar;
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
            label = new Label();
            lblForma = new Label();
            cbPagamento = new ComboBox();
            lblRecebido = new Label();
            txtValorRecebido = new TextBox();
            lblTroco = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            lbTotal = new Label();
            lbTroco = new Label();
            label2 = new Label();
            txtDesconto = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(255, 128, 0);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(164, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Pagamento";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label.ForeColor = SystemColors.Control;
            label.Location = new Point(20, 70);
            label.Name = "label";
            label.Size = new Size(109, 30);
            label.TabIndex = 1;
            label.Text = "Total: R$ ";
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.ForeColor = SystemColors.Control;
            lblForma.Location = new Point(20, 120);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(156, 20);
            lblForma.TabIndex = 2;
            lblForma.Text = "Forma de pagamento:";
            // 
            // cbPagamento
            // 
            cbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPagamento.Location = new Point(20, 143);
            cbPagamento.Name = "cbPagamento";
            cbPagamento.Size = new Size(200, 28);
            cbPagamento.TabIndex = 3;
            // 
            // lblRecebido
            // 
            lblRecebido.AutoSize = true;
            lblRecebido.ForeColor = SystemColors.Control;
            lblRecebido.Location = new Point(20, 267);
            lblRecebido.Name = "lblRecebido";
            lblRecebido.Size = new Size(184, 20);
            lblRecebido.TabIndex = 4;
            lblRecebido.Text = "Valor Recebido (Dinheiro):";
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.Location = new Point(20, 290);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.Size = new Size(120, 27);
            txtValorRecebido.TabIndex = 5;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTroco.ForeColor = Color.FromArgb(255, 128, 0);
            lblTroco.Location = new Point(20, 332);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(73, 25);
            lblTroco.TabIndex = 6;
            lblTroco.Text = "Troco: ";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(30, 90, 160);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(20, 371);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(120, 35);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(160, 371);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 35);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(89, 332);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 11;
            label1.Text = "R$ ";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbTotal.ForeColor = SystemColors.Control;
            lbTotal.Location = new Point(118, 70);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(58, 30);
            lbTotal.TabIndex = 12;
            lbTotal.Text = "0,00";
            // 
            // lbTroco
            // 
            lbTroco.AutoSize = true;
            lbTroco.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTroco.ForeColor = Color.FromArgb(255, 128, 0);
            lbTroco.Location = new Point(118, 332);
            lbTroco.Name = "lbTroco";
            lbTroco.Size = new Size(50, 25);
            lbTroco.TabIndex = 13;
            lbTroco.Text = "0,00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(20, 193);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 14;
            label2.Text = "Desconto:";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(20, 216);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(120, 27);
            txtDesconto.TabIndex = 15;
            // 
            // FormaDePagamento
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(380, 421);
            Controls.Add(txtDesconto);
            Controls.Add(label2);
            Controls.Add(lbTroco);
            Controls.Add(lbTotal);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(label);
            Controls.Add(lblForma);
            Controls.Add(cbPagamento);
            Controls.Add(lblRecebido);
            Controls.Add(txtValorRecebido);
            Controls.Add(lblTroco);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormaDePagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagamento";
            Load += FormaDePagamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label lbTotal;
        private Label lbTroco;
        private Label label2;
        private TextBox txtDesconto;
    }
}