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
    class DadosCompra : Conexao, ICompraDados
    {       
        //Método para Alterar a Compra
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
                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }
        //Método para Cadastrar a Compra
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

                cmd.Parameters.Add("codFuncionario", SqlDbType.Int);
                cmd.Parameters["@codFuncionario"].Value = compra.Funcionario.CodFuncionario;

                cmd.Parameters.Add("cnpj", SqlDbType.VarChar);
                cmd.Parameters["@cnpj"].Value = compra.Fornecedor.Cnpj;
               
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

        public void CancelarCompra(Compra compra)
        {
            throw new NotImplementedException();
        }
        //Método para consultar uma compra
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
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
            return retorno;
        }

        public List<Compra> ListarCompras(Compra filtro)
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
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
        }
    }
    
}
