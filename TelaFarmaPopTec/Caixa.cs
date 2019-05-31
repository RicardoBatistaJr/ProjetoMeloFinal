using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaFarmaPopTec.localhost;

namespace TelaFarmaPopTec
{
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
            
        }
        Service1 sv = new Service1();
        Venda ven = new Venda();
        List<Venda> vendas = new List<Venda>();
        private void buttonPesquisarVenda_Click(object sender, EventArgs e)
        {
            if (richTextBoxCpf.Text != null || richTextBoxCodVenda.Text != null)
            {
                ven.Cliente.CpfCliente = richTextBoxCpf.Text;
                ven.NumVenda = Int32.Parse(richTextBoxCodVenda.Text);

                this.vendas.Clear();
                //this.ven = sv.li().ToList();

            }
        }
    }
}
