using Biblioteca.classesBasicas;
using FarmaPopTec_1._0.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class FornecedorNegocio : IFornecedorDados
    {
        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> ListarFornecedor(Fornecedor filtro)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
      
        bool IFornecedorDados.VerificarDuplicidadeFornecedor(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }
    }
}
