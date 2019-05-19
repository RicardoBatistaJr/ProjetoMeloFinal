using Biblioteca.classesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.dados
{
    public interface IFuncionarioDados
    {
        void CadastrarFuncionario(Funcionario funcionario);
        void AlterarFuncionario(Funcionario funcionario);
        void DeletarFuncionario(Funcionario funcionario);
        List<Funcionario> ConsultarFuncionario(Funcionario filtro);
        List<Funcionario> ListarFuncionarios();
        bool ExisteFuncionario(Funcionario funcionario);
        bool ValidarCpfFuncionario(string cpf);
        Funcionario Logar(Funcionario funcionario);
    }
}
