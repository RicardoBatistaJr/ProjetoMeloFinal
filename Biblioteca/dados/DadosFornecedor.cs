using Biblioteca.classesBasicas;
using Biblioteca.conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaPopTec_1._0.Dados
{
    class DadosFornecedor : Conexao, IFornecedorDados
    {
        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " update Fornecedor set ";
                sql += " nomeFornecedor = @nomeFornecedor ";                
                sql += " where cnpj = @cnpj ";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cnpj", SqlDbType.VarChar);
                cmd.Parameters["@cnpj"].Value = fornecedor.Cnpj;

                cmd.Parameters.Add("@nomeFornecedor", SqlDbType.VarChar);
                cmd.Parameters["@nomeFornecedor"].Value = fornecedor.NomeFornecedor;                            

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

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                this.AbrirConexao();
                string sql = "insert into Fornecedor (cnpj,nomeFornecedor)";
                sql += "values(@cnpj,@nomeFornecedor)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cnpj", SqlDbType.VarChar);
                cmd.Parameters["@cnpj"].Value = fornecedor.Cnpj;

                cmd.Parameters.Add("@nomeFornecedor", SqlDbType.VarChar);
                cmd.Parameters["@nomeFornecedor"].Value = fornecedor.NomeFornecedor;
                    
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

        public List<Fornecedor> ListarFornecedor(Fornecedor filtro)
        {
            List<Fornecedor> listarFornecedores = new List<Fornecedor>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * from Fornecedor ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();
                    //acessando os valores das colunas do resultado
                    fornecedor.Cnpj = DbReader.GetString(DbReader.GetOrdinal("cnpj"));
                    fornecedor.NomeFornecedor = DbReader.GetString(DbReader.GetOrdinal("nomeFornecedor"));                    
                    listarFornecedores.Add(fornecedor);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
                return listarFornecedores;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
        }

        public void VerificarDuplicidadeFornecedor(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }
    }       
}
