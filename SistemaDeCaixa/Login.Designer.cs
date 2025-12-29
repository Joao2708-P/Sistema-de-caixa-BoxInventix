namespace SistemaDeCaixa
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(208, 314);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(160, 45);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(150, 170);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "Email / Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(150, 243);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(150, 193);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(280, 27);
            txtLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(150, 266);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(280, 27);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.LogoSeparada_resized_removebg_preview;
            pictureBox1.Location = new Point(150, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(580, 380);
            Controls.Add(pictureBox1);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnEntrar;
        private Label label1;
        private Label label2;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private PictureBox pictureBox1;
    }
}
