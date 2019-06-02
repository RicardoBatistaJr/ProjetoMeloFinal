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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBoxCodVenda = new System.Windows.Forms.RichTextBox();
            this.labelCodVenda = new System.Windows.Forms.Label();
            this.richTextBoxCpf = new System.Windows.Forms.RichTextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.buttonReceber = new System.Windows.Forms.Button();
            this.labelTotalVenda = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAdicionarProduto = new System.Windows.Forms.Button();
            this.buttonCancelarVenda = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.richTextBoxTotalVenda = new System.Windows.Forms.RichTextBox();
            this.buttonPesquisarVenda = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewVenda
            // 
            this.listViewVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewVenda.FullRowSelect = true;
            this.listViewVenda.GridLines = true;
            this.listViewVenda.Location = new System.Drawing.Point(23, 24);
            this.listViewVenda.MultiSelect = false;
            this.listViewVenda.Name = "listViewVenda";
            this.listViewVenda.Size = new System.Drawing.Size(473, 284);
            this.listViewVenda.TabIndex = 8;
            this.listViewVenda.UseCompatibleStateImageBehavior = false;
            this.listViewVenda.View = System.Windows.Forms.View.Details;
            this.listViewVenda.SelectedIndexChanged += new System.EventHandler(this.listViewVenda_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quant.";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Produto";
            this.columnHeader2.Width = 196;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor Unid.";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vendedor";
            this.columnHeader4.Width = 127;
            // 
            // richTextBoxCodVenda
            // 
            this.richTextBoxCodVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCodVenda.Location = new System.Drawing.Point(648, 49);
            this.richTextBoxCodVenda.Name = "richTextBoxCodVenda";
            this.richTextBoxCodVenda.Size = new System.Drawing.Size(207, 41);
            this.richTextBoxCodVenda.TabIndex = 2;
            this.richTextBoxCodVenda.Text = "";
            // 
            // labelCodVenda
            // 
            this.labelCodVenda.AutoSize = true;
            this.labelCodVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodVenda.Location = new System.Drawing.Point(515, 66);
            this.labelCodVenda.Name = "labelCodVenda";
            this.labelCodVenda.Size = new System.Drawing.Size(127, 24);
            this.labelCodVenda.TabIndex = 2;
            this.labelCodVenda.Text = "Cod. Venda:";
            // 
            // richTextBoxCpf
            // 
            this.richTextBoxCpf.Enabled = false;
            this.richTextBoxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCpf.Location = new System.Drawing.Point(567, 220);
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
            this.labelCpf.Location = new System.Drawing.Point(510, 239);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(56, 24);
            this.labelCpf.TabIndex = 6;
            this.labelCpf.Text = "CPF:";
            // 
            // buttonReceber
            // 
            this.buttonReceber.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonReceber.Enabled = false;
            this.buttonReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceber.Location = new System.Drawing.Point(591, 343);
            this.buttonReceber.Name = "buttonReceber";
            this.buttonReceber.Size = new System.Drawing.Size(176, 59);
            this.buttonReceber.TabIndex = 19;
            this.buttonReceber.Text = "Receber";
            this.buttonReceber.UseVisualStyleBackColor = false;
            this.buttonReceber.Click += new System.EventHandler(this.buttonReceber_Click);
            // 
            // labelTotalVenda
            // 
            this.labelTotalVenda.AutoSize = true;
            this.labelTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVenda.Location = new System.Drawing.Point(510, 286);
            this.labelTotalVenda.Name = "labelTotalVenda";
            this.labelTotalVenda.Size = new System.Drawing.Size(129, 24);
            this.labelTotalVenda.TabIndex = 21;
            this.labelTotalVenda.Text = "Total Venda:";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonExcluir.Enabled = false;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(75, 320);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(143, 47);
            this.buttonExcluir.TabIndex = 22;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAdicionarProduto
            // 
            this.buttonAdicionarProduto.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarProduto.Location = new System.Drawing.Point(281, 320);
            this.buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            this.buttonAdicionarProduto.Size = new System.Drawing.Size(143, 47);
            this.buttonAdicionarProduto.TabIndex = 23;
            this.buttonAdicionarProduto.Text = "Adicionar";
            this.buttonAdicionarProduto.UseVisualStyleBackColor = false;
            this.buttonAdicionarProduto.Click += new System.EventHandler(this.buttonAdicionarProduto_Click);
            // 
            // buttonCancelarVenda
            // 
            this.buttonCancelarVenda.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonCancelarVenda.Enabled = false;
            this.buttonCancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarVenda.Location = new System.Drawing.Point(57, 411);
            this.buttonCancelarVenda.Name = "buttonCancelarVenda";
            this.buttonCancelarVenda.Size = new System.Drawing.Size(173, 51);
            this.buttonCancelarVenda.TabIndex = 24;
            this.buttonCancelarVenda.Text = "Cancelar Venda";
            this.buttonCancelarVenda.UseVisualStyleBackColor = false;
            this.buttonCancelarVenda.Click += new System.EventHandler(this.buttonCancelarVenda_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(266, 411);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(173, 51);
            this.buttonLimpar.TabIndex = 25;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // richTextBoxTotalVenda
            // 
            this.richTextBoxTotalVenda.Enabled = false;
            this.richTextBoxTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTotalVenda.Location = new System.Drawing.Point(639, 269);
            this.richTextBoxTotalVenda.Name = "richTextBoxTotalVenda";
            this.richTextBoxTotalVenda.Size = new System.Drawing.Size(207, 41);
            this.richTextBoxTotalVenda.TabIndex = 3;
            this.richTextBoxTotalVenda.Text = "";
            // 
            // buttonPesquisarVenda
            // 
            this.buttonPesquisarVenda.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonPesquisarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarVenda.Location = new System.Drawing.Point(606, 126);
            this.buttonPesquisarVenda.Name = "buttonPesquisarVenda";
            this.buttonPesquisarVenda.Size = new System.Drawing.Size(189, 53);
            this.buttonPesquisarVenda.TabIndex = 29;
            this.buttonPesquisarVenda.Text = "Pesquisar Venda";
            this.buttonPesquisarVenda.UseVisualStyleBackColor = false;
            this.buttonPesquisarVenda.Click += new System.EventHandler(this.buttonPesquisarVenda_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(591, 424);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(176, 52);
            this.buttonSair.TabIndex = 30;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pesquisar venda pelo código";
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonPesquisarVenda);
            this.Controls.Add(this.richTextBoxTotalVenda);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCancelarVenda);
            this.Controls.Add(this.buttonAdicionarProduto);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.labelTotalVenda);
            this.Controls.Add(this.buttonReceber);
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
        private System.Windows.Forms.Button buttonReceber;
        private System.Windows.Forms.Label labelTotalVenda;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAdicionarProduto;
        private System.Windows.Forms.Button buttonCancelarVenda;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.RichTextBox richTextBoxTotalVenda;
        private System.Windows.Forms.Button buttonPesquisarVenda;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label label1;
    }
}