namespace SistemaDeCaixa.Telas
{
    partial class ListaFuncionarioscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaFuncionarioscs));
            panel1 = new Panel();
            dgvFuncionario = new DataGridView();
            panel2 = new Panel();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvFuncionario);
            panel1.Location = new Point(0, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(1369, 520);
            panel1.TabIndex = 0;
            // 
            // dgvFuncionario
            // 
            dgvFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.Location = new Point(0, 3);
            dgvFuncionario.Name = "dgvFuncionario";
            dgvFuncionario.RowHeadersWidth = 51;
            dgvFuncionario.Size = new Size(1366, 517);
            dgvFuncionario.TabIndex = 0;
            dgvFuncionario.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPesquisar);
            panel2.Controls.Add(txtPesquisar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1374, 66);
            panel2.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Location = new Point(1105, 20);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(180, 29);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisar.Location = new Point(32, 22);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(949, 27);
            txtPesquisar.TabIndex = 0;
            // 
            // ListaFuncionarioscs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(1374, 631);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListaFuncionarioscs";
            Text = "ListaFuncionarioscs";
            Load += ListaFuncionarioscs_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvFuncionario;
        private Panel panel2;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
    }
}