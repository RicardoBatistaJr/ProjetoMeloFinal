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
            new DadosFornecedor().AlterarFornecedor(fornecedor);
        }

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            if (fornecedor == null)
            {
                throw new Exception("Informar os dados do fornecedor.");
            }
            if (fornecedor.Cnpj == null)
            {
                throw new Exception("Informar o CNPJ do fornecedor.");
            }
            if (fornecedor.Cnpj != null)
            {
                if (!new DadosFornecedor().ValidarCnpj(fornecedor.Cnpj))
                {
                    throw new Exception("CNPJ invalido!");
                }
                if (new DadosFornecedor().VerificarDuplicidadeFornecedor(fornecedor) == true)
                {
                    throw new Exception("CNPJ já cadastrado!");
                }
            }
            if (string.IsNullOrWhiteSpace(fornecedor.Cnpj) == true)
            {
                throw new Exception("Informar o CNPJ do fornecedor.");
            }
            if (string.IsNullOrEmpty(fornecedor.NomeFornecedor) == true)
            {
                throw new Exception("Informar o nome do fornecedor.");
            }

            new DadosFornecedor().CadastrarFornecedor(fornecedor);
        }

        public List<Fornecedor> ConsultarFornecedor(Fornecedor filtro)
        {
            if (string.IsNullOrEmpty(filtro.Cnpj) & string.IsNullOrEmpty(filtro.NomeFornecedor) == true)
            {            
                throw new Exception("Digite um CNPJ ou Nome de Fornecedor para consulta.");
            }
            else
            {
                return new DadosFornecedor().ConsultarFornecedor(filtro);
            }
        }

        public List<Fornecedor> ListarFornecedor()
        {
            return new DadosFornecedor().ListarFornecedor();
        }

        public bool ValidarCnpj(string cnpj)
        {
            return new DadosFornecedor().ValidarCnpj(cnpj);
        }

        public bool VerificarDuplicidadeFornecedor(Fornecedor fornecedor)
        {
            return new DadosFornecedor().VerificarDuplicidadeFornecedor(fornecedor);
        }
    }
}
