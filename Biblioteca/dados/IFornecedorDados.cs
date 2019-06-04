using Biblioteca.classesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaPopTec_1._0.Dados
{
    public interface IFornecedorDados
    {
        void CadastrarFornecedor(Fornecedor fornecedor);
        void AlterarFornecedor(Fornecedor fornecedor);
        List<Fornecedor> ListarFornecedor();
        List<Fornecedor> ConsultarFornecedor(Fornecedor filtro);
        bool VerificarDuplicidadeFornecedor(Fornecedor fornecedor);
        bool ValidarCnpj(string cnpj);
    }
}
