﻿namespace TelaFarmaPopTec
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonlimpar = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.listViewCliente = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonListarCompras = new System.Windows.Forms.Button();
            this.listViewCompras = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(42, 34);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(133, 33);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 1;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonlimpar
            // 
            this.buttonlimpar.Location = new System.Drawing.Point(227, 32);
            this.buttonlimpar.Name = "buttonlimpar";
            this.buttonlimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonlimpar.TabIndex = 2;
            this.buttonlimpar.Text = "Limpar";
            this.buttonlimpar.UseVisualStyleBackColor = true;
            this.buttonlimpar.Click += new System.EventHandler(this.buttonlimpar_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(321, 32);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 3;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tel.:";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(108, 91);
            this.textBoxCpf.MaxLength = 11;
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(229, 20);
            this.textBoxCpf.TabIndex = 8;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(108, 124);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(229, 20);
            this.textBoxNome.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(108, 159);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(229, 20);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(108, 191);
            this.textBoxTel.MaxLength = 14;
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(229, 20);
            this.textBoxTel.TabIndex = 11;
            // 
            // listViewCliente
            // 
            this.listViewCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCliente.FullRowSelect = true;
            this.listViewCliente.Location = new System.Drawing.Point(42, 269);
            this.listViewCliente.Name = "listViewCliente";
            this.listViewCliente.Size = new System.Drawing.Size(698, 97);
            this.listViewCliente.TabIndex = 12;
            this.listViewCliente.UseCompatibleStateImageBehavior = false;
            this.listViewCliente.View = System.Windows.Forms.View.Details;
            this.listViewCliente.SelectedIndexChanged += new System.EventHandler(this.listViewCliente_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CPF";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-mail";
            this.columnHeader3.Width = 225;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefone";
            this.columnHeader4.Width = 141;
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Location = new System.Drawing.Point(45, 236);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(152, 23);
            this.btnListarClientes.TabIndex = 13;
            this.btnListarClientes.Text = "Listar todos os Clientes";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            this.btnListarClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(416, 34);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 14;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonListarCompras
            // 
            this.buttonListarCompras.Location = new System.Drawing.Point(42, 383);
            this.buttonListarCompras.Name = "buttonListarCompras";
            this.buttonListarCompras.Size = new System.Drawing.Size(155, 23);
            this.buttonListarCompras.TabIndex = 15;
            this.buttonListarCompras.Text = "Listar Compras do Cliente";
            this.buttonListarCompras.UseVisualStyleBackColor = true;
            // 
            // listViewCompras
            // 
            this.listViewCompras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader6});
            this.listViewCompras.Location = new System.Drawing.Point(42, 413);
            this.listViewCompras.Name = "listViewCompras";
            this.listViewCompras.Size = new System.Drawing.Size(918, 97);
            this.listViewCompras.TabIndex = 16;
            this.listViewCompras.UseCompatibleStateImageBehavior = false;
            this.listViewCompras.View = System.Windows.Forms.View.Details;
            this.listViewCompras.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CPF";
            this.columnHeader5.Width = 166;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nº da Venda";
            this.columnHeader7.Width = 77;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Data da Venda";
            this.columnHeader8.Width = 181;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nome do Produto";
            this.columnHeader9.Width = 299;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Qtd. comp.";
            this.columnHeader10.Width = 73;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Preço";
            this.columnHeader6.Width = 130;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(498, 34);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 17;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 524);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.listViewCompras);
            this.Controls.Add(this.buttonListarCompras);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.btnListarClientes);
            this.Controls.Add(this.listViewCliente);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonlimpar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonlimpar;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.ListView listViewCliente;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonListarCompras;
        private System.Windows.Forms.ListView listViewCompras;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonVoltar;
    }
}