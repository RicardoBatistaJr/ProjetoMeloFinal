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

namespace TelaFarmaPopTec
{
    public partial class Cadastrar_Compra : Form
    {
        Service1 sv = new Service1();
        Compra compra = new Compra();
        Compra_Produto Compra_Produto = new Compra_Produto();
        List<Compra> compras = new List<Compra>();
        public Cadastrar_Compra()
        {
            InitializeComponent();
        }
        //Função para cadastrar Compra
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                compra.NumCompra = Convert.ToInt16(textBoxNum.Text);
                compra.DataCompra = Convert.ToDateTime(textBoxData.Text);
                compra.Fornecedor.Cnpj = textBoxFornecedor.Text;
                compra.Funcionario.CpfFuncionario = textBoxFuncionario.Text;
                sv.CadastrarCompra(compra);
                MessageBox.Show("Comprar cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
        //Função para limpar campos de pesquisa e respostas
        private void buttonlimpar_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxNum.Text = "";
                textBoxData.Text = "";
                textBoxFornecedor.Text = "";
                textBoxFuncionario.Text = "";
                listViewCompra.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Função para pesquisar compra
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxNum.Text != null)
                {
                    compra.NumCompra = Convert.ToInt16(textBoxNum.Text);                    

                    this.compras.Clear();
                    this.compras = sv.ConsultarCompra(compra).ToList();

                    listViewCompra.Items.Clear();

                    foreach (var item in compras)
                    {
                        ListViewItem lvi = listViewCompra.Items.Add(Convert.ToString(item.NumCompra));
                        lvi.SubItems.Add(Convert.ToString(item.DataCompra));
                        lvi.SubItems.Add(item.Fornecedor.Cnpj);
                        lvi.SubItems.Add(item.Funcionario.CpfFuncionario);                        
                    }
                    textBoxNum.Text = "";
                    textBoxData.Text = "";
                    textBoxFornecedor.Text = "";
                    textBoxFuncionario.Text = "";

                }
                else
                {
                    MessageBox.Show("Informar um número de compra!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
