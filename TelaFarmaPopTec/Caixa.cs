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
            richTextBoxCpf.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxCodVenda.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxTotalVenda.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxDesconto.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxTotalLiq.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxValorRecebido.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxTroco.SelectionAlignment = HorizontalAlignment.Right;
        }
       
        Service1 sv = new Service1();

        //double liquido = venda.Preco - (desconto/100);
        private void buttonPesquisarVenda_Click(object sender, EventArgs e)
        {
            VendaProduto venda = new VendaProduto();
            List<Venda> vendas = new List<Venda>();
            double desconto = 0;
            if (richTextBoxCpf.Text != null || richTextBoxCodVenda.Text != null)
            {
                venda.Venda.Cliente.CpfCliente = richTextBoxCpf.Text;
                venda.Venda.NumVenda = Int32.Parse(richTextBoxCodVenda.Text);
                

                vendas.Clear();
                //vendas = sv.li

                listViewVenda.Items.Clear();

                foreach (var item in vendas)
                {
                    richTextBoxCpf.Text = venda.Venda.Cliente.CpfCliente;
                    richTextBoxCodVenda.Text = venda.Venda.NumVenda.ToString();
                    richTextBoxTotalVenda.Text = venda.Preco.ToString();
                    richTextBoxDesconto.Text = desconto.ToString();
                    richTextBoxTotalLiq.Text = String.Format("0:0,0.0000000", venda.Preco); 
                }
                
            }
        }

        private void buttonDesconto_Click(object sender, EventArgs e)
        {
            double desconto = 0;

        }
    }
}
