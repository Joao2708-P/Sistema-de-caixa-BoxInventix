namespace SistemaDeCaixa.Telas
{
    partial class CadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            btnCadastrar = new Button();
            txtSenhaFunc = new TextBox();
            txtEmailFunc = new TextBox();
            txtLoginFunc = new TextBox();
            txtNomeFunc = new TextBox();
            txtLojaIdFunc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtConfirmSenha = new TextBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            cbCargo = new ComboBox();
            lbNomeNulo = new Label();
            lbLoginNulo = new Label();
            lbConfirmarNulo = new Label();
            lbLoginError = new Label();
            lbSenhaError = new Label();
            lbLoginExiste = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(275, 452);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(160, 45);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenhaFunc
            // 
            txtSenhaFunc.Location = new Point(422, 229);
            txtSenhaFunc.Name = "txtSenhaFunc";
            txtSenhaFunc.Size = new Size(193, 27);
            txtSenhaFunc.TabIndex = 2;
            // 
            // txtEmailFunc
            // 
            txtEmailFunc.Location = new Point(91, 312);
            txtEmailFunc.Name = "txtEmailFunc";
            txtEmailFunc.Size = new Size(198, 27);
            txtEmailFunc.TabIndex = 3;
            txtEmailFunc.Validating += txtEmailFunc_Validating;
            // 
            // txtLoginFunc
            // 
            txtLoginFunc.Location = new Point(91, 229);
            txtLoginFunc.Name = "txtLoginFunc";
            txtLoginFunc.Size = new Size(198, 27);
            txtLoginFunc.TabIndex = 4;
            // 
            // txtNomeFunc
            // 
            txtNomeFunc.Location = new Point(91, 145);
            txtNomeFunc.Name = "txtNomeFunc";
            txtNomeFunc.Size = new Size(198, 27);
            txtNomeFunc.TabIndex = 6;
            // 
            // txtLojaIdFunc
            // 
            txtLojaIdFunc.Location = new Point(422, 145);
            txtLojaIdFunc.Name = "txtLojaIdFunc";
            txtLojaIdFunc.Size = new Size(193, 27);
            txtLojaIdFunc.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(91, 122);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 8;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(91, 206);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 9;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(91, 289);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 10;
            label3.Text = "Email ( opicional )";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 122);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(422, 206);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 12;
            label5.Text = "Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(252, 367);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 13;
            label6.Text = "Cargo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(422, 122);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 14;
            label7.Text = "Loja ID";
            // 
            // txtConfirmSenha
            // 
            txtConfirmSenha.Location = new Point(422, 312);
            txtConfirmSenha.Name = "txtConfirmSenha";
            txtConfirmSenha.Size = new Size(193, 27);
            txtConfirmSenha.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(422, 289);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 16;
            label8.Text = "Confirmar Senha";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.LogoSeparada_resized_removebg_preview;
            pictureBox2.Location = new Point(168, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(359, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // cbCargo
            // 
            cbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(252, 390);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(219, 28);
            cbCargo.TabIndex = 19;
            cbCargo.SelectedIndexChanged += cbCargo_SelectedIndexChanged;
            // 
            // lbNomeNulo
            // 
            lbNomeNulo.AutoSize = true;
            lbNomeNulo.ForeColor = Color.Red;
            lbNomeNulo.Location = new Point(91, 175);
            lbNomeNulo.Name = "lbNomeNulo";
            lbNomeNulo.Size = new Size(124, 20);
            lbNomeNulo.TabIndex = 20;
            lbNomeNulo.Text = "Preencha o nome";
            lbNomeNulo.Visible = false;
            // 
            // lbLoginNulo
            // 
            lbLoginNulo.AutoSize = true;
            lbLoginNulo.ForeColor = Color.Red;
            lbLoginNulo.Location = new Point(91, 259);
            lbLoginNulo.Name = "lbLoginNulo";
            lbLoginNulo.Size = new Size(120, 20);
            lbLoginNulo.TabIndex = 21;
            lbLoginNulo.Text = "Preencha o login";
            lbLoginNulo.Visible = false;
            // 
            // lbConfirmarNulo
            // 
            lbConfirmarNulo.AutoSize = true;
            lbConfirmarNulo.ForeColor = Color.Red;
            lbConfirmarNulo.Location = new Point(422, 342);
            lbConfirmarNulo.Name = "lbConfirmarNulo";
            lbConfirmarNulo.Size = new Size(192, 20);
            lbConfirmarNulo.TabIndex = 25;
            lbConfirmarNulo.Text = "Preencha o confirmar senha";
            lbConfirmarNulo.Visible = false;
            // 
            // lbLoginError
            // 
            lbLoginError.AutoSize = true;
            lbLoginError.ForeColor = Color.Red;
            lbLoginError.Location = new Point(91, 259);
            lbLoginError.Name = "lbLoginError";
            lbLoginError.Size = new Size(120, 20);
            lbLoginError.TabIndex = 26;
            lbLoginError.Text = "Preencha o login";
            lbLoginError.Visible = false;
            // 
            // lbSenhaError
            // 
            lbSenhaError.AutoSize = true;
            lbSenhaError.ForeColor = Color.Red;
            lbSenhaError.Location = new Point(417, 259);
            lbSenhaError.Name = "lbSenhaError";
            lbSenhaError.Size = new Size(124, 20);
            lbSenhaError.TabIndex = 27;
            lbSenhaError.Text = "Preencha o nome";
            lbSenhaError.Visible = false;
            // 
            // lbLoginExiste
            // 
            lbLoginExiste.AutoSize = true;
            lbLoginExiste.ForeColor = Color.Red;
            lbLoginExiste.Location = new Point(217, 259);
            lbLoginExiste.Name = "lbLoginExiste";
            lbLoginExiste.Size = new Size(109, 20);
            lbLoginExiste.TabIndex = 28;
            lbLoginExiste.Text = "Login Existente";
            lbLoginExiste.Visible = false;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(721, 509);
            Controls.Add(lbLoginExiste);
            Controls.Add(lbSenhaError);
            Controls.Add(lbLoginError);
            Controls.Add(lbConfirmarNulo);
            Controls.Add(lbNomeNulo);
            Controls.Add(cbCargo);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(txtConfirmSenha);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLojaIdFunc);
            Controls.Add(txtNomeFunc);
            Controls.Add(txtLoginFunc);
            Controls.Add(txtEmailFunc);
            Controls.Add(txtSenhaFunc);
            Controls.Add(btnCadastrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroFuncionario";
            Text = "Cadastro de Funcionário";
            Load += CadastroFuncionario_Load;
            Shown += CadastroFuncionario_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCadastrar;
        private TextBox txtSenhaFunc;
        private TextBox txtEmailFunc;
        private TextBox txtLoginFunc;
        private TextBox txtNomeFunc;
        private TextBox txtLojaIdFunc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtConfirmSenha;
        private Label label8;
        private PictureBox pictureBox2;
        private ComboBox cbCargo;
        private Label lbNomeNulo;
        private Label lbLoginNulo;
        private Label lb;
        private Label label11;
        private Label label12;
        private Label lbConfirmarNulo;
        private Label lbLoginError;
        private Label lbSenhaError;
        private Label lbLoginExiste;
    }
}