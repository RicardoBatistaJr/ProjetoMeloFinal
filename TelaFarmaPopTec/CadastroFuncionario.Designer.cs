namespace TelaFarmaPopTec
{
    partial class CadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            this.buttonAlterarF = new System.Windows.Forms.Button();
            this.btnListarFuncionarios = new System.Windows.Forms.Button();
            this.listViewFuncionarios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNomeFunc = new System.Windows.Forms.TextBox();
            this.textBoxCpfFunc = new System.Windows.Forms.TextBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonPesquisarF = new System.Windows.Forms.Button();
            this.buttonlimparF = new System.Windows.Forms.Button();
            this.buttonExcluirF = new System.Windows.Forms.Button();
            this.buttonSalvarF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.comboBoxFuncao = new System.Windows.Forms.ComboBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAlterarF
            // 
            this.buttonAlterarF.Location = new System.Drawing.Point(425, 40);
            this.buttonAlterarF.Name = "buttonAlterarF";
            this.buttonAlterarF.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarF.TabIndex = 30;
            this.buttonAlterarF.Text = "Alterar";
            this.buttonAlterarF.UseVisualStyleBackColor = true;
            this.buttonAlterarF.Click += new System.EventHandler(this.buttonAlterarF_Click);
            // 
            // btnListarFuncionarios
            // 
            this.btnListarFuncionarios.Location = new System.Drawing.Point(54, 287);
            this.btnListarFuncionarios.Name = "btnListarFuncionarios";
            this.btnListarFuncionarios.Size = new System.Drawing.Size(152, 23);
            this.btnListarFuncionarios.TabIndex = 29;
            this.btnListarFuncionarios.Text = "Listar todos os Funcionarios";
            this.btnListarFuncionarios.UseVisualStyleBackColor = true;
            this.btnListarFuncionarios.Click += new System.EventHandler(this.btnListarFuncionarios_Click);
            // 
            // listViewFuncionarios
            // 
            this.listViewFuncionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewFuncionarios.FullRowSelect = true;
            this.listViewFuncionarios.Location = new System.Drawing.Point(51, 320);
            this.listViewFuncionarios.Name = "listViewFuncionarios";
            this.listViewFuncionarios.Size = new System.Drawing.Size(818, 97);
            this.listViewFuncionarios.TabIndex = 28;
            this.listViewFuncionarios.UseCompatibleStateImageBehavior = false;
            this.listViewFuncionarios.View = System.Windows.Forms.View.Details;
            this.listViewFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listViewFuncionarios_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPF";
            this.columnHeader2.Width = 167;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nome";
            this.columnHeader3.Width = 266;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Função";
            this.columnHeader4.Width = 183;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Senha";
            this.columnHeader5.Width = 99;
            // 
            // textBoxNomeFunc
            // 
            this.textBoxNomeFunc.Location = new System.Drawing.Point(117, 165);
            this.textBoxNomeFunc.Name = "textBoxNomeFunc";
            this.textBoxNomeFunc.Size = new System.Drawing.Size(229, 20);
            this.textBoxNomeFunc.TabIndex = 2;
            // 
            // textBoxCpfFunc
            // 
            this.textBoxCpfFunc.Location = new System.Drawing.Point(117, 130);
            this.textBoxCpfFunc.MaxLength = 11;
            this.textBoxCpfFunc.Name = "textBoxCpfFunc";
            this.textBoxCpfFunc.Size = new System.Drawing.Size(180, 20);
            this.textBoxCpfFunc.TabIndex = 1;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Enabled = false;
            this.textBoxCod.Location = new System.Drawing.Point(117, 97);
            this.textBoxCod.MaxLength = 11;
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(75, 20);
            this.textBoxCod.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Função.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome:";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(54, 130);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(30, 13);
            this.labelCpf.TabIndex = 21;
            this.labelCpf.Text = "CPF:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(51, 100);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(32, 13);
            this.labelCodigo.TabIndex = 20;
            this.labelCodigo.Text = "Cod.:";
            // 
            // buttonPesquisarF
            // 
            this.buttonPesquisarF.Location = new System.Drawing.Point(330, 38);
            this.buttonPesquisarF.Name = "buttonPesquisarF";
            this.buttonPesquisarF.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarF.TabIndex = 19;
            this.buttonPesquisarF.Text = "Pesquisar";
            this.buttonPesquisarF.UseVisualStyleBackColor = true;
            this.buttonPesquisarF.Click += new System.EventHandler(this.buttonPesquisarF_Click);
            // 
            // buttonlimparF
            // 
            this.buttonlimparF.Location = new System.Drawing.Point(236, 38);
            this.buttonlimparF.Name = "buttonlimparF";
            this.buttonlimparF.Size = new System.Drawing.Size(75, 23);
            this.buttonlimparF.TabIndex = 18;
            this.buttonlimparF.Text = "Limpar";
            this.buttonlimparF.UseVisualStyleBackColor = true;
            this.buttonlimparF.Click += new System.EventHandler(this.buttonlimparF_Click);
            // 
            // buttonExcluirF
            // 
            this.buttonExcluirF.Location = new System.Drawing.Point(142, 39);
            this.buttonExcluirF.Name = "buttonExcluirF";
            this.buttonExcluirF.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirF.TabIndex = 17;
            this.buttonExcluirF.Text = "Excluir";
            this.buttonExcluirF.UseVisualStyleBackColor = true;
            this.buttonExcluirF.Click += new System.EventHandler(this.buttonExcluirF_Click);
            // 
            // buttonSalvarF
            // 
            this.buttonSalvarF.Location = new System.Drawing.Point(51, 40);
            this.buttonSalvarF.Name = "buttonSalvarF";
            this.buttonSalvarF.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarF.TabIndex = 16;
            this.buttonSalvarF.Text = "Salvar";
            this.buttonSalvarF.UseVisualStyleBackColor = true;
            this.buttonSalvarF.Click += new System.EventHandler(this.buttonSalvarF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(117, 228);
            this.textBoxSenha.MaxLength = 6;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(115, 20);
            this.textBoxSenha.TabIndex = 4;
            // 
            // comboBoxFuncao
            // 
            this.comboBoxFuncao.FormattingEnabled = true;
            this.comboBoxFuncao.Items.AddRange(new object[] {
            "Gerente",
            "Farmacêutico",
            "Atendente",
            "Caixa"});
            this.comboBoxFuncao.Location = new System.Drawing.Point(117, 197);
            this.comboBoxFuncao.Name = "comboBoxFuncao";
            this.comboBoxFuncao.Size = new System.Drawing.Size(229, 21);
            this.comboBoxFuncao.TabIndex = 3;
            this.comboBoxFuncao.Text = "Selecione a Função";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(507, 40);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 32;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.comboBoxFuncao);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAlterarF);
            this.Controls.Add(this.btnListarFuncionarios);
            this.Controls.Add(this.listViewFuncionarios);
            this.Controls.Add(this.textBoxNomeFunc);
            this.Controls.Add(this.textBoxCpfFunc);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.buttonPesquisarF);
            this.Controls.Add(this.buttonlimparF);
            this.Controls.Add(this.buttonExcluirF);
            this.Controls.Add(this.buttonSalvarF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlterarF;
        private System.Windows.Forms.Button btnListarFuncionarios;
        private System.Windows.Forms.ListView listViewFuncionarios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBoxNomeFunc;
        private System.Windows.Forms.TextBox textBoxCpfFunc;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button buttonPesquisarF;
        private System.Windows.Forms.Button buttonlimparF;
        private System.Windows.Forms.Button buttonExcluirF;
        private System.Windows.Forms.Button buttonSalvarF;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.ComboBox comboBoxFuncao;
        private System.Windows.Forms.Button buttonVoltar;
    }
}