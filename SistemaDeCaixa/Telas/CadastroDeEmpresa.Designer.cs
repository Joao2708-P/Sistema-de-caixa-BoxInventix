namespace SistemaDeCaixa.Telas
{
    partial class CadastroDeEmpresa
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
            label1 = new Label();
            txtNomeLoja = new TextBox();
            txtCnpjLoja = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnCadastrar = new Button();
            label4 = new Label();
            txtEndereo = new TextBox();
            lbNome = new Label();
            lbEndereco = new Label();
            lbCnpj = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(110, 62);
            label1.Name = "label1";
            label1.Size = new Size(211, 35);
            label1.TabIndex = 0;
            label1.Text = "Cadastre sua loja!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNomeLoja
            // 
            txtNomeLoja.Location = new Point(64, 152);
            txtNomeLoja.Name = "txtNomeLoja";
            txtNomeLoja.Size = new Size(285, 27);
            txtNomeLoja.TabIndex = 1;
            // 
            // txtCnpjLoja
            // 
            txtCnpjLoja.Location = new Point(64, 320);
            txtCnpjLoja.Name = "txtCnpjLoja";
            txtCnpjLoja.Size = new Size(285, 27);
            txtCnpjLoja.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(64, 129);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(64, 297);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "Cnpj";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(123, 389);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(160, 45);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(64, 216);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 6;
            label4.Text = "Endereço";
            // 
            // txtEndereo
            // 
            txtEndereo.Location = new Point(64, 239);
            txtEndereo.Name = "txtEndereo";
            txtEndereo.Size = new Size(285, 27);
            txtEndereo.TabIndex = 7;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.ForeColor = Color.Red;
            lbNome.Location = new Point(66, 187);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(124, 20);
            lbNome.TabIndex = 8;
            lbNome.Text = "Preencha o nome";
            lbNome.Visible = false;
            // 
            // lbEndereco
            // 
            lbEndereco.AutoSize = true;
            lbEndereco.ForeColor = Color.Red;
            lbEndereco.Location = new Point(64, 269);
            lbEndereco.Name = "lbEndereco";
            lbEndereco.Size = new Size(148, 20);
            lbEndereco.TabIndex = 9;
            lbEndereco.Text = "Preencha o endereco";
            lbEndereco.Visible = false;
            // 
            // lbCnpj
            // 
            lbCnpj.AutoSize = true;
            lbCnpj.ForeColor = Color.Red;
            lbCnpj.Location = new Point(64, 350);
            lbCnpj.Name = "lbCnpj";
            lbCnpj.Size = new Size(118, 20);
            lbCnpj.TabIndex = 10;
            lbCnpj.Text = "Preencha o CNPJ";
            lbCnpj.Visible = false;
            // 
            // CadastroDeEmpresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(411, 467);
            Controls.Add(lbCnpj);
            Controls.Add(lbEndereco);
            Controls.Add(lbNome);
            Controls.Add(txtEndereo);
            Controls.Add(label4);
            Controls.Add(btnCadastrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCnpjLoja);
            Controls.Add(txtNomeLoja);
            Controls.Add(label1);
            Name = "CadastroDeEmpresa";
            Text = "CadastroDeEmpresa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeLoja;
        private TextBox txtCnpjLoja;
        private Label label2;
        private Label label3;
        private Button btnCadastrar;
        private Label label4;
        private TextBox txtEndereo;
        private Label lbNome;
        private Label lbEndereco;
        private Label lbCnpj;
    }
}