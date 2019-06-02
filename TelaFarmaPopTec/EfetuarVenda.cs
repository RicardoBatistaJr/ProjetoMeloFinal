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
        List<Produto> produtos = new List<Produto>();
        List<Cliente> clientes = new List<Cliente>();

        public EfetuarVenda()
        {
            InitializeComponent();
        }

        private void BtListarProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtos.Clear();
                this.produtos = sv.ListarProdutos().ToList();

                //listViewListarProdutos.Items.Clear();


                foreach (var item in this.produtos)
                {
                    ListViewItem lvi = listViewListarProdutos.Items.Add(item.CodProduto.ToString());
                    lvi.SubItems.Add(item.SaldoProduto.ToString());
                    //lvi.SubItems.Add(item.DataFabricacao.ToString());
                    lvi.SubItems.Add(item.NomeProduto);
                    lvi.SubItems.Add(item.PrecoProduto.ToString());

                    //ListViewItem lvi = listViewListarProdutos.Items.Add(item.NomeProduto);
                    //lvi.SubItems.Add(item.SaldoProduto.ToString());
                    // lvi.SubItems.Add(item.DataFabricacao.ToString());
                    // lvi.SubItems.Add(item.NomeProduto);
                    // lvi.SubItems.Add(item.PrecoProduto.ToString());
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListViewListarProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientes.Clear();
                this.clientes = sv.ListarClientes().ToList();

                listViewListarProdutos.Items.Clear();

                foreach (var item in this.clientes)
                {
                    ListViewItem lvi = listViewListarProdutos.Items.Add(item.CpfCliente);
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
    }
}
