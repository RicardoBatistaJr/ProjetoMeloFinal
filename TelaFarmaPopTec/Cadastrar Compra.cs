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
        //Função para excluir Compra
        private void buttonExcluir_Click(object sender, EventArgs e)
        {

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

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
