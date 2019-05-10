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

namespace TelaFarmaPopTec
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Service1 sv = new Service1();
                Cliente cliente = new Cliente();
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
    }
}