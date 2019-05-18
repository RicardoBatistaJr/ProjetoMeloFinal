using System.Collections.Generic;
using Biblioteca.classesBasicas;



namespace Biblioteca.dados
{
    public interface IClienteDados
    {
        void CadastrarCliente (Cliente cliente);
        void AlterarCliente (Cliente cliente);
        void DeletarCliente (Cliente cliente);
        List<Cliente> ConsultarCliente (Cliente filtro);
        List<Cliente> ListarClientes ();
        List<VendaProduto> ListarVendaCliente(Cliente cliente);
        bool VerificarDuplicidadeCliente(Cliente cliente);
        bool ValidaCpfCliente(string cpf);

    }
    
}
