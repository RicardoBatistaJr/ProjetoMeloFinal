using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                string email = textBoxEmail.Text;
                string tel = textBoxTel.Text;
                Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                string strMascara = "{0:(00)0000-0000}";
                long lngNumero = Convert.ToInt64(tel);
                if (rg.IsMatch(email))
                {
                    if (tel.Length == 11)
                    {
                        strMascara = "{0:(00)00000-0000}";
                        string.Format(strMascara, lngNumero);

                        cliente.CpfCliente = textBoxCpf.Text;
                        cliente.NomeCliente = textBoxNome.Text;
                        cliente.EmailCliente = textBoxEmail.Text;
                        cliente.TelCliente = textBoxTel.Text;
                        sv.CadastrarCliente(cliente);
                        MessageBox.Show("Cliente cadastrado!");
                    }
                    else
                    {
                        MessageBox.Show("Telefone Inválido!");
                    }
                }
                else
                {
                    
                    MessageBox.Show("Email Inválido!");
                }

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
                listViewCliente.Items.Clear();
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
                        lvi.SubItems.Add(item.TelCliente);
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
                    lvi.SubItems.Add(item.TelCliente);

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
                    textBoxTel.Text = cli.TelCliente;
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
                cliente.TelCliente = textBoxTel.Text;
                sv.AlterarCliente(cliente);
                MessageBox.Show("cliente alterado com sucesso!");
                listViewCliente.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (listViewCompras.FocusedItem != null)
                {
                    int index = listViewCompras.FocusedItem.Index;
                    Cliente cli = this.clientes.ElementAt(index);
                    textBoxCpf.Text = cli.CpfCliente;
                    textBoxNome.Text = cli.NomeCliente;
                    textBoxEmail.Text = cli.EmailCliente;
                    textBoxTel.Text = cli.TelCliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}