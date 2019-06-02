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
        public Caixa()
        {
            InitializeComponent();

            richTextBoxCpf.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxCodVenda.SelectionAlignment = HorizontalAlignment.Right;
            richTextBoxTotalVenda.SelectionAlignment = HorizontalAlignment.Right;
        }
        Service1 sv = new Service1();
        
        private void buttonPesquisarVenda_Click(object sender, EventArgs e)
        {
            VendaProduto venda = new VendaProduto();
            List<VendaProduto> vendas = new List<VendaProduto>();
            Venda ven = new Venda();

            try
            {
                if (!string.IsNullOrEmpty(richTextBoxCodVenda.Text))
                {
                    int numVenda = Int32.Parse(richTextBoxCodVenda.Text);

                    vendas.Clear();
                    vendas = sv.ListarVenda(numVenda).ToList();
                    if (vendas != null)
                    {
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

                            richTextBoxCpf.Enabled = true;
                            richTextBoxTotalVenda.Enabled = true;
                            buttonCancelarVenda.Enabled = true;
                            buttonReceber.Enabled = true;
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Venda não encontarda");
                    }

                }
                else
                {
                    MessageBox.Show("Digite um código de venda");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buttonExcluir.Enabled = true;
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
            listViewVenda.Items.Clear();
        }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            EfetuarVenda efetuarVenda = new EfetuarVenda();
            efetuarVenda.ShowDialog();
        }

        private void buttonCancelarVenda_Click(object sender, EventArgs e)
        {
            int numVenda ;
            numVenda = Int32.Parse( richTextBoxCodVenda.Text);
            sv.DeletarVenda(numVenda);
            richTextBoxCpf.Text = "";
            richTextBoxCodVenda.Text = "";
            richTextBoxTotalVenda.Text = "";
            listViewVenda.Items.Clear();
            MessageBox.Show("Venda cancelada!");
        }

        private void buttonReceber_Click(object sender, EventArgs e)
        {                     
            List<VendaProduto> vendas = new List<VendaProduto>();

            int numVenda = Int32.Parse(richTextBoxCodVenda.Text);
            
            vendas = sv.ListarVenda(numVenda).ToList();
            
            foreach (var vend in vendas)
            {  
                sv.AlterarSaldoProduto(vend.Produto.CodProduto, vend.Qtd);
            }
            MessageBox.Show("Pagamento recebido");
            richTextBoxCpf.Text = "";
            richTextBoxCodVenda.Text = "";
            richTextBoxTotalVenda.Text = "";
            listViewVenda.Items.Clear();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            List<VendaProduto> vendas = new List<VendaProduto>();
            int numeroVenda = Convert.ToInt32(richTextBoxCodVenda.Text);

            if (listViewVenda.FocusedItem != null)
            {
                vendas = sv.ListarVenda(numeroVenda).ToList();
                int index = listViewVenda.FocusedItem.Index;
                VendaProduto vp = vendas.ElementAt(index);
                sv.DeletarItemVenda(numeroVenda, vp.Produto.CodProduto);
            }
            listViewVenda.Items.Clear();
            buttonPesquisarVenda_Click(sender, e);
        }
    }
}
