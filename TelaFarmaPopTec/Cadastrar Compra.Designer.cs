namespace TelaFarmaPopTec
{
    partial class Cadastrar_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Compra));
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.listViewCompra = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxFuncionario = new System.Windows.Forms.TextBox();
            this.textBoxFornecedor = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonlimpar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(503, 40);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 35;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(403, 40);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 32;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Location = new System.Drawing.Point(31, 244);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(152, 23);
            this.btnListarClientes.TabIndex = 31;
            this.btnListarClientes.Text = "Listar todos os Clientes";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            // 
            // listViewCompra
            // 
            this.listViewCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCompra.FullRowSelect = true;
            this.listViewCompra.Location = new System.Drawing.Point(28, 277);
            this.listViewCompra.Name = "listViewCompra";
            this.listViewCompra.Size = new System.Drawing.Size(1009, 153);
            this.listViewCompra.TabIndex = 30;
            this.listViewCompra.UseCompatibleStateImageBehavior = false;
            this.listViewCompra.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 311;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Saldo";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preço";
            this.columnHeader4.Width = 141;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data de Fabricação";
            this.columnHeader6.Width = 175;
            // 
            // textBoxFuncionario
            // 
            this.textBoxFuncionario.Location = new System.Drawing.Point(123, 199);
            this.textBoxFuncionario.MaxLength = 14;
            this.textBoxFuncionario.Name = "textBoxFuncionario";
            this.textBoxFuncionario.Size = new System.Drawing.Size(229, 20);
            this.textBoxFuncionario.TabIndex = 29;
            // 
            // textBoxFornecedor
            // 
            this.textBoxFornecedor.Location = new System.Drawing.Point(123, 167);
            this.textBoxFornecedor.Name = "textBoxFornecedor";
            this.textBoxFornecedor.Size = new System.Drawing.Size(229, 20);
            this.textBoxFornecedor.TabIndex = 28;
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(123, 132);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(229, 20);
            this.textBoxData.TabIndex = 27;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(123, 99);
            this.textBoxNum.MaxLength = 11;
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(229, 20);
            this.textBoxNum.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Funcionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fornecedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Data da Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Código da Compra";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(307, 40);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 21;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonlimpar
            // 
            this.buttonlimpar.Location = new System.Drawing.Point(213, 40);
            this.buttonlimpar.Name = "buttonlimpar";
            this.buttonlimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonlimpar.TabIndex = 20;
            this.buttonlimpar.Text = "Limpar";
            this.buttonlimpar.UseVisualStyleBackColor = true;
            this.buttonlimpar.Click += new System.EventHandler(this.buttonlimpar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(119, 41);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 19;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(28, 42);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 18;
            this.buttonSalvar.Text = "Cadastrar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Listar Produtos Vencidos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cadastrar_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.btnListarClientes);
            this.Controls.Add(this.listViewCompra);
            this.Controls.Add(this.textBoxFuncionario);
            this.Controls.Add(this.textBoxFornecedor);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonlimpar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastrar_Compra";
            this.Text = "Cadastrar_Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.ListView listViewCompra;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBoxFuncionario;
        private System.Windows.Forms.TextBox textBoxFornecedor;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonlimpar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
    }
}