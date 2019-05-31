namespace TelaFarmaPopTec
{
    partial class OpcoesProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcoesProduto));
            this.buttonManter = new System.Windows.Forms.Button();
            this.buttonCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManter
            // 
            this.buttonManter.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonManter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManter.Location = new System.Drawing.Point(27, 43);
            this.buttonManter.Name = "buttonManter";
            this.buttonManter.Size = new System.Drawing.Size(146, 92);
            this.buttonManter.TabIndex = 3;
            this.buttonManter.Text = "MANTER PRODUTO";
            this.buttonManter.UseVisualStyleBackColor = false;
            this.buttonManter.Click += new System.EventHandler(this.buttonManter_Click);
            // 
            // buttonCompra
            // 
            this.buttonCompra.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompra.Location = new System.Drawing.Point(280, 43);
            this.buttonCompra.Name = "buttonCompra";
            this.buttonCompra.Size = new System.Drawing.Size(146, 92);
            this.buttonCompra.TabIndex = 3;
            this.buttonCompra.Text = "COMPRA PRODUTO";
            this.buttonCompra.UseVisualStyleBackColor = false;
            this.buttonCompra.Click += new System.EventHandler(this.buttonCompra_Click);
            // 
            // OpcoesProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(459, 178);
            this.Controls.Add(this.buttonCompra);
            this.Controls.Add(this.buttonManter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpcoesProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpcoesProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManter;
        private System.Windows.Forms.Button buttonCompra;
    }
}