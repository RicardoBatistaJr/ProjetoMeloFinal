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

    public partial class CadastroCliente : Form
    {
        Service1 sv = new Service1();
        Cliente cliente = new Cliente();
        List<Cliente> clientes = new List<Cliente>();
        public CadastroCliente()
        {
            InitializeComponent();
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
                listViewCliente.Items.Clear();
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
                
                if (textBoxCpf.Text != null || textBoxNome.Text != null)
                {
                    cliente.CpfCliente = textBoxCpf.Text;
                    cliente.NomeCliente = textBoxNome.Text;

                    this.clientes.Clear();
                    this.clientes = sv.ConsultarCliente(cliente).ToList();

                    listViewCliente.Items.Clear();

                    foreach (var item in clientes)
                    {
                        ListViewItem lvi = listViewCliente.Items.Add(item.CpfCliente);
                        lvi.SubItems.Add(item.NomeCliente);
                        lvi.SubItems.Add(item.EmailCliente);
                        lvi.SubItems.Add(item.TelCliente.ToString());
                    }
                    textBoxCpf.Text = "";
                    textBoxNome.Text = "";
                    textBoxEmail.Text = "";
                    textBoxTel.Text = "";

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
            try
            {
                this.clientes.Clear();
                this.clientes = sv.ListarClientes().ToList();

                listViewCliente.Items.Clear();

                foreach (var item in this.clientes)
                {
                    ListViewItem lvi = listViewCliente.Items.Add(item.CpfCliente);
                    lvi.SubItems.Add(item.NomeCliente);
                    lvi.SubItems.Add(item.EmailCliente);
                    lvi.SubItems.Add(item.TelCliente.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (listViewCliente.FocusedItem != null)
                {
                    int index = listViewCliente.FocusedItem.Index;
                    Cliente cli = this.clientes.ElementAt(index);
                    textBoxCpf.Text = cli.CpfCliente;
                    textBoxNome.Text = cli.NomeCliente;
                    textBoxEmail.Text = cli.EmailCliente;
                    textBoxTel.Text = cli.TelCliente.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.CpfCliente = textBoxCpf.Text;
                cliente.NomeCliente = textBoxNome.Text;
                cliente.EmailCliente = textBoxEmail.Text;
                cliente.TelCliente.ToString() = textBoxTel.Text;
                sv.AlterarCliente(cliente);
                MessageBox.Show("cliente alterado com sucesso!");
                listViewCliente.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}