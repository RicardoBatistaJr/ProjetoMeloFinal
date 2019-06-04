using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TelaFarmaPopTec.localhost;

namespace TelaFarmaPopTec
{
    public partial class Login : Form
    {
        Funcionario funcionario = new Funcionario();
        Service1 sv = new Service1();
        public Login()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(textBoxUsuario);
            sList.Add("Número do CPF");
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

        private void buttonAcessar_Click(object sender, EventArgs e)
        {
            Funcionario fun;
            try
            {
                funcionario.CpfFuncionario = textBoxUsuario.Text;
                funcionario.SenhaUsuario = textBoxSenha.Text;
                fun = sv.Logar(funcionario);

                if (fun != null)
                {

                    if (fun.SenhaUsuario == funcionario.SenhaUsuario)
                    {
                        if (fun.FuncaoFuncionario == "Gerente")
                        {
                            Menu menu = new Menu("Gerente");
                            menu.ShowDialog();
                            this.Close();
                        }
                        else if (fun.FuncaoFuncionario == "Farmacêutico")
                        {
                            Menu menu = new Menu("Farmacêutico");
                            menu.ShowDialog();
                            this.Close();
                        }
                        else if (fun.FuncaoFuncionario == "Atendente")
                        {
                            Menu menu = new Menu("Atendente");
                            menu.ShowDialog();
                            this.Close();
                        }
                        else if (fun.FuncaoFuncionario == "Caixa")
                        {
                            Menu menu = new Menu("Caixa");
                            menu.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("O funcionario foi cadastrado com função não permitida para acesso!");
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Senha não confere!");
                    }
                }
                else
                {
                    MessageBox.Show("Funcionário não cadastrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
    }

}
