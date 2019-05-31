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
    public partial class CadastrarFornecedor : Form
    {
        Service1 sv = new Service1();
        Fornecedor fornecedor = new Fornecedor();
        List<Fornecedor> fornecedores = new List<Fornecedor>();

        public CadastrarFornecedor()
        {
            InitializeComponent();
        }
        //Função para cadastrar fornecedor
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                fornecedor.Cnpj = textBoxCnpj.Text;
                fornecedor.NomeFornecedor = textBoxFornecedor.Text;               
                sv.CadastrarFornecedor(fornecedor);
                MessageBox.Show("Fornecedor cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Função para limpar campos de textbox
        private void buttonlimpar_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxCnpj.Text = "";
                textBoxFornecedor.Text = "";                
                listViewFornecedor.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Função para pesquisar fornecedor
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonListarCompras_Click(object sender, EventArgs e)
        {

        }
    }
}
