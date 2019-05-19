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
    public class VendaNegocio : IVendaDados 
    {
       public bool VerificarDuplicidadeVenda(Venda venda)
       {
        return new DadosVenda().VerificarDuplicidadeVenda(venda);

       }

        public void AlterarVenda(Venda venda)
        {
            new DadosVenda().AlterarVenda(venda);
        }

        public void CadastrarVenda(Venda venda)
        {
            if (venda == null)
            {
                throw new Exception("Informar os dados da venda.");
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
                if (new DadosCliente().VerificarDuplicidadeCliente(cliente))
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
    }
}