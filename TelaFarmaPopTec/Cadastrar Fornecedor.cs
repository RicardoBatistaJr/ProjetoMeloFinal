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
            //try
            //{

            //    if (textBoxCnpj.Text != null || textBoxFornecedor.Text != null)
            //    {
            //        fornecedor.Cnpj = textBoxCnpj.Text;
            //        fornecedor.NomeFornecedor = textBoxFornecedor.Text;

            //        this.fornecedor.Clear();
            //        this.fornecedor = sv.ConsultarFornecedor(fornecedor).ToList();

            //        listViewFornecedor.Items.Clear();

            //        foreach (var item in fornecedor)
            //        {
            //            ListViewItem lvi = listViewFornecedor.Items.Add(item.Cnpj);
            //            lvi.SubItems.Add(item.Fornecedor);                        
            //        }
            //        textBoxCnpj.Text = "";
            //        textBoxFornecedor.Text = "";                   
            //    }
            //    else
            //    {
            //        MessageBox.Show("Informar um nome ou CPF!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        //Função para alterar fornecedor
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {                
                fornecedor.Cnpj = textBoxCnpj.Text;
                fornecedor.NomeFornecedor = textBoxFornecedor.Text;
                sv.AlterarFornecedor(fornecedor);
                MessageBox.Show("Fornecedor alterado com sucesso!");
                listViewFornecedor.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        //Função para voltar a tela inicial
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //Função para listar fornecedores
        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.fornecedor.Clear();
            //    this.fornecedor = sv.ListarFornecedor().ToList();

            //    listViewFornecedor.Items.Clear();

            //    foreach (var item in this.fornecedor)
            //    {
            //        ListViewItem lvi = listViewFornecedor.Items.Add(item.CpfCliente);
            //        lvi.SubItems.Add(item.Fornecedor);                    
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        //Função para listar compras com o fornecedor
        private void buttonListarCompras_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void ButtonListarCompras_Click(object sender, EventArgs e)
        {

        }
    }
}
