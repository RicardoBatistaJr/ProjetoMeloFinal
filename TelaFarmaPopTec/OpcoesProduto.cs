using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaFarmaPopTec
{
    public partial class OpcoesProduto : Form
    {
        public OpcoesProduto(string funcao)
        {
            InitializeComponent();
            verificarFuncao(funcao);
        }

        public OpcoesProduto()
        {
        }

        private void verificarFuncao(string funcao)
        {
            if (funcao.Equals("Gerente"))
            {
                buttonManter.Enabled = true;
                buttonCompra.Enabled = true;               
            }
            else
            {
                buttonManter.Enabled = true;
                buttonCompra.Enabled = false;
                buttonManter.BackColor = Color.Gainsboro;
            }
        }

        private void buttonManter_Click(object sender, EventArgs e)
        {
            ManterProdutos manterProdutos = new ManterProdutos();
            manterProdutos.ShowDialog();
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {
            Cadastrar_Compra cadastrar_Compra = new Cadastrar_Compra();
            cadastrar_Compra.ShowDialog();
        }
    }
}
