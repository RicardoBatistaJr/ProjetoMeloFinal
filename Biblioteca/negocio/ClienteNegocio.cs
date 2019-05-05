using Biblioteca.classesBasicas;
using Biblioteca.dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca.negocio
{
    public class ClienteNegocio : IClienteDados
    {
        // Retorna se o 
        bool IClienteDados.ValidaCpfCliente(string cpf)
        {   
            return new DadosCliente().ValidaCpfCliente(cpf);
        }

        bool IClienteDados.VerificarDuplicidadeCliente(Cliente cliente)
        {
            return new DadosCliente().VerificarDuplicidadeCliente(cliente);
        }

        void IClienteDados.AlterarCliente(Cliente cliente)
        {
            new DadosCliente().AlterarCliente(cliente);
        }

        void IClienteDados.CadastrarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new Exception("Informar os dados do cliente.");
            }
            if (cliente.CpfCliente == null)
            {
                throw new Exception("Informar o CPF do cliente.");
            }
            if (cliente.CpfCliente != null)
            {
                if (!new DadosCliente().ValidaCpfCliente(cliente.CpfCliente))
                {
                    throw new Exception("CPF invalido!");
                }
                if(!new DadosCliente().VerificarDuplicidadeCliente(cliente))
                {
                    throw new Exception("CPF já cadastrado!");
                }
            }
            if (string.IsNullOrWhiteSpace(cliente.CpfCliente) == true)
            {
                throw new Exception("Informar o CPF do clinete.");
            }
            if (string.IsNullOrEmpty(cliente.NomeCliente) == true)
            {
                throw new Exception("Informar o nome do cliente.");
            }
            if (string.IsNullOrWhiteSpace(cliente.NomeCliente) == true)
            {
                throw new Exception("Informar o nome do cliente");
            }           
            new DadosCliente().CadastrarCliente(cliente);
        }

        List<Cliente> IClienteDados.ConsultarCliente(Cliente filtro)
        {
            if (string.IsNullOrEmpty(filtro.CpfCliente) || string.IsNullOrEmpty(filtro.NomeCliente) == true)
            {
                throw new Exception("Digite um CPF ou Nome para consulta.");
            }
            else
            {
                return new DadosCliente().ConsultarCliente(filtro);
            }
        }

        void IClienteDados.DeletarCliente(Cliente cliente)
        {
            if (new DadosCliente().VerificarDuplicidadeCliente(cliente))
            {
                new DadosCliente().DeletarCliente(cliente);
            }
            else
            {
                throw new Exception("Cliente não existe!");
            }
            
        }
        List<Cliente> IClienteDados.ListarClientes()
        {
            return new DadosCliente().ListarClientes();
        }

        List<Venda> IClienteDados.ListarVendaCliente(Cliente cliente)
        {
            return new DadosCliente().ListarVendaCliente(cliente);
        }
    }
}
