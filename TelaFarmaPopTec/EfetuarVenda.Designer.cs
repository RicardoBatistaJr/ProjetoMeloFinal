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
            this.listViewListarProdutos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btListarProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewListarProdutos
            // 
            this.listViewListarProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewListarProdutos.FullRowSelect = true;
            this.listViewListarProdutos.Location = new System.Drawing.Point(22, 209);
            this.listViewListarProdutos.Name = "listViewListarProdutos";
            this.listViewListarProdutos.Size = new System.Drawing.Size(471, 207);
            this.listViewListarProdutos.TabIndex = 0;
            this.listViewListarProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewListarProdutos.SelectedIndexChanged += new System.EventHandler(this.ListViewListarProdutos_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod. Produto";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Saldo Produto";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Fabric.";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nome Produto";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Preço Produto";
            // 
            // btListarProdutos
            // 
            this.btListarProdutos.Location = new System.Drawing.Point(22, 180);
            this.btListarProdutos.Name = "btListarProdutos";
            this.btListarProdutos.Size = new System.Drawing.Size(147, 23);
            this.btListarProdutos.TabIndex = 1;
            this.btListarProdutos.Text = "Listar Produtos";
            this.btListarProdutos.UseVisualStyleBackColor = true;
            this.btListarProdutos.Click += new System.EventHandler(this.BtListarProdutos_Click);
            // 
            // EfetuarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btListarProdutos);
            this.Controls.Add(this.listViewListarProdutos);
            this.Name = "EfetuarVenda";
            this.Text = "EfetuarVenda";
            this.Load += new System.EventHandler(this.EfetuarVenda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewListarProdutos;
        private System.Windows.Forms.Button btListarProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}