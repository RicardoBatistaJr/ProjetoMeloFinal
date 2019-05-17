using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.classesBasicas;
using Biblioteca.dados;
using Biblioteca.negocio;
using FarmaPopTec_1._0.Negocio;

namespace WcfFarmaPopTec
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IService1
    {
        public void AlterarCliente(Cliente cliente)
        {
            new ClienteNegocio().AlterarCliente(cliente);
        }

        public void AlterarCompra(Compra compra)
        {
             new CompraNegocio().AlterarCompra(compra);
        }

        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public void AlterarFuncionario(Funcionario funcionario)
        {
            new FuncionarioNegocio().AlterarFuncionario(funcionario) ;
        }

        public void CadastrarCliente(Cliente cliente)
        {
            new ClienteNegocio().CadastrarCliente(cliente);
        }

        public void CadastrarCompra(Compra compra)
        {
            throw new NotImplementedException();
        }

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            new FuncionarioNegocio().CadastrarFuncionario(funcionario);
        }

        public void CancelarCompra(Compra compra)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ConsultarCliente(Cliente filtro)
        {
            return new ClienteNegocio().ConsultarCliente(filtro);
        }

        public List<Compra> ConsultarCompra(Compra filtro)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> ConsultarFuncionario(Funcionario filtro)
        {
            return new FuncionarioNegocio().ConsultarFuncionario(filtro);
            
        }
        public void DeletarCliente(Cliente cliente)
        {
            new ClienteNegocio().DeletarCliente(cliente);
        }

        public void DeletarFuncionario(Funcionario funcionario)
        {
            new FuncionarioNegocio().DeletarFuncionario(funcionario);
        }

        public bool ExisteFuncionario(Funcionario funcionario)
        {
            return new FuncionarioNegocio().ExisteFuncionario(funcionario);
        }

        public List<Cliente> ListarClientes()
        {
            return new ClienteNegocio().ListarClientes();
        }

        public List<Compra> ListarCompras(Compra filtro)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> ListarFornecedor(Fornecedor filtro)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> ListarFuncionarios()
        {
            return new FuncionarioNegocio().ListarFuncionarios();
        }

        public List<Venda> ListarVendaCliente(Cliente cliente)
        {
            return new ClienteNegocio().ListarVendaCliente(cliente);
        }

        public bool ValidaCpfCliente(string cpf)
        {
           return new ClienteNegocio().ValidaCpfCliente(cpf);
        }

        public bool ValidarCpfFuncionario(string cpf)
        {
            return new FuncionarioNegocio().ValidarCpfFuncionario(cpf);
        }

        public bool VerificarDuplicidadeCliente(Cliente cliente)
        {
            return new ClienteNegocio().VerificarDuplicidadeCliente(cliente);
        }

        public void VerificarDuplicidadeFornecedor(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }
    }
}
