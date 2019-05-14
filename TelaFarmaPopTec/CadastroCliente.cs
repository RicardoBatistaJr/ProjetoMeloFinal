using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfFarmaPopTec;
using Biblioteca.classesBasicas;
using System.Data.SqlClient;

namespace TelaFarmaPopTec
{

    public partial class CadastroCliente : Form
    {
        Service1 sv = new Service1();
        Cliente cliente = new Cliente();
        public CadastroCliente()
        {
            InitializeComponent();
            listViewCliente.Items.Clear();
            listViewCliente.View = View.Details;
            listViewCliente.GridLines = true;
            listViewCliente.Columns.Add("CPF:", 100, HorizontalAlignment.Left);
            listViewCliente.Columns.Add("Nome:", 200, HorizontalAlignment.Left);
            listViewCliente.Columns.Add("E-mail:", 200, HorizontalAlignment.Left);
            listViewCliente.Columns.Add("Telefone:", 100, HorizontalAlignment.Left);
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.CpfCliente = textBoxCpf.Text;
                cliente.NomeCliente = textBoxNome.Text;
                cliente.EmailCliente = textBoxEmail.Text;
                cliente.TelCliente = Int32.Parse(textBoxTel.Text);
                sv.CadastrarCliente(cliente);
                MessageBox.Show("Cliente cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.CpfCliente = textBoxCpf.Text;
                cliente.NomeCliente = textBoxNome.Text;
                sv.DeletarCliente(cliente);
                textBoxCpf.Text = "";
                textBoxNome.Text = "";
                textBoxEmail.Text = "";
                textBoxTel.Text = "";
                MessageBox.Show("cliente excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonlimpar_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxCpf.Text = "";
                textBoxNome.Text = "";
                textBoxEmail.Text = "";
                textBoxTel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();
                if (textBoxCpf.Text != null || textBoxNome.Text != null)
                {
                    cliente.CpfCliente = textBoxCpf.Text;
                    cliente.NomeCliente = textBoxNome.Text;
                    //sv.ConsultarCliente(cliente);
                    lista = sv.ConsultarCliente(cliente);
                    foreach (var item in lista)
                    {
                        textBoxCpf.Text = item.CpfCliente;
                        textBoxNome.Text = item.NomeCliente;
                        textBoxEmail.Text = item.EmailCliente;
                        textBoxTel.Text = Convert.ToString(item.TelCliente);
                    }
                }
                else
                {
                    MessageBox.Show("Informar um nome ou CPF!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = sv.ListarClientes();
            foreach (var item in clientes)
            {
               // listViewCliente.Items[0].Add(cliente.CpfCliente);
                textBoxNome.Text = item.NomeCliente;
                textBoxEmail.Text = item.EmailCliente;
                textBoxTel.Text = Convert.ToString(item.TelCliente);
            }
            //for (int i = 0; i < listViewCliente.Rows.Count; i++)
            //{
            //DataRow drow = dtable.Rows[i];

            //Somente as linhas que não foram deletadas
            //if (drow.RowState != DataRowState.Deleted)
            //{
            // Define os itens da lista
            // ListViewItem lvi = new ListViewItem(drow["ProductName"].ToString());
            // lvi.SubItems.Add(drow["ProductID"].ToString());
            // lvi.SubItems.Add(drow["UnitPrice"].ToString());

            // Inclui os itens no ListView
            // listViewCliente.Items.Add(lvi);

            //}
            //}
        }
    }
}