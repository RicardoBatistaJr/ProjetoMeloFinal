using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.classesBasicas;
using Biblioteca.dados;

namespace Biblioteca.negocio
{
    class FuncionarioNegocio : IFuncionarioDados
    {
        void IFuncionarioDados.AlterarFuncionario(Funcionario funcionario)
        {
            new DadosFuncionario().AlterarFuncionario(funcionario);
        }

        void IFuncionarioDados.CadastrarFuncionario(Funcionario funcionario)
        {
            if (funcionario == null)
            {
                throw new Exception("Informar os dados do funcionario.");
            }
            if (funcionario.CodFuncionario == null)
            {
                throw new Exception("Informar o CPF do funcionario.");
            }
            if (funcionario.CpfFuncionario != null)
            {
                if (!new DadosFuncionario().ValidarCpfFuncionario(funcionario.CpfFuncionario))
                {
                    throw new Exception("CPF invalido!");
                }
                if (!new DadosFuncionario().ExisteFuncionario(funcionario))
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

        List<Funcionario> IFuncionarioDados.ConsultarFuncionario(Funcionario filtro)
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

        void IFuncionarioDados.DeletarFuncionario(Funcionario funcionario)
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

        bool IFuncionarioDados.ExisteFuncionario(Funcionario funcionario)
        {
            return new DadosFuncionario().ExisteFuncionario(funcionario);

        }
        List<Funcionario> IFuncionarioDados.ListarFuncionarios()
        {
            return new DadosFuncionario().ListarFuncionarios();
        }

        bool IFuncionarioDados.ValidarCpfFuncionario(string cpf)
        {
            return new DadosFuncionario().ValidarCpfFuncionario(cpf);
        }
    }
}
