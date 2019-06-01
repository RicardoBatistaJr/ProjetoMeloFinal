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
      
        //FORNECEDOR
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
        public List<Fornecedor> ListarComprasComFornecedor(Fornecedor filtro)
        {
            return new FornecedorNegocio().ListarComprasComFornecedor(filtro);
        }
        //COMPRA
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

        // PRODUTO

        public void CadastrarProduto(Produto produto)
        {
            new ProdutoNegocio().CadastrarProduto(produto);
        }
        public void AlterarProduto(Produto produto)
        {
            new ProdutoNegocio().AlterarProduto(produto);
        }
        public void DeletarProduto(Produto produto)
        {
            new ProdutoNegocio().DeletarProduto(produto);
        }
        public void DesativarProduto(Produto produto)
        {
            new ProdutoNegocio().DeletarProduto(produto);
        }
        public void AtivarProduto(Produto produto)
        {
            new ProdutoNegocio().AtivarProduto(produto);
        }
        public List<Produto> ConsultarProduto(Produto filtro)
        {
            return new ProdutoNegocio().ConsultarProduto(filtro);
        }
        public void TrocarProduto()
        {
            new ProdutoNegocio().TrocarProduto();
        }
        public List<Produto> ListarProdutos()
        {
            return new ProdutoNegocio().ListarProdutos();
        }
        public bool VerificarDuplicidadeProduto(Produto produto)
        {
           return  new ProdutoNegocio().VerificarDuplicidadeProduto(produto);
        }

        // VENDA

        public bool VerificarDuplicidadeVenda(Venda venda)
        {
           return new VendaNegocio().VerificarDuplicidadeVenda(venda);
        }

        public void CadastrarVenda(Venda venda)
        {
            new VendaNegocio().CadastrarVenda(venda);
        }
        public void AlterarVenda(Venda venda)
        {
            new VendaNegocio().AlterarVenda(venda);
        }
        public void DeletarVenda(Venda venda)
        {
            new VendaNegocio().DeletarVenda(venda);
        }
        public List<VendaProduto> ListarVendas()
        {
            return new VendaNegocio().ListarVendas();
        }
        public List<VendaProduto> ListarVenda(Venda venda)
        {
            return new VendaNegocio().ListarVenda(venda);
        }

        public List<Venda> ListarVendaAtendente(Venda venda)
        {
           return new VendaNegocio().ListarVendaAtendente(venda);
        }

    }
}
