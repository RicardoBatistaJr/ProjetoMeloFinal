using Biblioteca.classesBasicas;
using FarmaPopTec_1._0.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca.Negocio
{
    public class CompraNegocio : ICompraDados
    {
        //Exeções para método de alterar compra
        public void AlterarCompra(Compra compra)
        {
            if (compra == null)
            {
                throw new Exception("Informar os dados da compra.");
            }
            if (compra.NumCompra == 0)
            {
                throw new Exception("Informar o número da compra.");
            }
            if (compra.Fornecedor.Cnpj != null)
            {
                if (!new DadosFornecedor().ValidarCnpj(compra.Fornecedor.Cnpj))
                {
                    throw new Exception("CNPJ invalido!");
                }
            }
            if (compra.Funcionario.CodFuncionario == 0)
            {
                throw new Exception("Informar um funcionario válido");
            }
            if (compra.DataCompra == null)
            {
                throw new Exception("Informar uma data valida");
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(compra.NumCompra)) == true)
            {
                throw new Exception("Informar número da compra.");
            }
            if (string.IsNullOrEmpty(compra.Fornecedor.Cnpj) == true)
            {
                throw new Exception("Informar um CNPJ.");
            }
            if (string.IsNullOrEmpty(Convert.ToString(compra.Funcionario.CodFuncionario)) == true)
            {
                throw new Exception("Informar código de funcionario");
            }

            new DadosCompra().AlterarCompra(compra);            
        }
        //Exeções para método de cadastrar compra
        public void CadastrarCompra(Compra compra)
        {
            if (compra == null)
            {
                throw new Exception("Informar os dados da compra.");
            }
            if (compra.NumCompra == 0)
            {
                throw new Exception("Informar o número da compra.");
            }
            if (compra.Fornecedor.Cnpj != null)
            {
                if (!new DadosFornecedor().ValidarCnpj(compra.Fornecedor.Cnpj))
                {
                    throw new Exception("CNPJ invalido!");
                }
            }
            if (compra.Funcionario.CodFuncionario == 0)
            {
                throw new Exception("Informar um funcionario válido");
            }
            if (compra.DataCompra == null)
            {
                throw new Exception("Informar uma data valida");
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(compra.NumCompra)) == true)
            {
                throw new Exception("Informar número da compra.");
            }
            if (string.IsNullOrEmpty(compra.Fornecedor.Cnpj) == true)
            {
                throw new Exception("Informar um CNPJ.");
            }
            if (string.IsNullOrEmpty(Convert.ToString(compra.Funcionario.CodFuncionario)) == true)
            {
                throw new Exception("Informar código de funcionario");
            }

            new DadosCompra().CadastrarCompra(compra);
        }
        //Exeções para método de cancelar compra
        public void CancelarCompra(Compra compra)
        {
            new DadosCompra().CancelarCompra(compra);
        }
        //Exeções para método de consultar compra
        public List<Compra> ConsultarCompra(Compra filtro)
        {
            if (string.IsNullOrEmpty(Convert.ToString(filtro.NumCompra)) == true)
            {
                throw new Exception("Digite o número da compra.");
            }
            else
            {                
                return new DadosCompra().ConsultarCompra(filtro);
            }
        }
        //Exeções para método de listar compra
        public List<Compra> ListarCompras()
        {
            return new DadosCompra().ListarCompras();
        }
        //Exeções para método de listar compras por num de compra
        public List<Compra_Produto> ListarProdutosCompras(Compra filtro)
        {
            return new DadosCompra().ListarProdutosCompras(filtro);
        }
    }
}
