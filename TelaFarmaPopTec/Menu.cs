using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaFarmaPopTec
{
    public partial class Menu : Form
    {
        public Menu(String funcao)
        {
            InitializeComponent();
            verificarFuncao(funcao);
        }
        private void verificarFuncao(String funcao)
        {
            if(funcao.Equals("Atendente"))
            {
                buttonCliente.Enabled = true;
                buttonFuncionario.Enabled = false;
                buttonFornacedor.Enabled = false;
                buttonCaixa.Enabled = false;
                buttonProdutos.Enabled = true;
                buttonVenda.Enabled = true;
                buttonRelatorios.Enabled = false;
                buttonSair.Enabled = true;
                buttonFornacedor.BackColor = Color.Gainsboro;
                buttonFuncionario.BackColor = Color.Gainsboro;
                buttonCaixa.BackColor = Color.Gainsboro;
                buttonRelatorios.BackColor = Color.Gainsboro;
            }
            else if (funcao.Equals("Gerente"))
            {
                buttonCliente.Enabled = true;
                buttonFuncionario.Enabled = true;
                buttonFornacedor.Enabled = true;
                buttonCaixa.Enabled = true;
                buttonProdutos.Enabled = true;
                buttonVenda.Enabled = true;
                buttonRelatorios.Enabled = true;
                buttonSair.Enabled = true;
            }
            else if (funcao.Equals("Caixa"))
            {
                buttonCliente.Enabled = true;                
                buttonFuncionario.Enabled = false;
                buttonFornacedor.Enabled = false;
                buttonCaixa.Enabled = true;
                buttonProdutos.Enabled = true;
                buttonVenda.Enabled = true;
                buttonRelatorios.Enabled = false;
                buttonSair.Enabled = true;
                buttonFornacedor.BackColor = Color.Gainsboro;
                buttonFuncionario.BackColor = Color.Gainsboro;
                buttonRelatorios.BackColor = Color.Gainsboro;
            }
            else if (funcao.Equals("Farmacêutico"))
            {
                buttonCliente.Enabled = true;
                buttonFuncionario.Enabled = false;
                buttonFornacedor.Enabled = false;
                buttonCaixa.Enabled = false;
                buttonProdutos.Enabled = true;
                buttonVenda.Enabled = true;
                buttonRelatorios.Enabled = false;
                buttonSair.Enabled = true;
                buttonFornacedor.BackColor = Color.Gainsboro;
                buttonFuncionario.BackColor = Color.Gainsboro;
                buttonCaixa.BackColor = Color.Gainsboro;
                buttonRelatorios.BackColor = Color.Gainsboro;
            }
        }
        private void buttonCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cad = new CadastroCliente();
            cad.ShowDialog();
            
        }

        private void buttonFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario fun = new CadastroFuncionario();
            fun.ShowDialog();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void buttonFornacedor_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor cadastrarFornecedor = new CadastrarFornecedor();
            cadastrarFornecedor.ShowDialog();          
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            OpcoesProduto opcoesProduto = new OpcoesProduto();
            opcoesProduto.ShowDialog();
        }

        private void buttonCaixa_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.ShowDialog();
        }
        
    }
}
