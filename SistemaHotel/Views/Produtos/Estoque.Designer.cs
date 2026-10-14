namespace SistemaHotel.Produtos
{
    partial class FrmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoque));
            txtEstoque = new System.Windows.Forms.TextBox();
            cbFornecedor = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtValor = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtProduto = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtQuantidade = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnProduto = new System.Windows.Forms.Button();
            btnSalvar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtEstoque
            // 
            txtEstoque.Enabled = false;
            txtEstoque.Location = new System.Drawing.Point(120, 83);
            txtEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new System.Drawing.Size(77, 27);
            txtEstoque.TabIndex = 95;
            txtEstoque.TextChanged += txtEstoque_TextChanged;
            // 
            // cbFornecedor
            // 
            cbFornecedor.Enabled = false;
            cbFornecedor.FormattingEnabled = true;
            cbFornecedor.Location = new System.Drawing.Point(453, 26);
            cbFornecedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbFornecedor.Name = "cbFornecedor";
            cbFornecedor.Size = new System.Drawing.Size(145, 28);
            cbFornecedor.TabIndex = 91;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(360, 31);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(87, 20);
            label6.TabIndex = 94;
            label6.Text = "Fornecedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(47, 88);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 20);
            label5.TabIndex = 93;
            label5.Text = "Estoque:";
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Location = new System.Drawing.Point(521, 83);
            txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtValor.Name = "txtValor";
            txtValor.Size = new System.Drawing.Size(77, 27);
            txtValor.TabIndex = 90;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(468, 89);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 20);
            label4.TabIndex = 92;
            label4.Text = "Valor:";
            // 
            // txtProduto
            // 
            txtProduto.Enabled = false;
            txtProduto.Location = new System.Drawing.Point(120, 26);
            txtProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new System.Drawing.Size(145, 27);
            txtProduto.TabIndex = 97;
            txtProduto.TextChanged += txtProduto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(47, 31);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 20);
            label1.TabIndex = 96;
            label1.Text = "Produto:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Enabled = false;
            txtQuantidade.Location = new System.Drawing.Point(321, 83);
            txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new System.Drawing.Size(112, 27);
            txtQuantidade.TabIndex = 99;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(227, 88);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 20);
            label2.TabIndex = 98;
            label2.Text = "Quantidade:";
            // 
            // btnProduto
            // 
            btnProduto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProduto.Location = new System.Drawing.Point(275, 23);
            btnProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new System.Drawing.Size(31, 35);
            btnProduto.TabIndex = 100;
            btnProduto.Text = "+";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += BtnProduto_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSalvar.Enabled = false;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalvar.Image = (System.Drawing.Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new System.Drawing.Point(644, 23);
            btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(93, 100);
            btnSalvar.TabIndex = 101;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaption;
            ClientSize = new System.Drawing.Size(784, 168);
            Controls.Add(btnSalvar);
            Controls.Add(btnProduto);
            Controls.Add(txtQuantidade);
            Controls.Add(label2);
            Controls.Add(txtProduto);
            Controls.Add(label1);
            Controls.Add(txtEstoque);
            Controls.Add(cbFornecedor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtValor);
            Controls.Add(label4);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmEstoque";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Estoque";
            Activated += FrmEstoque_Activated;
            Load += FrmEstoque_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnSalvar;
    }
}