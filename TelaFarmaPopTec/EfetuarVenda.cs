using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaFarmaPopTec.localhost;
using System.Text.RegularExpressions;

namespace TelaFarmaPopTec
{
    public partial class EfetuarVenda : Form
    {
        Service1 sv = new Service1();
        Venda venda = new Venda();
        Produto produto = new Produto();
        Cliente cliente = new Cliente();
        List<Venda> vendas = new List<Venda>();
        
        List<Cliente> clientes = new List<Cliente>();

        public EfetuarVenda()
        {
            InitializeComponent();
        }

        private void BtListarProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                List<Produto> produtos = new List<Produto>();
                produtos = sv.ListarProdutos().ToList();
                listViewProdutos.Items.Clear();

                foreach (var item in produtos)
                {
                    ListViewItem lvi = listViewProdutos.Items.Add(item.CodProduto.ToString());
                    lvi.SubItems.Add(item.SaldoProduto.ToString());
                    lvi.SubItems.Add(item.NomeProduto);
                    lvi.SubItems.Add(item.PrecoProduto.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListViewListarProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Produto> produtos = new List<Produto>();

                if (listViewProdutos.FocusedItem != null)
                {
                    int index = listViewProdutos.FocusedItem.Index;
                    Produto p = produtos.ElementAt(index);
                    ListViewItem lvi = listViewProdutos.Items.Add(p.CodProduto.ToString());
                    lvi.SubItems.Add(p.NomeProduto);
                    lvi.SubItems.Add(p.PrecoProduto.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientes.Clear();
                this.clientes = sv.ListarClientes().ToList();

                listViewProdutos.Items.Clear();

                foreach (var item in this.clientes)
                {
                    ListViewItem lvi = listViewProdutos.Items.Add(item.CpfCliente);
                    lvi.SubItems.Add(item.NomeCliente);
                    lvi.SubItems.Add(item.EmailCliente);
                    lvi.SubItems.Add(item.TelCliente);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EfetuarVenda_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpaCliente_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxCpf.Text = "";
        }

        private void buttonLimpaProduto_Click(object sender, EventArgs e)
        {
            textBoxProduto.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listViewVenda.Items.Clear();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            int numVenda;
            numVenda = Int32.Parse(labelCodVenda.Text);
            sv.DeletarVenda(numVenda);
            textBoxNome.Text = "";
            textBoxCpf.Text = "";
            textBoxProduto.Text = "";
            listViewVenda.Items.Clear();
            MessageBox.Show("Venda cancelada!");
        }

        private void buttonCaixa_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.ShowDialog();
        }
    }
}
