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
            if (venda.numVenda == null)
            {
                throw new Exception("Informar o numero da venda.");
            }
            if (venda.numVenda != null)
            {
                if (new DadosVenda().VerificarDuplicidadeVenda(venda))
                {
                    throw new Exception("Venda já cadastrada");
                }
            }
            if (int.IsNullOrWhiteSpace(venda.numVenda) == true)
            {
                throw new Exception("Informar o número de venda.");
            }
            if (string.IsNullOrEmpty(venda.Cliente.cpfCliente) == true)
            {
                throw new Exception("Informar o  cpf Cliente");
            }
            if (string.IsNullOrWhiteSpace(venda.Funcionario.codFuncionario) == true)
            {
                throw new Exception("Informar o nome do cliente");
            }
            new DadosCliente().CadastrarVenda(venda);
        }
    }
}