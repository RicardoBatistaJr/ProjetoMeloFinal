using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TelaFarmaPopTec.localhost;

namespace TelaFarmaPopTec
{
    public partial class Caixa : Form
    {
        double recebido = 0.0;
        VendaProduto venda = new VendaProduto();
        public Caixa()
        {
            InitializeComponent();

            richTextBoxCpf.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxCodVenda.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxTotalVenda.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxValorRecebido.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxTroco.SelectionAlignment = HorizontalAlignment.Right;
        }
        Service1 sv = new Service1();

        private void buttonPesquisarVenda_Click(object sender, EventArgs e)
        {
            List<VendaProduto> vendas = new List<VendaProduto>();
            Venda ven = new Venda();
            
            if (richTextBoxCpf.Text != null || richTextBoxCodVenda.Text != null)
            {
                venda.Venda.Cliente.CpfCliente = richTextBoxCpf.Text;
                venda.Venda.NumVenda = Int32.Parse(richTextBoxCodVenda.Text);               

                vendas.Clear();
                vendas = sv.ListarVenda(ven).ToList();

                listViewVenda.Items.Clear();

                foreach (var item in vendas)
                {
                    ListViewItem lv = listViewVenda.Items.Add(item.Qtd.ToString());
                    lv.SubItems.Add(item.Produto.NomeProduto);
                    lv.SubItems.Add(item.Produto.PrecoProduto.ToString());
                    lv.SubItems.Add(item.Venda.Funcionario.NomeFuncionario);

                    richTextBoxCpf.Text = item.Venda.Cliente.CpfCliente;
                    richTextBoxCodVenda.Text = item.Venda.NumVenda.ToString();
                    richTextBoxTotalVenda.Text = item.Preco.ToString();
                    richTextBoxValorRecebido.Text = recebido.ToString();
                }
                
            }
        }

        private void listViewVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<VendaProduto> vendas = new List<VendaProduto>();
            try
            {

                if (listViewVenda.FocusedItem != null)
                {
                    int index = listViewVenda.FocusedItem.Index;
                    VendaProduto vp = vendas.ElementAt(index);
                    richTextBoxCpf.Text = vp.Venda.Cliente.CpfCliente;
                    richTextBoxCodVenda.Text = vp.Venda.NumVenda.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            richTextBoxCpf.Text = "";
            richTextBoxCodVenda.Text = "";
            richTextBoxTotalVenda.Text = "";
            richTextBoxValorRecebido.Text = "";
            richTextBoxTroco.Text = "";
            listViewVenda.Clear();
        }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            EfetuarVenda efetuarVenda = new EfetuarVenda();
            efetuarVenda.ShowDialog();
        }
    }
}
