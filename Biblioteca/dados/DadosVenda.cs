﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.conexao;
using Biblioteca.classesBasicas;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Biblioteca.dados
{
    // ALTERAR NOMES DAS CONEXOES E TODOS OS TEXTOS


    public class DadosVenda : Conexao
    {
        //Método insert cliente
        public void CadastrarVenda(Venda venda)

        {
            try
            {
                this.AbrirConexao();
                string sql = "insert into Venda (numVenda,dataVenda,cpfCliente,codFuncionario) ";
                sql += "values(@numVenda,@dataVenda,@cpfCliente,@codFuncionario)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@numVenda", SqlDbType.Integer);
                cmd.Parameters["@numVenda"].Value = venda.numVenda;

                cmd.Parameters.Add("@dataVenda", SqlDbType.Date);
                cmd.Parameters["@dataVenda"].Value = cliente.NomeCliente;

                cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                cmd.Parameters["@cpfCliente"].Value = cliente.EmailCliente;

                cmd.Parameters.Add("@codFuncionario", SqlDbType.Int);
                cmd.Parameters["@codFuncionario"].Value = cliente.TelCliente;

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
        public void AlterarVenda(Venda venda)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "update venda set ";
                sql += " numVenda = @numVenda ";
                sql += " dataVenda = @dataVenda ";
                sql += " cpfCliente = @cpfCliente ";
                sql += " codFuncionario = @codFuncionario";
                sql += " where numVenda = @numVenda";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@numVenda", SqlDbType.Integer);
                cmd.Parameters["@numVenda"].Value = venda.numVenda;

                cmd.Parameters.Add("@dataVenda", SqlDbType.Date);
                cmd.Parameters["@dataVenda"].Value = cliente.NomeCliente;

                cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                cmd.Parameters["@cpfCliente"].Value = cliente.EmailCliente;

                cmd.Parameters.Add("@codFuncionario", SqlDbType.Int);
                cmd.Parameters["@codFuncionario"].Value = cliente.TelCliente;

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
        //Método delete venda
        public void DeletarVenda(Venda venda)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " delete from venda ";
                sql += " where numVenda = @numVenda";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                cmd.Parameters["@cpfCliente"].Value = cliente.CpfCliente;

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
 
        //Método select todos os clientes
        public List<Venda> ListarVendas()
        {
            List<Venda> vendas = new List<Venda>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * from venda ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Venda vendas = new Venda();
                    //acessando os valores das colunas do resultado
                    vendas.numVenda = DbReader.GetString(DbReader.GetOrdinal("numVenda"));
                    vendas.dataVenda = DbReader.GetDateTime(DbReader.GetOrdinal("dataVenda"));
                    vendas.Cliente.cpfCliente= DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    vendas.Funcionario.codFuncionario = DbReader.GetInt32(DbReader.GetOrdinal("codFuncionario"));
                    vendas.Add(venda);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
                return vendas;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
        }
        //Método listar vendas de um determinado cliente
        public List<Venda> ListarVendaAtendente(Venda venda)
        {
            List<Venda> vendas = new List<Venda>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * from vendas ";
                sql += "WHERE codFuncionario = @codFuncionario";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@codFuncionario", venda.Funcionario.codFuncionario);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Venda venda = new Venda();
                    //acessando os valores das colunas do resultado
                    venda.NumVenda = DbReader.GetInt32(DbReader.GetOrdinal("numVenda"));
                    venda.DataVenda = DbReader.GetDateTime(DbReader.GetOrdinal("dataVenda"));
                    venda.Cliente.CpfCliente = DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    venda.Funcionario.CodFuncionario = DbReader.GetInt32(DbReader.GetOrdinal("codFuncionario"));
                    vendas.Add(venda);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
                return vendas;


            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
        }
        //Método listar vendas canceladas
        public List<Venda> ListarVendaCanceladas(Venda venda)
        {
            List<Venda> vendas = new List<Venda>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * from vendas ";
                sql += "WHERE cpfCliente = @cpfCliente";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@cpfCliente", cliente.CpfCliente);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Venda venda = new Venda();
                    //acessando os valores das colunas do resultado
                    venda.NumVenda = DbReader.GetInt32(DbReader.GetOrdinal("numVenda"));
                    venda.DataVenda = DbReader.GetDateTime(DbReader.GetOrdinal("dataVenda"));
                    venda.Cliente.CpfCliente = DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    venda.Funcionario.CodFuncionario = DbReader.GetInt32(DbReader.GetOrdinal("codFuncionario"));
                    vendas.Add(venda);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
                return vendas;


            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
        }
        //Método verificar se cliente ja existe no banco
        public bool VerificarDuplicidadeVenda(Venda venda)
        {
            bool existe;
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT numVenda FROM venda";
                sql += " WHERE numVenda = @numVenda ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@numVenda", venda.numVenda);
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
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
        }
    }
}
                
           