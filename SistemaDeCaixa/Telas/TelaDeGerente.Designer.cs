namespace SistemaDeCaixa
{
    partial class TelaDeGerente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Button btnCadastroProduto;
        private Button btnCriarCategoria;
        private Button btnListarProdutos;
        private Button btnListarFuncionarios;
        private Button btnCadastrarFuncionario;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeGerente));
            lblTitulo = new Label();
            btnCadastroProduto = new Button();
            btnCriarCategoria = new Button();
            btnListarProdutos = new Button();
            btnListarFuncionarios = new Button();
            btnCadastrarFuncionario = new Button();
            btnLogout = new Button();
            btnCriarDescontos = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 90, 160);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(303, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Painel do Gerente";
            // 
            // btnCadastroProduto
            // 
            btnCadastroProduto.BackColor = Color.FromArgb(30, 90, 160);
            btnCadastroProduto.FlatStyle = FlatStyle.Flat;
            btnCadastroProduto.Font = new Font("Segoe UI", 12F);
            btnCadastroProduto.ForeColor = Color.White;
            btnCadastroProduto.Location = new Point(50, 100);
            btnCadastroProduto.Name = "btnCadastroProduto";
            btnCadastroProduto.Size = new Size(220, 60);
            btnCadastroProduto.TabIndex = 1;
            btnCadastroProduto.Text = "Cadastrar Produto";
            btnCadastroProduto.UseVisualStyleBackColor = false;
            btnCadastroProduto.Click += btnCadastroProduto_Click;
            // 
            // btnCriarCategoria
            // 
            btnCriarCategoria.BackColor = Color.FromArgb(30, 90, 160);
            btnCriarCategoria.FlatStyle = FlatStyle.Flat;
            btnCriarCategoria.Font = new Font("Segoe UI", 12F);
            btnCriarCategoria.ForeColor = Color.White;
            btnCriarCategoria.Location = new Point(320, 100);
            btnCriarCategoria.Name = "btnCriarCategoria";
            btnCriarCategoria.Size = new Size(220, 60);
            btnCriarCategoria.TabIndex = 2;
            btnCriarCategoria.Text = "Criar Categoria";
            btnCriarCategoria.UseVisualStyleBackColor = false;
            btnCriarCategoria.Click += btnCriarCategoria_Click;
            // 
            // btnListarProdutos
            // 
            btnListarProdutos.BackColor = Color.FromArgb(30, 90, 160);
            btnListarProdutos.FlatStyle = FlatStyle.Flat;
            btnListarProdutos.Font = new Font("Segoe UI", 12F);
            btnListarProdutos.ForeColor = Color.White;
            btnListarProdutos.Location = new Point(50, 200);
            btnListarProdutos.Name = "btnListarProdutos";
            btnListarProdutos.Size = new Size(220, 60);
            btnListarProdutos.TabIndex = 3;
            btnListarProdutos.Text = "Listar Produtos";
            btnListarProdutos.UseVisualStyleBackColor = false;
            btnListarProdutos.Click += btnListarProdutos_Click;
            // 
            // btnListarFuncionarios
            // 
            btnListarFuncionarios.BackColor = Color.FromArgb(30, 90, 160);
            btnListarFuncionarios.FlatStyle = FlatStyle.Flat;
            btnListarFuncionarios.Font = new Font("Segoe UI", 12F);
            btnListarFuncionarios.ForeColor = Color.White;
            btnListarFuncionarios.Location = new Point(320, 200);
            btnListarFuncionarios.Name = "btnListarFuncionarios";
            btnListarFuncionarios.Size = new Size(220, 60);
            btnListarFuncionarios.TabIndex = 4;
            btnListarFuncionarios.Text = "Listar Funcionários";
            btnListarFuncionarios.UseVisualStyleBackColor = false;
            btnListarFuncionarios.Click += btnListarFuncionarios_Click;
            // 
            // btnCadastrarFuncionario
            // 
            btnCadastrarFuncionario.BackColor = Color.FromArgb(30, 90, 160);
            btnCadastrarFuncionario.FlatStyle = FlatStyle.Flat;
            btnCadastrarFuncionario.Font = new Font("Segoe UI", 12F);
            btnCadastrarFuncionario.ForeColor = Color.White;
            btnCadastrarFuncionario.Location = new Point(50, 300);
            btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            btnCadastrarFuncionario.Size = new Size(220, 60);
            btnCadastrarFuncionario.TabIndex = 5;
            btnCadastrarFuncionario.Text = "Cadastrar Funcionário";
            btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            btnCadastrarFuncionario.Click += btnCadastrarFuncionario_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Gray;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(320, 300);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 60);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Sair";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCriarDescontos
            // 
            btnCriarDescontos.BackColor = Color.FromArgb(30, 90, 160);
            btnCriarDescontos.FlatStyle = FlatStyle.Flat;
            btnCriarDescontos.Font = new Font("Segoe UI", 12F);
            btnCriarDescontos.ForeColor = Color.White;
            btnCriarDescontos.Location = new Point(50, 391);
            btnCriarDescontos.Name = "btnCriarDescontos";
            btnCriarDescontos.Size = new Size(220, 60);
            btnCriarDescontos.TabIndex = 7;
            btnCriarDescontos.Text = "Criar Descontos";
            btnCriarDescontos.UseVisualStyleBackColor = false;
            btnCriarDescontos.Click += btnCriarDescontos_Click;
            // 
            // TelaDeGerente
            // 
            BackColor = Color.White;
            ClientSize = new Size(600, 488);
            Controls.Add(btnCriarDescontos);
            Controls.Add(lblTitulo);
            Controls.Add(btnCadastroProduto);
            Controls.Add(btnCriarCategoria);
            Controls.Add(btnListarProdutos);
            Controls.Add(btnListarFuncionarios);
            Controls.Add(btnCadastrarFuncionario);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaDeGerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel do Gerente";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCriarDescontos;
    }
}