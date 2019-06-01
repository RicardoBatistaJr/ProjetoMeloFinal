using System.Collections.Generic;
using Biblioteca.classesBasicas;

namespace Biblioteca.dados
{
    public interface IProdutoDados
    {
        void CadastrarProduto(Produto produto);
        void AlterarProduto(Produto produto);
        void DeletarProduto(Produto produto);
        void DesativarProduto(Produto produto);
        void AtivarProduto(Produto produto);
        List<Produto> ConsultarProduto(Produto filtro);
        void TrocarProduto();
        List<Produto> ListarProdutos();
        bool VerificarDuplicidadeProduto(Produto produto);

    }
}
