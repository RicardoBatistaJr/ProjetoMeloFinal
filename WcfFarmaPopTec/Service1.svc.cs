using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.classesBasicas;
using Biblioteca.negocio;

namespace WcfFarmaPopTec
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IService1
    {
        public void AlterarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void AlterarFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ConsultarCliente(Cliente filtro)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> ConsultarFuncionario(Funcionario filtro)
        {
            throw new NotImplementedException();
        }

        public void DeletarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void DeletarFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public bool ExisteFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarClientes()
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> ListarFuncionarios()
        {
            throw new NotImplementedException();
        }

        public List<Venda> ListarVendaCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool ValidaCpfCliente(string cpf)
        {
            return new DadosCliente().ValidaCpfCliente(cpf);
        }

        public bool ValidarCpfFuncionario(string cpf)
        {
            throw new NotImplementedException();
        }

        public bool VerificarDuplicidadeCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
