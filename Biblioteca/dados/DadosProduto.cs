using Biblioteca.conexao;
using Biblioteca.classesBasicas;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Collections.Generic;

namespace Biblioteca.dados
{
    class DadosProduto : Conexao
    {
        public void CadastrarProduto(Produto produto)
        {
            try
            {
                this.AbrirConexao();
                string sql = "insert into Produto (saldoProduto, dataFabricacao, nomeProduto, preçoProduto, statusProduto) ";
                sql += "values(@saldoProduto, @dataFabricacao, @nomeProduto, @preçoProduto, @statusProduto)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@saldoProduto", SqlDbType.Float);
                cmd.Parameters["@saldoProduto"].Value = produto.SaldoProduto;

                cmd.Parameters.Add("@dataFabricacao", SqlDbType.Date);
                cmd.Parameters["@dataFabricacao"].Value = produto.SaldoProduto;

                cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar);
                cmd.Parameters["@nomeProduto"].Value = produto.NomeProduto;

                cmd.Parameters.Add("@preçoProduto", SqlDbType.Float);
                cmd.Parameters["@preçoProduto"].Value = produto.PrecoProduto;

                cmd.Parameters.Add("@statusProduto", SqlDbType.Int);
                cmd.Parameters["@statusProduto"].Value = produto.StatusProduto;

                string oi = sql;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir " + ex.Message);
            }

        }

        public void AlterarProduto(Produto produto)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "update produto set saldoProduto = @saldoProduto, dataFabricacao = @dataFabricacao, nomeProduto = @nomeProduto, preçoProduto = @preçoProduto, statusProduto = @statusProduto where codProduto = @codProduto";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@saldoProduto", SqlDbType.Float);
                cmd.Parameters["@saldoProduto"].Value = produto.SaldoProduto;

                cmd.Parameters.Add("@dataFabricacao", SqlDbType.Date);
                cmd.Parameters["@dataFabricacao"].Value = produto.DataFabricacao;

                cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar);
                cmd.Parameters["@nomeProduto"].Value = produto.NomeProduto;

                cmd.Parameters.Add("@preçoProduto", SqlDbType.Float);
                cmd.Parameters["@preçoProduto"].Value = produto.PrecoProduto;

                cmd.Parameters.Add("@statusProduto", SqlDbType.Int);
                cmd.Parameters["@statusProduto"].Value = produto.StatusProduto;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Alterar e inserir " + ex.Message);
            }
        }

        public void DeletarProduto(Produto produto)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " delete from produto ";
                sql += " where codProduto = @codProduto";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("codProduto", SqlDbType.Int);
                cmd.Parameters["@codProduto"].Value = produto.CodProduto;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }

        public void DesativarProduto(Produto produto)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " update produto set statusProduto = 0 where codProduto = @codProduto ";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("codProduto", SqlDbType.Int);
                cmd.Parameters["@codProduto"].Value = produto.CodProduto;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }

        public List<Produto> ConsultarProduto(Produto filtro)
        {
            List<Produto> retorno = new List<Produto>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT codProduto, saldoProduto, dataFabricacao, nomeProduto, precoProduto, statusProduto";
                sql += " FROM produto ";
                sql += " WHERE codProduto = codProduto ";
                //se for passado um cpf válido, este cpf entrará como critério de filtro
                if (filtro.CodProduto != 0)
                {
                    sql += " and codProduto = @codProduto";
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.NomeProduto != null && filtro.NomeProduto.Trim().Equals("") == false)
                {
                    sql += " and nomeProduto like @nomeProduto";
                }
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
                if (filtro.CodProduto != 0)
                {
                    cmd.Parameters.Add("@codProduto", SqlDbType.Int);
                    cmd.Parameters["@codProduto"].Value = filtro.CodProduto;
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.NomeProduto != null && filtro.NomeProduto.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar);
                    cmd.Parameters["@nomeProduto"].Value = "%" + filtro.NomeProduto + "%";

                }
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Produto produto = new Produto();
                    //acessando os valores das colunas do resultado
                    produto.CodProduto = DbReader.GetInt32(DbReader.GetOrdinal("codProduto"));
                    produto.SaldoProduto = DbReader.GetFloat(DbReader.GetOrdinal("saldoProduto"));
                    produto.DataFabricacao = DbReader.GetDateTime(DbReader.GetOrdinal("dataFabricacao"));
                    produto.NomeProduto = DbReader.GetString(DbReader.GetOrdinal("nomeProduto"));
                    produto.PrecoProduto = DbReader.GetFloat(DbReader.GetOrdinal("precoProduto"));
                    produto.StatusProduto = DbReader.GetString(DbReader.GetOrdinal("statusProduto"));
                    retorno.Add(produto);
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
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
            return retorno;
        }

        //FALTA IMPLEMENTAÇÃO
        public void TrocarProduto()
        {
            ////////////////////////////////// [FALTA IMPLEMENTAÇÃO] ////////////////////////////////
        }

        public List<Produto> ListarProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * from produto ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Produto produto = new Produto();
                    //acessando os valores das colunas do resultado
                    //insert into Produto(saldoProduto, dataFabricacao, nomeProduto, preçoProduto, statusProduto)
                    produto.CodProduto = DbReader.GetInt32(DbReader.GetOrdinal("codProduto"));
                    produto.SaldoProduto = DbReader.GetFloat(DbReader.GetOrdinal("saldoProduto"));
                    produto.DataFabricacao = DbReader.GetDateTime(DbReader.GetOrdinal("dataFabricacao"));
                    produto.NomeProduto = DbReader.GetString(DbReader.GetOrdinal("nomeProduto"));
                    produto.PrecoProduto = DbReader.GetFloat(DbReader.GetOrdinal("precoProduto"));
                    produto.StatusProduto = DbReader.GetString(DbReader.GetOrdinal("statusProduto"));
                    produtos.Add(produto);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
        }

        public bool VerificarDuplicidadeProduto(Produto produto)
        {
            bool existe;
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT codProduto FROM produto";
                sql += " WHERE codProduto = @codProduto ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@codProduto", produto.CodProduto);
                SqlDataReader DbReader = cmd.ExecuteReader();
                if (DbReader.Read())
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
                return existe;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar " + ex.Message);
            }
        }


    }
}
