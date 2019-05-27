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
            if (venda.NumVenda == 0)
            {
                throw new Exception("Informar o numero da venda.");
            }
            if (venda.NumVenda != 0)
            {
                if (new DadosVenda().VerificarDuplicidadeVenda(venda))
                {
                    throw new Exception("Venda já cadastrada");
                }
            }
            if (string.IsNullOrEmpty(venda.Cliente.CpfCliente) == true)
            {
                throw new Exception("Informar o  cpf Cliente");
            }
            new DadosVenda().CadastrarVenda(venda);
        }

        public void DeletarVenda(Venda venda)
        {
            DadosVenda dadosvenda = new DadosVenda();
            if (dadosvenda.VerificarDuplicidadeVenda(venda))
            {
                dadosvenda.DeletarVenda(venda);
            }
            else
            {
                throw new Exception("Venda não existe!");
            }
        }

        public List<Venda> ListarVendas()
        {
            return new DadosVenda().ListarVendas();
        }

        public List<Venda> ListarVendaAtendente(Venda venda)
        {
            return new DadosVenda().ListarVendaAtendente(venda);
        }
    }
}