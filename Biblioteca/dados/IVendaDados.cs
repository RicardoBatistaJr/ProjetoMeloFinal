using System.Collections.Generic;
using Biblioteca.classesBasicas;



namespace Biblioteca.dados
{
	public interface IVendaDados
	{
        void CadastrarVenda(Venda venda);
        void AlterarVenda(Venda venda);
        void DeletarVenda(int numVenda);
        List<VendaProduto> ListarVendas();
        List<VendaProduto> ListarVenda(int numVenda);
        List<Venda> ListarVendaAtendente(Venda venda);
        bool VerificarDuplicidadeVenda(Venda venda);
    }
}
