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
    public class ProdutoNegocio : IProdutoDados
    {
        public bool VerificarDuplicidadeProduto(Produto produto)
        {
            return new DadosProduto().VerificarDuplicidadeProduto(produto);

        }
        public void CadastrarProduto(Produto produto)
        {
            if (produto == null)
            {
                throw new Exception("Informar os dados do produto.");
            }
            if (produto.CodProduto == 0)
            {
                throw new Exception("Informar o numero do produto.");
            }
            if (produto.CodProduto != 0)
            {
                if (new DadosProduto().VerificarDuplicidadeProduto(produto))
                {
                    throw new Exception("Produto já cadastrado.");
                }
            }
        }

            public void AlterarProduto(Produto produto)
        {
            new DadosProduto().AlterarProduto(produto);
        }

        public void DesativarProduto(Produto produto)
        {
            new DadosProduto().DesativarProduto(produto);
        }
        public void DeletarProduto(Produto produto)
        {
            DadosProduto dadosproduto = new DadosProduto();
            if (dadosproduto.VerificarDuplicidadeProduto(produto))
            {
                dadosproduto.DeletarProduto(produto);
            }
            else
            {
                throw new Exception("Produto não existe!");
            }
        }

        public List<Produto> ListarProdutos()
        {
            return new DadosProduto().ListarProdutos();
        }

        public List<Produto> ConsultarProduto(Produto filtro)
        {
            if (filtro.CodProduto != 0)
            {
                throw new Exception("Digite o código do produto para pesquisa.");
            }
            else
            {
                return new DadosProduto().ConsultarProduto(filtro);
            }
        }


        public void TrocarProduto()
        {
            throw new Exception("fALTANDO IMPLEMENTAÇÃO");
        }

    }
}
