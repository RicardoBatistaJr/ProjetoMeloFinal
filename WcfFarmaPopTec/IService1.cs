﻿using Biblioteca.classesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfFarmaPopTec
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IService1
    {
        // Cliente
        [OperationContract]
        void CadastrarCliente(Cliente cliente);
        [OperationContract]
        void AlterarCliente(Cliente cliente);
        [OperationContract]
        void DeletarCliente(Cliente cliente);
        [OperationContract]
        List<Cliente> ConsultarCliente(Cliente filtro);
        [OperationContract]
        List<Cliente> ListarClientes();
        [OperationContract]
        List<VendaProduto> ListarVendaCliente(Cliente cliente);
        [OperationContract]
        bool VerificarDuplicidadeCliente(Cliente cliente);
        [OperationContract]
        bool ValidaCpfCliente(string cpf);
        

        // Funcionario
        [OperationContract]
        void CadastrarFuncionario(Funcionario funcionario);
        [OperationContract]
        void AlterarFuncionario(Funcionario funcionario);
        [OperationContract]
        void DeletarFuncionario(Funcionario funcionario);
        [OperationContract]
        List<Funcionario> ConsultarFuncionario(Funcionario filtro);
        [OperationContract]
        List<Funcionario> ListarFuncionarios();
        [OperationContract]
        bool ExisteFuncionario(Funcionario funcionario);
        [OperationContract]
        bool ValidarCpfFuncionario(string cpf);
        [OperationContract]
        Funcionario Logar(Funcionario funcionario);

        // Compra
        [OperationContract]
        void CadastrarCompra(Compra compra);
        [OperationContract]
        void AlterarCompra(Compra compra);
        [OperationContract]
        void CancelarCompra(Compra compra);
        [OperationContract]
        List<Compra> ConsultarCompra(Compra filtro);
        [OperationContract]
        List<Compra> ListarCompras();
        [OperationContract]
        List<Compra_Produto> ListarProdutosCompras(Compra filtro);

        // Fornecedor
        [OperationContract]
        void CadastrarFornecedor(Fornecedor fornecedor);
        [OperationContract]
        void AlterarFornecedor(Fornecedor fornecedor);
        [OperationContract]
        List<Fornecedor> ListarFornecedor();
        [OperationContract]
        List<Fornecedor> ConsultarFornecedor(Fornecedor filtro);
        [OperationContract]
        bool VerificarDuplicidadeFornecedor(Fornecedor fornecedor);
        [OperationContract]
        bool ValidarCnpj(String cnpj);      

        // TODO: Adicione suas operações de serviço aqui


        // PRODUTOS
        [OperationContract]
        void CadastrarProduto(Produto produto);
        [OperationContract]
        void AlterarProduto(Produto produto);
        [OperationContract]
        void DeletarProduto(Produto produto);
        [OperationContract]
        void DesativarProduto(Produto produto);
        [OperationContract]
        void AtivarProduto(Produto produto);
        [OperationContract]
        List<Produto> ConsultarProduto(Produto filtro);
        [OperationContract]
        void TrocarProduto();
        [OperationContract]
        List<Produto> ListarProdutos();
        [OperationContract]
        bool VerificarDuplicidadeProduto(Produto produto);
        [OperationContract]
        void AlterarSaldoProduto(int codProdruto, int qtd);

        // VENDA
        [OperationContract]
        void CadastrarVenda(Venda venda);
        [OperationContract]
        void AlterarVenda(Venda venda);
        [OperationContract]
        void DeletarVenda(int numVenda);
        [OperationContract]
        List<VendaProduto> ListarVendas();
        [OperationContract]
        List<VendaProduto> ListarVenda(int numVenda);
        [OperationContract]
        List<Venda> ListarVendaAtendente(Venda venda);
        [OperationContract]
        bool VerificarDuplicidadeVenda(Venda venda);
        [OperationContract]
        void DeletarItemVenda(int numVenda, int codProduto);
    }


    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
