namespace TelaFarmaPopTec
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
            this.listViewVenda = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBoxCodVenda = new System.Windows.Forms.RichTextBox();
            this.labelCodVenda = new System.Windows.Forms.Label();
            this.richTextBoxCpf = new System.Windows.Forms.RichTextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.richTextBoxValorRecebido = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTroco = new System.Windows.Forms.RichTextBox();
            this.labelRecebido = new System.Windows.Forms.Label();
            this.labelTroco = new System.Windows.Forms.Label();
            this.labelDesconto = new System.Windows.Forms.Label();
            this.labelLiquido = new System.Windows.Forms.Label();
            this.rbDinheiro = new System.Windows.Forms.RadioButton();
            this.rbCartao = new System.Windows.Forms.RadioButton();
            this.buttonReceber = new System.Windows.Forms.Button();
            this.labelTotalVenda = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAdicionarProduto = new System.Windows.Forms.Button();
            this.buttonCancelarVenda = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.richTextBoxTotalVenda = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDesconto = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTotalLiq = new System.Windows.Forms.RichTextBox();
            this.buttonPesquisarVenda = new System.Windows.Forms.Button();
            this.buttonDesconto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewVenda
            // 
            this.listViewVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewVenda.Location = new System.Drawing.Point(23, 24);
            this.listViewVenda.Name = "listViewVenda";
            this.listViewVenda.Size = new System.Drawing.Size(349, 284);
            this.listViewVenda.TabIndex = 8;
            this.listViewVenda.UseCompatibleStateImageBehavior = false;
            this.listViewVenda.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quant.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Produto";
            this.columnHeader2.Width = 196;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor Unid.";
            this.columnHeader3.Width = 99;
            // 
            // richTextBoxCodVenda
            // 
            this.richTextBoxCodVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCodVenda.Location = new System.Drawing.Point(519, 61);
            this.richTextBoxCodVenda.Name = "richTextBoxCodVenda";
            this.richTextBoxCodVenda.Size = new System.Drawing.Size(207, 41);
            this.richTextBoxCodVenda.TabIndex = 2;
            this.richTextBoxCodVenda.Text = "";
            // 
            // labelCodVenda
            // 
            this.labelCodVenda.AutoSize = true;
            this.labelCodVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodVenda.Location = new System.Drawing.Point(386, 78);
            this.labelCodVenda.Name = "labelCodVenda";
            this.labelCodVenda.Size = new System.Drawing.Size(127, 24);
            this.labelCodVenda.TabIndex = 2;
            this.labelCodVenda.Text = "Cod. Venda:";
            // 
            // richTextBoxCpf
            // 
            this.richTextBoxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCpf.Location = new System.Drawing.Point(447, 12);
            this.richTextBoxCpf.MaxLength = 11;
            this.richTextBoxCpf.Name = "richTextBoxCpf";
            this.richTextBoxCpf.Size = new System.Drawing.Size(279, 43);
            this.richTextBoxCpf.TabIndex = 1;
            this.richTextBoxCpf.Text = "";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpf.Location = new System.Drawing.Point(385, 31);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(56, 24);
            this.labelCpf.TabIndex = 6;
            this.labelCpf.Text = "CPF:";
            // 
            // richTextBoxValorRecebido
            // 
            this.richTextBoxValorRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxValorRecebido.Location = new System.Drawing.Point(405, 398);
            this.richTextBoxValorRecebido.Name = "richTextBoxValorRecebido";
            this.richTextBoxValorRecebido.Size = new System.Drawing.Size(207, 41);
            this.richTextBoxValorRecebido.TabIndex = 6;
            this.richTextBoxValorRecebido.Text = "";
            // 
            // richTextBoxTroco
            // 
            this.richTextBoxTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTroco.Location = new System.Drawing.Point(405, 445);
            this.richTextBoxTroco.Name = "richTextBoxTroco";
            this.richTextBoxTroco.Size = new System.Drawing.Size(207, 37);
            this.richTextBoxTroco.TabIndex = 7;
            this.richTextBoxTroco.Text = "";
            // 
            // labelRecebido
            // 
            this.labelRecebido.AutoSize = true;
            this.labelRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecebido.Location = new System.Drawing.Point(244, 401);
            this.labelRecebido.Name = "labelRecebido";
            this.labelRecebido.Size = new System.Drawing.Size(161, 24);
            this.labelRecebido.TabIndex = 11;
            this.labelRecebido.Text = "Valor Recebido:";
            // 
            // labelTroco
            // 
            this.labelTroco.AutoSize = true;
            this.labelTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTroco.Location = new System.Drawing.Point(334, 454);
            this.labelTroco.Name = "labelTroco";
            this.labelTroco.Size = new System.Drawing.Size(71, 24);
            this.labelTroco.TabIndex = 12;
            this.labelTroco.Text = "Troco:";
            // 
            // labelDesconto
            // 
            this.labelDesconto.AutoSize = true;
            this.labelDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesconto.Location = new System.Drawing.Point(409, 172);
            this.labelDesconto.Name = "labelDesconto";
            this.labelDesconto.Size = new System.Drawing.Size(104, 24);
            this.labelDesconto.TabIndex = 14;
            this.labelDesconto.Text = "Desconto:";
            // 
            // labelLiquido
            // 
            this.labelLiquido.AutoSize = true;
            this.labelLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLiquido.Location = new System.Drawing.Point(411, 219);
            this.labelLiquido.Name = "labelLiquido";
            this.labelLiquido.Size = new System.Drawing.Size(102, 24);
            this.labelLiquido.TabIndex = 16;
            this.labelLiquido.Text = "Total Liq.:";
            // 
            // rbDinheiro
            // 
            this.rbDinheiro.AutoSize = true;
            this.rbDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDinheiro.Location = new System.Drawing.Point(445, 346);
            this.rbDinheiro.Name = "rbDinheiro";
            this.rbDinheiro.Size = new System.Drawing.Size(107, 28);
            this.rbDinheiro.TabIndex = 17;
            this.rbDinheiro.TabStop = true;
            this.rbDinheiro.Text = "Dinheiro";
            this.rbDinheiro.UseVisualStyleBackColor = true;
            // 
            // rbCartao
            // 
            this.rbCartao.AutoSize = true;
            this.rbCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCartao.Location = new System.Drawing.Point(575, 346);
            this.rbCartao.Name = "rbCartao";
            this.rbCartao.Size = new System.Drawing.Size(88, 28);
            this.rbCartao.TabIndex = 18;
            this.rbCartao.TabStop = true;
            this.rbCartao.Text = "Cartão";
            this.rbCartao.UseVisualStyleBackColor = true;
            // 
            // buttonReceber
            // 
            this.buttonReceber.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceber.Location = new System.Drawing.Point(618, 380);
            this.buttonReceber.Name = "buttonReceber";
            this.buttonReceber.Size = new System.Drawing.Size(108, 102);
            this.buttonReceber.TabIndex = 19;
            this.buttonReceber.Text = "Receber";
            this.buttonReceber.UseVisualStyleBackColor = false;
            // 
            // labelTotalVenda
            // 
            this.labelTotalVenda.AutoSize = true;
            this.labelTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVenda.Location = new System.Drawing.Point(384, 125);
            this.labelTotalVenda.Name = "labelTotalVenda";
            this.labelTotalVenda.Size = new System.Drawing.Size(129, 24);
            this.labelTotalVenda.TabIndex = 21;
            this.labelTotalVenda.Text = "Total Venda:";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(45, 320);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(143, 47);
            this.buttonExcluir.TabIndex = 22;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonAdicionarProduto
            // 
            this.buttonAdicionarProduto.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarProduto.Location = new System.Drawing.Point(218, 320);
            this.buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            this.buttonAdicionarProduto.Size = new System.Drawing.Size(143, 47);
            this.buttonAdicionarProduto.TabIndex = 23;
            this.buttonAdicionarProduto.Text = "Adicionar";
            this.buttonAdicionarProduto.UseVisualStyleBackColor = false;
            // 
            // buttonCancelarVenda
            // 
            this.buttonCancelarVenda.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonCancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarVenda.Location = new System.Drawing.Point(45, 388);
            this.buttonCancelarVenda.Name = "buttonCancelarVenda";
            this.buttonCancelarVenda.Size = new System.Drawing.Size(173, 51);
            this.buttonCancelarVenda.TabIndex = 24;
            this.buttonCancelarVenda.Text = "Cancelar Venda";
            this.buttonCancelarVenda.UseVisualStyleBackColor = false;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(45, 445);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(173, 51);
            this.buttonLimpar.TabIndex = 25;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            // 
            // richTextBoxTotalVenda
            // 
            this.richTextBoxTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTotalVenda.Location = new System.Drawing.Point(519, 108);
            this.richTextBoxTotalVenda.Name = "richTextBoxTotalVenda";
            this.richTextBoxTotalVenda.Size = new System.Drawing.Size(207, 41);
            this.richTextBoxTotalVenda.TabIndex = 3;
            this.richTextBoxTotalVenda.Text = "";
            // 
            // richTextBoxDesconto
            // 
            this.richTextBoxDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDesconto.Location = new System.Drawing.Point(519, 155);
            this.richTextBoxDesconto.Name = "richTextBoxDesconto";
            this.richTextBoxDesconto.Size = new System.Drawing.Size(207, 41);
            this.richTextBoxDesconto.TabIndex = 4;
            this.richTextBoxDesconto.Text = "";
            // 
            // richTextBoxTotalLiq
            // 
            this.richTextBoxTotalLiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTotalLiq.Location = new System.Drawing.Point(519, 202);
            this.richTextBoxTotalLiq.Name = "richTextBoxTotalLiq";
            this.richTextBoxTotalLiq.Size = new System.Drawing.Size(207, 41);
            this.richTextBoxTotalLiq.TabIndex = 5;
            this.richTextBoxTotalLiq.Text = "";
            // 
            // buttonPesquisarVenda
            // 
            this.buttonPesquisarVenda.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonPesquisarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarVenda.Location = new System.Drawing.Point(388, 277);
            this.buttonPesquisarVenda.Name = "buttonPesquisarVenda";
            this.buttonPesquisarVenda.Size = new System.Drawing.Size(189, 53);
            this.buttonPesquisarVenda.TabIndex = 29;
            this.buttonPesquisarVenda.Text = "Pesquisar Venda";
            this.buttonPesquisarVenda.UseVisualStyleBackColor = false;
            this.buttonPesquisarVenda.Click += new System.EventHandler(this.buttonPesquisarVenda_Click);
            // 
            // buttonDesconto
            // 
            this.buttonDesconto.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesconto.Location = new System.Drawing.Point(583, 277);
            this.buttonDesconto.Name = "buttonDesconto";
            this.buttonDesconto.Size = new System.Drawing.Size(142, 53);
            this.buttonDesconto.TabIndex = 30;
            this.buttonDesconto.Text = "Desconto";
            this.buttonDesconto.UseVisualStyleBackColor = false;
            this.buttonDesconto.Click += new System.EventHandler(this.buttonDesconto_Click);
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 508);
            this.Controls.Add(this.buttonDesconto);
            this.Controls.Add(this.buttonPesquisarVenda);
            this.Controls.Add(this.richTextBoxTotalLiq);
            this.Controls.Add(this.richTextBoxDesconto);
            this.Controls.Add(this.richTextBoxTotalVenda);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCancelarVenda);
            this.Controls.Add(this.buttonAdicionarProduto);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.labelTotalVenda);
            this.Controls.Add(this.buttonReceber);
            this.Controls.Add(this.rbCartao);
            this.Controls.Add(this.rbDinheiro);
            this.Controls.Add(this.labelLiquido);
            this.Controls.Add(this.labelDesconto);
            this.Controls.Add(this.labelTroco);
            this.Controls.Add(this.labelRecebido);
            this.Controls.Add(this.richTextBoxTroco);
            this.Controls.Add(this.richTextBoxValorRecebido);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.richTextBoxCpf);
            this.Controls.Add(this.labelCodVenda);
            this.Controls.Add(this.richTextBoxCodVenda);
            this.Controls.Add(this.listViewVenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewVenda;
        private System.Windows.Forms.RichTextBox richTextBoxCodVenda;
        private System.Windows.Forms.Label labelCodVenda;
        private System.Windows.Forms.RichTextBox richTextBoxCpf;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.RichTextBox richTextBoxValorRecebido;
        private System.Windows.Forms.RichTextBox richTextBoxTroco;
        private System.Windows.Forms.Label labelRecebido;
        private System.Windows.Forms.Label labelTroco;
        private System.Windows.Forms.Label labelDesconto;
        private System.Windows.Forms.Label labelLiquido;
        private System.Windows.Forms.RadioButton rbDinheiro;
        private System.Windows.Forms.RadioButton rbCartao;
        private System.Windows.Forms.Button buttonReceber;
        private System.Windows.Forms.Label labelTotalVenda;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAdicionarProduto;
        private System.Windows.Forms.Button buttonCancelarVenda;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.RichTextBox richTextBoxTotalVenda;
        private System.Windows.Forms.RichTextBox richTextBoxDesconto;
        private System.Windows.Forms.RichTextBox richTextBoxTotalLiq;
        private System.Windows.Forms.Button buttonPesquisarVenda;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonDesconto;
    }
}