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
        Compra_Produto compra_produto = new Compra_Produto();
        List<Compra> compras = new List<Compra>();
        List<Compra_Produto> itensCompra = new List<Compra_Produto>();

        public Cadastrar_Compra()
        {
            InitializeComponent();
        }
        //Função para cadastrar Compra
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Compra compra = new Compra();
                Compra_Produto compra_Produto = new Compra_Produto();
                compra.NumCompra = Convert.ToInt32(textBoxNum.Text);
                compra.DataCompra = Convert.ToDateTime(textBoxData.Text);
                compra.Fornecedor.Cnpj = textBoxFornecedor.Text;
                compra.Funcionario.CpfFuncionario = textBoxFuncionario.Text;
                compra.Colecao = this.itensCompra.ToArray();

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
                    compra.NumCompra = Convert.ToInt32(textBoxNum.Text);

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
                    foreach (var item in itensCompra)
                    {
                        ListViewItem lvi = listViewProdutos.Items.Add(Convert.ToString(item.Produto.CodProduto));
                        lvi.SubItems.Add(Convert.ToString(item.QtdCompra));
                        lvi.SubItems.Add(Convert.ToString(item.Produto.PrecoProduto));
                        lvi.SubItems.Add(Convert.ToString(item.Validade));
                    }
                    textBoxNum.Text = "";
                    textBoxData.Text = "";
                    textBoxFornecedor.Text = "";
                    textBoxFuncionario.Text = "";
                    textBoxProduto.Text = "";
                    textBoxQTD.Text = "";
                    textBoxPreco.Text = "";
                    textBoxValidade.Text = "";
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
        //Função para inserir produtos na compra
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Compra_Produto compra_produto = new Compra_Produto();
                float valorTotal = float.Parse(textBoxPreco.Text) * float.Parse(textBoxQTD.Text);
                compra_produto.Produto.CodProduto = Convert.ToInt32(textBoxProduto.Text);
                compra_produto.QtdCompra = Convert.ToInt32(textBoxQTD.Text);
                compra_produto.ValorTotal = valorTotal;
                compra_produto.Validade = Convert.ToDateTime(textBoxValidade.Text);
                this.itensCompra.Add(compra_produto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Função para alterar compra
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                compra.NumCompra = Convert.ToInt32(textBoxNum.Text);
                compra.DataCompra = Convert.ToDateTime(textBoxData.Text);
                compra.Fornecedor.Cnpj = textBoxFornecedor.Text;
                compra.Funcionario.CodFuncionario = Convert.ToInt16(textBoxFuncionario.Text);
                sv.AlterarCompra(compra);
                MessageBox.Show("Compra alterada com sucesso!");
                listViewCompra.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Função para deslogar
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //Função para enviar dados da ListView para a textBox
        private void listViewCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewCompra.FocusedItem != null)
                {
                    int index = listViewCompra.FocusedItem.Index;
                    Compra compra = this.compras.ElementAt(index);
                    textBoxFornecedor.Text = compra.Fornecedor.Cnpj;
                    textBoxFuncionario.Text = Convert.ToString(compra.Funcionario.CodFuncionario);
                    textBoxNum.Text = Convert.ToString(compra.NumCompra);
                    textBoxData.Text = Convert.ToString(compra.DataCompra);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Função para enviar dados da ListView para a textBox
        private void listViewProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewProdutos.FocusedItem != null)
                {
                    int index = listViewProdutos.FocusedItem.Index;                    
                    Compra_Produto compraProduto = this.itensCompra.ElementAt(index);
                    textBoxProduto.Text = Convert.ToString(compraProduto.Produto.CodProduto);
                    textBoxQTD.Text = Convert.ToString(compraProduto.QtdCompra);
                    textBoxPreco.Text = Convert.ToString(compraProduto.ValorTotal);
                    textBoxValidade.Text = Convert.ToString(compraProduto.Validade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
