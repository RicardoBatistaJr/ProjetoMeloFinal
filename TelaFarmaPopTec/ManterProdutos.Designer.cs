namespace TelaFarmaPopTec
{
    partial class ManterProdutos
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
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.textBoxSaldoProduto = new System.Windows.Forms.TextBox();
            this.textBoxDataFabricacao = new System.Windows.Forms.TextBox();
            this.textBoxPrecoProduto = new System.Windows.Forms.TextBox();
            this.textBoxAlterarStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btInserirProduto = new System.Windows.Forms.Button();
            this.btDeletarProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btAlterarStatus = new System.Windows.Forms.Button();
            this.btDesativarProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(27, 53);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(342, 20);
            this.textBoxNomeProduto.TabIndex = 0;
            // 
            // textBoxSaldoProduto
            // 
            this.textBoxSaldoProduto.Location = new System.Drawing.Point(27, 96);
            this.textBoxSaldoProduto.Name = "textBoxSaldoProduto";
            this.textBoxSaldoProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxSaldoProduto.TabIndex = 1;
            // 
            // textBoxDataFabricacao
            // 
            this.textBoxDataFabricacao.Location = new System.Drawing.Point(148, 96);
            this.textBoxDataFabricacao.Name = "textBoxDataFabricacao";
            this.textBoxDataFabricacao.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataFabricacao.TabIndex = 2;
            // 
            // textBoxPrecoProduto
            // 
            this.textBoxPrecoProduto.Location = new System.Drawing.Point(269, 96);
            this.textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            this.textBoxPrecoProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecoProduto.TabIndex = 3;
            // 
            // textBoxAlterarStatus
            // 
            this.textBoxAlterarStatus.Location = new System.Drawing.Point(27, 194);
            this.textBoxAlterarStatus.Name = "textBoxAlterarStatus";
            this.textBoxAlterarStatus.Size = new System.Drawing.Size(221, 20);
            this.textBoxAlterarStatus.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saldo do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de Fabricação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preço do Produto";
            // 
            // btInserirProduto
            // 
            this.btInserirProduto.Location = new System.Drawing.Point(27, 134);
            this.btInserirProduto.Name = "btInserirProduto";
            this.btInserirProduto.Size = new System.Drawing.Size(139, 23);
            this.btInserirProduto.TabIndex = 10;
            this.btInserirProduto.Text = "Inserir Produto";
            this.btInserirProduto.UseVisualStyleBackColor = true;
            this.btInserirProduto.Click += new System.EventHandler(this.BtInserirProduto_Click);
            // 
            // btDeletarProduto
            // 
            this.btDeletarProduto.Location = new System.Drawing.Point(27, 220);
            this.btDeletarProduto.Name = "btDeletarProduto";
            this.btDeletarProduto.Size = new System.Drawing.Size(66, 23);
            this.btDeletarProduto.TabIndex = 11;
            this.btDeletarProduto.Text = "Deletar Produto";
            this.btDeletarProduto.UseVisualStyleBackColor = true;
            this.btDeletarProduto.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Insira o Código do Produto";
            // 
            // btAlterarStatus
            // 
            this.btAlterarStatus.Location = new System.Drawing.Point(99, 220);
            this.btAlterarStatus.Name = "btAlterarStatus";
            this.btAlterarStatus.Size = new System.Drawing.Size(67, 23);
            this.btAlterarStatus.TabIndex = 13;
            this.btAlterarStatus.Text = "Ativar Produto";
            this.btAlterarStatus.UseVisualStyleBackColor = true;
            this.btAlterarStatus.Click += new System.EventHandler(this.BtAlterarStatus_Click);
            // 
            // btDesativarProduto
            // 
            this.btDesativarProduto.Location = new System.Drawing.Point(172, 220);
            this.btDesativarProduto.Name = "btDesativarProduto";
            this.btDesativarProduto.Size = new System.Drawing.Size(76, 23);
            this.btDesativarProduto.TabIndex = 14;
            this.btDesativarProduto.Text = "Desativar";
            this.btDesativarProduto.UseVisualStyleBackColor = true;
            this.btDesativarProduto.Click += new System.EventHandler(this.BtDesativarProduto_Click);
            // 
            // ManterProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 295);
            this.Controls.Add(this.btDesativarProduto);
            this.Controls.Add(this.btAlterarStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btDeletarProduto);
            this.Controls.Add(this.btInserirProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAlterarStatus);
            this.Controls.Add(this.textBoxPrecoProduto);
            this.Controls.Add(this.textBoxDataFabricacao);
            this.Controls.Add(this.textBoxSaldoProduto);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Name = "ManterProdutos";
            this.Text = "ManterProdutos";
            this.Load += new System.EventHandler(this.ManterProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.TextBox textBoxSaldoProduto;
        private System.Windows.Forms.TextBox textBoxDataFabricacao;
        private System.Windows.Forms.TextBox textBoxPrecoProduto;
        private System.Windows.Forms.TextBox textBoxAlterarStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btInserirProduto;
        private System.Windows.Forms.Button btDeletarProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAlterarStatus;
        private System.Windows.Forms.Button btDesativarProduto;
    }
}