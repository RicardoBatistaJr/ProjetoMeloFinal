namespace TelaFarmaPopTec
{
    partial class EfetuarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EfetuarVenda));
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btListarProdutos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCodVenda = new System.Windows.Forms.Label();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewVenda = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonFechar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonLimpaCliente = new System.Windows.Forms.Button();
            this.buttonLimpaProduto = new System.Windows.Forms.Button();
            this.buttonCaixa = new System.Windows.Forms.Button();
            this.buttonQuantidade = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.GridLines = true;
            this.listViewProdutos.Location = new System.Drawing.Point(5, 174);
            this.listViewProdutos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(438, 330);
            this.listViewProdutos.TabIndex = 0;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            this.listViewProdutos.SelectedIndexChanged += new System.EventHandler(this.ListViewListarProdutos_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod.:";
            this.columnHeader1.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Saldo:";
            this.columnHeader2.Width = 54;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nome:";
            this.columnHeader4.Width = 227;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Preço:";
            this.columnHeader5.Width = 98;
            // 
            // btListarProdutos
            // 
            this.btListarProdutos.BackColor = System.Drawing.SystemColors.GrayText;
            this.btListarProdutos.Location = new System.Drawing.Point(5, 137);
            this.btListarProdutos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btListarProdutos.Name = "btListarProdutos";
            this.btListarProdutos.Size = new System.Drawing.Size(245, 32);
            this.btListarProdutos.TabIndex = 1;
            this.btListarProdutos.Text = "Listar Produtos";
            this.btListarProdutos.UseVisualStyleBackColor = false;
            this.btListarProdutos.Click += new System.EventHandler(this.BtListarProdutos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(93, 29);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(323, 26);
            this.textBoxNome.TabIndex = 3;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCpf.Location = new System.Drawing.Point(422, 29);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(192, 26);
            this.textBoxCpf.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonPesquisar.Location = new System.Drawing.Point(620, 21);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(98, 35);
            this.buttonPesquisar.TabIndex = 7;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cod. Venda";
            // 
            // labelCodVenda
            // 
            this.labelCodVenda.AutoSize = true;
            this.labelCodVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodVenda.ForeColor = System.Drawing.Color.Coral;
            this.labelCodVenda.Location = new System.Drawing.Point(448, 136);
            this.labelCodVenda.Name = "labelCodVenda";
            this.labelCodVenda.Size = new System.Drawing.Size(20, 29);
            this.labelCodVenda.TabIndex = 9;
            this.labelCodVenda.Text = " ";
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Location = new System.Drawing.Point(93, 76);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(427, 24);
            this.textBoxProduto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Produto:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(529, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listViewVenda
            // 
            this.listViewVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader3});
            this.listViewVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewVenda.FullRowSelect = true;
            this.listViewVenda.GridLines = true;
            this.listViewVenda.Location = new System.Drawing.Point(453, 174);
            this.listViewVenda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listViewVenda.Name = "listViewVenda";
            this.listViewVenda.Size = new System.Drawing.Size(439, 277);
            this.listViewVenda.TabIndex = 13;
            this.listViewVenda.UseCompatibleStateImageBehavior = false;
            this.listViewVenda.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cod.:";
            this.columnHeader6.Width = 68;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nome:";
            this.columnHeader9.Width = 202;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Preço:";
            this.columnHeader10.Width = 100;
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonFechar.Location = new System.Drawing.Point(258, 137);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(94, 32);
            this.buttonFechar.TabIndex = 14;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Location = new System.Drawing.Point(740, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "Limpa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(659, 137);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 32);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancala";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(579, 137);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 32);
            this.buttonSalvar.TabIndex = 17;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total da Venda:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.Blue;
            this.textBoxTotal.Location = new System.Drawing.Point(700, 473);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(187, 31);
            this.textBoxTotal.TabIndex = 19;
            // 
            // buttonLimpaCliente
            // 
            this.buttonLimpaCliente.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonLimpaCliente.Location = new System.Drawing.Point(734, 20);
            this.buttonLimpaCliente.Name = "buttonLimpaCliente";
            this.buttonLimpaCliente.Size = new System.Drawing.Size(98, 35);
            this.buttonLimpaCliente.TabIndex = 20;
            this.buttonLimpaCliente.Text = "Limpa";
            this.buttonLimpaCliente.UseVisualStyleBackColor = false;
            this.buttonLimpaCliente.Click += new System.EventHandler(this.buttonLimpaCliente_Click);
            // 
            // buttonLimpaProduto
            // 
            this.buttonLimpaProduto.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonLimpaProduto.Location = new System.Drawing.Point(792, 71);
            this.buttonLimpaProduto.Name = "buttonLimpaProduto";
            this.buttonLimpaProduto.Size = new System.Drawing.Size(98, 35);
            this.buttonLimpaProduto.TabIndex = 21;
            this.buttonLimpaProduto.Text = "Limpa";
            this.buttonLimpaProduto.UseVisualStyleBackColor = false;
            this.buttonLimpaProduto.Click += new System.EventHandler(this.buttonLimpaProduto_Click);
            // 
            // buttonCaixa
            // 
            this.buttonCaixa.BackColor = System.Drawing.Color.Green;
            this.buttonCaixa.Location = new System.Drawing.Point(817, 137);
            this.buttonCaixa.Name = "buttonCaixa";
            this.buttonCaixa.Size = new System.Drawing.Size(75, 32);
            this.buttonCaixa.TabIndex = 22;
            this.buttonCaixa.Text = "Caixa";
            this.buttonCaixa.UseVisualStyleBackColor = false;
            this.buttonCaixa.Click += new System.EventHandler(this.buttonCaixa_Click);
            // 
            // buttonQuantidade
            // 
            this.buttonQuantidade.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonQuantidade.Location = new System.Drawing.Point(691, 71);
            this.buttonQuantidade.Name = "buttonQuantidade";
            this.buttonQuantidade.Size = new System.Drawing.Size(90, 35);
            this.buttonQuantidade.TabIndex = 23;
            this.buttonQuantidade.Text = "Incluir";
            this.buttonQuantidade.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(630, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 24);
            this.textBox1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Quant.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nome";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quant.:";
            this.columnHeader3.Width = 100;
            // 
            // EfetuarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 517);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonQuantidade);
            this.Controls.Add(this.buttonCaixa);
            this.Controls.Add(this.buttonLimpaProduto);
            this.Controls.Add(this.buttonLimpaCliente);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.listViewVenda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxProduto);
            this.Controls.Add(this.labelCodVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btListarProdutos);
            this.Controls.Add(this.listViewProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EfetuarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.EfetuarVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.Button btListarProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCodVenda;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewVenda;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonLimpaCliente;
        private System.Windows.Forms.Button buttonLimpaProduto;
        private System.Windows.Forms.Button buttonCaixa;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonQuantidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}