namespace TelaFarmaPopTec
{
    partial class CadastrarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFornecedor));
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.btnListarFornecedores = new System.Windows.Forms.Button();
            this.listViewFornecedor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxFornecedor = new System.Windows.Forms.TextBox();
            this.textBoxCnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonlimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(591, 20);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 35;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(328, 20);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 32;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // btnListarFornecedores
            // 
            this.btnListarFornecedores.Location = new System.Drawing.Point(35, 174);
            this.btnListarFornecedores.Name = "btnListarFornecedores";
            this.btnListarFornecedores.Size = new System.Drawing.Size(152, 23);
            this.btnListarFornecedores.TabIndex = 31;
            this.btnListarFornecedores.Text = "Listar todos os Fornecedores";
            this.btnListarFornecedores.UseVisualStyleBackColor = true;
            this.btnListarFornecedores.Click += new System.EventHandler(this.btnListarFornecedores_Click);
            // 
            // listViewFornecedor
            // 
            this.listViewFornecedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewFornecedor.FullRowSelect = true;
            this.listViewFornecedor.Location = new System.Drawing.Point(37, 203);
            this.listViewFornecedor.Name = "listViewFornecedor";
            this.listViewFornecedor.Size = new System.Drawing.Size(366, 97);
            this.listViewFornecedor.TabIndex = 30;
            this.listViewFornecedor.UseCompatibleStateImageBehavior = false;
            this.listViewFornecedor.View = System.Windows.Forms.View.Details;
            this.listViewFornecedor.SelectedIndexChanged += new System.EventHandler(this.listViewFornecedor_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CNPJ";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fornecedor";
            this.columnHeader2.Width = 223;
            // 
            // textBoxFornecedor
            // 
            this.textBoxFornecedor.Location = new System.Drawing.Point(97, 124);
            this.textBoxFornecedor.Name = "textBoxFornecedor";
            this.textBoxFornecedor.Size = new System.Drawing.Size(229, 20);
            this.textBoxFornecedor.TabIndex = 27;
            // 
            // textBoxCnpj
            // 
            this.textBoxCnpj.Location = new System.Drawing.Point(97, 91);
            this.textBoxCnpj.MaxLength = 14;
            this.textBoxCnpj.Name = "textBoxCnpj";
            this.textBoxCnpj.Size = new System.Drawing.Size(229, 20);
            this.textBoxCnpj.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "CNPJ";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(227, 20);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 21;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonlimpar
            // 
            this.buttonlimpar.Location = new System.Drawing.Point(132, 20);
            this.buttonlimpar.Name = "buttonlimpar";
            this.buttonlimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonlimpar.TabIndex = 20;
            this.buttonlimpar.Text = "Limpar";
            this.buttonlimpar.UseVisualStyleBackColor = true;
            this.buttonlimpar.Click += new System.EventHandler(this.buttonlimpar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(32, 20);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 18;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // CadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 322);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.btnListarFornecedores);
            this.Controls.Add(this.listViewFornecedor);
            this.Controls.Add(this.textBoxFornecedor);
            this.Controls.Add(this.textBoxCnpj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonlimpar);
            this.Controls.Add(this.buttonSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button btnListarFornecedores;
        private System.Windows.Forms.ListView listViewFornecedor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxFornecedor;
        private System.Windows.Forms.TextBox textBoxCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonlimpar;
        private System.Windows.Forms.Button buttonSalvar;
    }
}