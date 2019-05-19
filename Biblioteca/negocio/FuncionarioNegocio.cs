using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.classesBasicas;
using Biblioteca.dados;

namespace Biblioteca.negocio
{
    public class FuncionarioNegocio : IFuncionarioDados
    {
        public void AlterarFuncionario(Funcionario funcionario)
        {
            new DadosFuncionario().AlterarFuncionario(funcionario);
        }

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            if (funcionario == null)
            {
                throw new Exception("Informar os dados do funcionario.");
            }          
            if (funcionario.CpfFuncionario != null)
            {
                if (!new DadosFuncionario().ValidarCpfFuncionario(funcionario.CpfFuncionario))
                {
                    throw new Exception("CPF invalido!");
                }
                if (new DadosFuncionario().ExisteFuncionario(funcionario))
                {
                    throw new Exception("CPF já cadastrado!");
                }
            }
            if (string.IsNullOrWhiteSpace(funcionario.CpfFuncionario) == true)
            {
                throw new Exception("Informar o CPF do funcionario.");
            }
            if (string.IsNullOrEmpty(funcionario.NomeFuncionario) == true)
            {
                throw new Exception("Informar o nome do funcionario.");
            }
            if (string.IsNullOrWhiteSpace(funcionario.NomeFuncionario) == true)
            {
                throw new Exception("Informar o nome do funcionario");
            }
            new DadosFuncionario().CadastrarFuncionario(funcionario);
        }    

        public List<Funcionario> ConsultarFuncionario(Funcionario filtro)
        {
            if (filtro.CodFuncionario == null & string.IsNullOrEmpty(filtro.CpfFuncionario) & string.IsNullOrEmpty(filtro.NomeFuncionario) == true)
            {
                throw new Exception("Digite um Código ou CPF ou Nome para consulta.");
            }
            else
            {
                return new DadosFuncionario().ConsultarFuncionario(filtro);
            }
        }

        public void DeletarFuncionario(Funcionario funcionario)
        {
            if (new DadosFuncionario().ExisteFuncionario(funcionario))
            {
                new DadosFuncionario().DeletarFuncionario(funcionario);
            }
            else
            {
                throw new Exception("Funcionario não existe!");
            }
        }

        public bool ExisteFuncionario(Funcionario funcionario)
        {
            return new DadosFuncionario().ExisteFuncionario(funcionario);

        }
        public List<Funcionario> ListarFuncionarios()
        {
            return new DadosFuncionario().ListarFuncionarios();
        }

        public bool ValidarCpfFuncionario(string cpf)
        {
            return new DadosFuncionario().ValidarCpfFuncionario(cpf);
        }
        public Funcionario Logar(Funcionario funcionario)
        {
            Funcionario fun = new Funcionario();
            fun =  new DadosFuncionario().Logar(funcionario);
            if (fun == null)           
            {
                throw new Exception("Funcionario não encontrado!");
            }
            return fun;
        }
    }
}
