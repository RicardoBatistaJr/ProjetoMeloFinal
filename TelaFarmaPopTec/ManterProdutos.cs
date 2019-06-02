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
    public partial class ManterProdutos : Form
    {
        Produto produto = new Produto();
        Service1 sv = new Service1();
        List<Produto> produtos = new List<Produto>();

        public ManterProdutos()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                produto.CodProduto = Convert.ToInt32(textBoxAlterarStatus.Text);
                sv.DeletarProduto(produto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtInserirProduto_Click(object sender, EventArgs e)
        {
            try
            {
                produto.SaldoProduto = Convert.ToInt32(textBoxSaldoProduto.Text);
                produto.DataFabricacao = Convert.ToDateTime(textBoxDataFabricacao.Text);
                produto.NomeProduto = textBoxNomeProduto.Text;
                produto.PrecoProduto = float.Parse(textBoxPrecoProduto.Text);
                produto.StatusProduto = "1";

                sv.CadastrarProduto(produto);
                MessageBox.Show("Produto cadastrado!");
            }
            catch (Exception)
            {

                throw;
            }
            
               
            
        }

        private void ManterProdutos_Load(object sender, EventArgs e)
        {

        }

        private void BtAlterarStatus_Click(object sender, EventArgs e)
        {
            /* try
             {
                 produto.CodProduto = Convert.ToInt32(textBoxAlterarStatus.Text);
                 sv.AtivarProduto(produto);
             }
             catch (Exception)
             {

                 throw;
             }*/
        }

        private void BtDesativarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                produto.CodProduto = Convert.ToInt32(textBoxAlterarStatus.Text);
                sv.DeletarProduto(produto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    
}
