using System.Collections.Generic;
using Biblioteca.classesBasicas;



namespace Biblioteca.dados
{
	public interface IVendaDados
	{
        void CadastrarVenda(Venda venda);
        void AlterarVenda(Venda venda);
        void DeletarVenda(Venda venda);
        List<VendaProduto> ListarVendas();
        List<VendaProduto> ListarVenda(Venda venda);
        List<Venda> ListarVendaAtendente(Venda venda);
        bool VerificarDuplicidadeVenda(Venda venda);
    }
}
