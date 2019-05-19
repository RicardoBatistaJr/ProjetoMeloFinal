using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaFarmaPopTec.localhost;

namespace TelaFarmaPopTec
{
    public partial class CadastroFuncionario : Form
    {
        Service1 sv = new Service1();
        Funcionario funcionario = new Funcionario();
        List<Funcionario> funcionarios = new List<Funcionario>();
        public CadastroFuncionario()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(textBoxCpfFunc);
            sList.Add("CPF (Só números)");
            tList.Add(textBoxSenha);
            sList.Add("Seis dígitos");
            SetCueBanner(ref tList, sList);
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);
        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }

        private void buttonSalvarF_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario fu = new Funcionario();
                fu.CpfFuncionario = textBoxCpfFunc.Text;
                fu.NomeFuncionario = textBoxNomeFunc.Text;
                fu.FuncaoFuncionario = comboBoxFuncao.Text;
                fu.SenhaUsuario = textBoxSenha.Text;
                sv.CadastrarFuncionario(fu);
                MessageBox.Show("Funcionário cadastrado com sucesso!");                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluirF_Click(object sender, EventArgs e)
        {
            try
            {
                funcionario.CodFuncionario = int.Parse(textBoxCod.Text);
                sv.DeletarFuncionario(funcionario);
                textBoxCod.Text = "";
                textBoxCpfFunc.Text = "";
                textBoxNomeFunc.Text = "";
                comboBoxFuncao.Text = "";
                textBoxSenha.Text = "";
                listViewFuncionarios.Items.Clear();
                MessageBox.Show("Funcionário excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonlimparF_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxCod.Text = "";
                textBoxCpfFunc.Text = "";
                textBoxNomeFunc.Text = "";
                comboBoxFuncao.Text = "";
                textBoxSenha.Text = "";
                listViewFuncionarios.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListarFuncionarios_Click(object sender, EventArgs e)
        {
            try
            {
                    this.funcionarios.Clear();
                    this.funcionarios = sv.ListarFuncionarios().ToList();

                    listViewFuncionarios.Items.Clear();

                    foreach (var item in funcionarios)
                    {
                        ListViewItem lvi = listViewFuncionarios.Items.Add(item.CodFuncionario.ToString());
                        lvi.SubItems.Add(item.CpfFuncionario);
                        lvi.SubItems.Add(item.NomeFuncionario);
                        lvi.SubItems.Add(item.FuncaoFuncionario);
                        lvi.SubItems.Add(item.SenhaUsuario.ToString());
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewFuncionarios.FocusedItem != null)
                {
                    int index = listViewFuncionarios.FocusedItem.Index;
                    Funcionario fun = this.funcionarios.ElementAt(index);
                    textBoxCod.Text = fun.CodFuncionario.ToString();
                    textBoxCpfFunc.Text = fun.CpfFuncionario;
                    textBoxNomeFunc.Text = fun.NomeFuncionario;
                    comboBoxFuncao.Text = fun.FuncaoFuncionario;
                    textBoxSenha.Text = fun.SenhaUsuario.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPesquisarF_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCpfFunc.Text != null || textBoxNomeFunc.Text != null)
                {
                    funcionario.CpfFuncionario = textBoxCpfFunc.Text;
                    funcionario.NomeFuncionario = textBoxNomeFunc.Text;

                    this.funcionarios.Clear();
                    this.funcionarios = sv.ConsultarFuncionario(funcionario).ToList();

                    listViewFuncionarios.Items.Clear();

                    foreach (var item in funcionarios)
                    {
                        ListViewItem lvi = listViewFuncionarios.Items.Add(item.CodFuncionario.ToString());
                        lvi.SubItems.Add(item.CpfFuncionario);
                        lvi.SubItems.Add(item.NomeFuncionario);
                        lvi.SubItems.Add(item.FuncaoFuncionario);
                        lvi.SubItems.Add(item.SenhaUsuario.ToString());
                    }
                    textBoxCod.Text = "";
                    textBoxCpfFunc.Text = "";
                    textBoxNomeFunc.Text = "";
                    comboBoxFuncao.Text = "";
                    textBoxSenha.Text = "";

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

        private void buttonAlterarF_Click(object sender, EventArgs e)
        {
            try
            {
                funcionario.CpfFuncionario = textBoxCpfFunc.Text;
                funcionario.NomeFuncionario = textBoxNomeFunc.Text;
                funcionario.FuncaoFuncionario = comboBoxFuncao.Text;
                funcionario.SenhaUsuario = textBoxSenha.Text;
                sv.AlterarFuncionario(funcionario);
                MessageBox.Show("Funcionário alterado com sucesso!");
                listViewFuncionarios.Items.Clear();
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
