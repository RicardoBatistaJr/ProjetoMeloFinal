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
    public class DadosFornecedor : Conexao
    {
        //Método para alterar fornecedor
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
                throw new Exception("Erro ao alterar fornecedor " + ex.Message);
            }
        }
        //Método para cadastrar fornecedor
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
        //Método para listar fornecedor
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
        //Método para verificar duplicidade de fornecedor
        public bool VerificarDuplicidadeFornecedor(Fornecedor fornecedor)
        {
            bool existe;
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT cnpj FROM fornecedor";
                sql += " WHERE cnpj = @cnpj ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@numCompra", fornecedor.Cnpj);
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
                throw new Exception("Erro ao verificar duplicidade" + ex.Message);
            }
        }
        //Método para validar cnpj
        public bool ValidarCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

    }       
}
