namespace SistemaDeCaixa.Telas
{
    partial class CadastroDeCategorias
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
            lblTitulo = new Label();
            label1 = new Label();
            txtNomeCategoria = new TextBox();
            btnSalvar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(255, 128, 0);
            lblTitulo.Location = new Point(12, 43);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(304, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastro de Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(18, 149);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(275, 27);
            txtNomeCategoria.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.Location = new Point(18, 218);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Silver;
            btnVoltar.Location = new Point(199, 218);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 29);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // CadastroDeCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(342, 332);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeCategoria);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            MaximumSize = new Size(360, 379);
            MinimumSize = new Size(360, 379);
            Name = "CadastroDeCategorias";
            Text = "Cadastro de Categorias";
            Load += CadastroDeCategorias_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private TextBox txtNomeCategoria;
        private Button btnSalvar;
        private Button btnVoltar;
    }
}