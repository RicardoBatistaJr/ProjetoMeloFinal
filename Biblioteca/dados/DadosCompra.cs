using Biblioteca.conexao;
using Biblioteca.classesBasicas;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Collections.Generic;

namespace FarmaPopTec_1._0.Dados
{
    public class DadosCompra : Conexao
    {
        //Método para alterar a compra
        public void AlterarCompra(Compra compra)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " update Compra set ";                
                sql += " dataCompra = @dataCompra ";
                sql += " codFuncionario = @codFuncionario";
                sql += " cnpj = @cnpj ";
                sql += " where numCompra = @numCompra ";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@numCompra", SqlDbType.Int);
                cmd.Parameters["@numCompra"].Value = compra.NumCompra;

                cmd.Parameters.Add("@dataCompra", SqlDbType.DateTime);
                cmd.Parameters["@dataCompra"].Value = compra.DataCompra;

                cmd.Parameters.Add("codFuncionario", SqlDbType.Int);
                cmd.Parameters["@codFuncionario"].Value = compra.Funcionario.CodFuncionario;

                cmd.Parameters.Add("cnpj", SqlDbType.VarChar);
                cmd.Parameters["@cnpj"].Value = compra.Fornecedor.Cnpj;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar compra " + ex.Message);
            }
        }
        //Método para cadastrar a compra
        public void CadastrarCompra(Compra compra)
        {
            try
            {
                this.AbrirConexao();
                string sql = "insert into Compra (numCompra,dataCompra,codFuncionario,cnpj) ";
                sql += "values(@numCompra,@dataCompra,@codFuncionario,@cnpj)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@numCompra", SqlDbType.Int);
                cmd.Parameters["@numCompra"].Value = compra.NumCompra;

                cmd.Parameters.Add("@dataCompra", SqlDbType.DateTime);
                cmd.Parameters["@dataCompra"].Value = compra.DataCompra;

                cmd.Parameters.Add("@codFuncionario", SqlDbType.Int);
                cmd.Parameters["@codFuncionario"].Value = compra.Funcionario.CodFuncionario;

                cmd.Parameters.Add("@cnpj", SqlDbType.VarChar);
                cmd.Parameters["@cnpj"].Value = compra.Fornecedor.Cnpj;               

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //Método complementar para inserir dados na coleção
                foreach (Compra_Produto compra_Produto in compra.Colecao)
                {
                    //insert na tabela Compra_Produto
                    string sqlCompraProduto = "insert into compra_Produto (qtdCompra,valorTotal,codProduto,nrCompra,validade) values(@qtdCompra,@valorTotal,@codProduto,@nrCompra,@validade";
                    
                    //instrucao a ser executada
                    SqlCommand cmdCompraProduto = new SqlCommand(sqlCompraProduto, this.sqlConn);


                    cmdCompraProduto.Parameters.Add("@qtdCompra", SqlDbType.Int);
                    cmdCompraProduto.Parameters["@qtdCompra"].Value = compra_Produto.QtdCompra;

                    cmdCompraProduto.Parameters.Add("@valorTotal", SqlDbType.Float);
                    cmdCompraProduto.Parameters["@valorTotal"].Value = compra_Produto.ValorTotal;

                    cmdCompraProduto.Parameters.Add("@codProduto", SqlDbType.Int);
                    cmdCompraProduto.Parameters["@codProduto"].Value = compra_Produto.Produto.CodProduto;

                    cmdCompraProduto.Parameters.Add("@nrCompra", SqlDbType.Int);
                    cmdCompraProduto.Parameters["@nrCompra"].Value = compra_Produto.Compra.NumCompra;

                    cmdCompraProduto.Parameters.Add("@validade", SqlDbType.Date);
                    cmdCompraProduto.Parameters["@validade"].Value = compra_Produto.Validade;

                    //executando a instrucao 
                    cmdCompraProduto.ExecuteNonQuery();
                    //liberando a memoria 
                    cmdCompraProduto.Dispose();
                }

                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar " + ex.Message);
            }
        }
        //Método para cancelar a compra
        public void CancelarCompra(Compra compra)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " delete from compra ";
                sql += " where numCompra = @numCompra";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@numCompra", SqlDbType.Int);
                cmd.Parameters["@numCompra"].Value = compra.NumCompra;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar compra" + ex.Message);
            }
        }
        //Método para consultar compra
        public List<Compra> ConsultarCompra(Compra filtro)
        {
            List<Compra> retorno = new List<Compra>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT numCompra,dataCompra,codFuncionario,cnpj";
                sql += " FROM compra ";
                sql += " WHERE numCompra = numCompra ";
                
                //se for passado um numero de compra válido, este numero entrará como critério de filtro
                if (filtro.NumCompra != 0)
                {
                    sql += " and numCompra = @numCompra";
                }                
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //se foi passada uma data válida, esta data entrará como critério de filtro
                if (filtro.DataCompra != null)
                {
                    cmd.Parameters.Add("@dataCompra", SqlDbType.DateTime);
                    cmd.Parameters["@dataCompra"].Value = filtro.DataCompra;
                }
                //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
                if (filtro.Funcionario.CodFuncionario != 0)
                {
                    cmd.Parameters.Add("@codFuncionario", SqlDbType.Int);
                    cmd.Parameters["@codFuncionario"].Value = filtro.Funcionario.CodFuncionario;
                }
                //se foi passada um cnpj válido, o mesmo entrará como critério de filtro
                if (filtro.Fornecedor.Cnpj != null)
                {
                    cmd.Parameters.Add("@cnpj", SqlDbType.VarChar);
                    cmd.Parameters["@cnpj"].Value = filtro.Fornecedor.Cnpj;
                }
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Compra compra = new Compra();
                    //acessando os valores das colunas do resultado
                    compra.NumCompra = DbReader.GetInt16(DbReader.GetOrdinal("numCompra"));
                    compra.DataCompra = DbReader.GetDateTime(DbReader.GetOrdinal("dataCompra"));
                    compra.Funcionario.CodFuncionario = DbReader.GetInt16(DbReader.GetOrdinal("codFuncionario"));
                    compra.Fornecedor.Cnpj = DbReader.GetString(DbReader.GetOrdinal("cnpj"));
                    retorno.Add(compra);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar compra " + ex.Message);
            }
            return retorno;
        }
        //Método para listar compra
        public List<Compra> ListarCompras()
        {
            List<Compra> listarcompras = new List<Compra>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * from Compra ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Compra compra = new Compra();
                    //acessando os valores das colunas do resultado 
                    compra.NumCompra = DbReader.GetInt16(DbReader.GetOrdinal("numCompra"));
                    compra.DataCompra = DbReader.GetDateTime(DbReader.GetOrdinal("dataCompra"));
                    compra.Funcionario.CodFuncionario = DbReader.GetInt16(DbReader.GetOrdinal("codFuncionario"));
                    compra.Fornecedor.Cnpj = DbReader.GetString(DbReader.GetOrdinal("cnpj"));
                    listarcompras.Add(compra);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
                return listarcompras;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar compra " + ex.Message);
            }
        }
        //Método para Listar os produtos da Compra
        public List<Compra_Produto> ListarProdutosCompras(Compra compra)
        {
            List<Compra_Produto> listarcompras = new List<Compra_Produto>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * from Compra_produto where numcompra = @numcompra ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta 
                while (DbReader.Read())
                {
                    Compra_Produto compraProd = new Compra_Produto();
                    //acessando os valores das colunas do resultado 
                    compraProd.Compra.NumCompra = DbReader.GetInt16(DbReader.GetOrdinal("numCompra"));
                    compraProd.QtdCompra = DbReader.GetInt16(DbReader.GetOrdinal("QtdCompra"));
                    compraProd.Produto.CodProduto = DbReader.GetInt16(DbReader.GetOrdinal("codProduto"));
                    compraProd.Produto.PrecoProduto = DbReader.GetFloat(DbReader.GetOrdinal("PrecoProduto"));
                    compraProd.Validade = DbReader.GetDateTime(DbReader.GetOrdinal("validade"));
                    compraProd.ValorTotal = DbReader.GetFloat(DbReader.GetOrdinal("ValorTotal"));
                    listarcompras.Add(compraProd);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
                return listarcompras;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar compra " + ex.Message);
            }
        }
    }
    
}
