﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.classesBasicas;
using Biblioteca.dados;
using Biblioteca.negocio;
using Biblioteca.Negocio;

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

        public void AlterarFuncionario(Funcionario funcionario)
        {
            new FuncionarioNegocio().AlterarFuncionario(funcionario) ;
        }

        public void CadastrarCliente(Cliente cliente)
        {
            new ClienteNegocio().CadastrarCliente(cliente);
        }              

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            new FuncionarioNegocio().CadastrarFuncionario(funcionario);
        }
       
        public List<Cliente> ConsultarCliente(Cliente filtro)
        {
            return new ClienteNegocio().ConsultarCliente(filtro);
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

        public List<Funcionario> ListarFuncionarios()
        {
            return new FuncionarioNegocio().ListarFuncionarios();
        }

        public List<VendaProduto> ListarVendaCliente(Cliente cliente)
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
       
        public Funcionario Logar(Funcionario funcionario)
        {
            return new FuncionarioNegocio().Logar(funcionario);
        }
      
        //service Fornecedor
        public List<Fornecedor> ConsultarFornecedor(Fornecedor filtro)
        {
            return new FornecedorNegocio().ConsultarFornecedor(filtro);
        }
        public bool VerificarDuplicidadeFornecedor(Fornecedor fornecedor)
        {
            return new FornecedorNegocio().VerificarDuplicidadeFornecedor(fornecedor);
        }
        public List<Fornecedor> ListarFornecedor()
        {
            return new FornecedorNegocio().ListarFornecedor();
        }
        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            new FornecedorNegocio().CadastrarFornecedor(fornecedor);
        }
        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            new FornecedorNegocio().AlterarFornecedor(fornecedor);
        }
        public bool ValidarCnpj(String cnpj)
        {
            return new FornecedorNegocio().ValidarCnpj(cnpj);
        }
       
        //service Compra/
        public List<Compra> ListarCompras(Compra filtro)
        {
            throw new NotImplementedException();
        }
        public List<Compra> ConsultarCompra(Compra filtro)
        {
            return new CompraNegocio().ConsultarCompra(filtro);
        }
        public List<Compra> ListarCompras()
        {
            return new CompraNegocio().ListarCompras();
        }
        public void CancelarCompra(Compra compra)
        {
            new CompraNegocio().CancelarCompra(compra);
        }
        public void CadastrarCompra(Compra compra)
        {
            new CompraNegocio().CadastrarCompra(compra);
        }
        public void AlterarCompra(Compra compra)
        {
            new CompraNegocio().AlterarCompra(compra);
        }
        public List<Compra_Produto> ListarProdutosCompras(Compra filtro)
        {
            return new CompraNegocio().ListarProdutosCompras(filtro);
        }
    }
}
