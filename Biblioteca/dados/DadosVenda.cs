using Biblioteca.conexao;
using Biblioteca.classesBasicas;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Collections.Generic;

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

                cmd.Parameters.Add("@numVenda", SqlDbType.Int);
                cmd.Parameters["@numVenda"].Value = venda.NumVenda;

                cmd.Parameters.Add("@dataVenda", SqlDbType.Date);
                cmd.Parameters["@dataVenda"].Value = venda.DataVenda;

                cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                cmd.Parameters["@cpfCliente"].Value = venda.Cliente.CpfCliente;

                cmd.Parameters.Add("@codFuncionario", SqlDbType.Int);
                cmd.Parameters["@codFuncionario"].Value = venda.Funcionario.CodFuncionario;

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
                string sql = "update venda set numVenda = @numVenda, dataVenda = @dataVenda, cpfCliente = @cpfCliente, codFuncionario = @codFuncionario where numVenda = @numVenda";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@numVenda", SqlDbType.Int);
                cmd.Parameters["@numVenda"].Value = venda.NumVenda;

                cmd.Parameters.Add("@dataVenda", SqlDbType.Date);
                cmd.Parameters["@dataVenda"].Value = venda.DataVenda;

                cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                cmd.Parameters["@cpfCliente"].Value = venda.Cliente.CpfCliente;

                cmd.Parameters.Add("@codFuncionario", SqlDbType.Int);
                cmd.Parameters["@codFuncionario"].Value = venda.Funcionario.CodFuncionario;

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

                cmd.Parameters.Add("@numVenda", SqlDbType.Int);
                cmd.Parameters["@numVenda"].Value = venda.NumVenda;

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
        public List<VendaProduto> ListarVendas()
        {
            List<VendaProduto> vendas = new List<VendaProduto>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "select venda.numVenda, venda.dataVenda, cliente.cpfCliente, funcionario.nomeFuncionario, venda_produto.qtd, venda_produto.preco, produto.nomeProduto, produto.precoProduto";
                sql += "from venda";
                sql += "inner join cliente on  venda.cpfCliente = cliente.cpfCliente";
                sql += "inner join funcionario on venda.codFuncionario = funcionario.codFuncionario";
                sql += "inner join  venda_produto on venda.numVenda = venda_produto.numVenda";
                sql += "inner join produto on venda_produto.codProduto = produto.codProduto";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    VendaProduto vendaP = new VendaProduto();
                    //acessando os valores das colunas do resultado
                    vendaP.Venda.NumVenda = DbReader.GetInt32(DbReader.GetOrdinal("numVenda"));
                    vendaP.Venda.DataVenda = DbReader.GetDateTime(DbReader.GetOrdinal("dataVenda"));
                    vendaP.Venda.Cliente.CpfCliente= DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    vendaP.Venda.Funcionario.NomeFuncionario = DbReader.GetString(DbReader.GetOrdinal("nomeFuncionario"));
                    vendaP.Qtd = DbReader.GetInt32(DbReader.GetOrdinal("qtd"));
                    vendaP.Preco = DbReader.GetFloat(DbReader.GetOrdinal("preco"));
                    vendaP.Produto.NomeProduto = DbReader.GetString(DbReader.GetOrdinal("nomeProduto"));
                    vendaP.Produto.PrecoProduto = DbReader.GetFloat(DbReader.GetOrdinal("precoproduto"));
                    vendas.Add(vendaP);
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
        public List<VendaProduto> ListarVenda(Venda venda)
        {
            List<VendaProduto> vendas = new List<VendaProduto>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "select venda.numVenda, venda.dataVenda, cliente.cpfCliente, funcionario.nomeFuncionario, venda_produto.qtd, venda_produto.preco, produto.nomeProduto, produto.precoProduto";
                sql += "from venda";
                sql += "inner join cliente on  venda.cpfCliente = cliente.cpfCliente";
                sql += "inner join funcionario on venda.codFuncionario = funcionario.codFuncionario";
                sql += "inner join  venda_produto on venda.numVenda = venda_produto.numVenda";
                sql += "inner join produto on venda_produto.codProduto = produto.codProduto";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@numVenda", venda.NumVenda);
                cmd.Parameters.AddWithValue("@cpfCliente", venda.Cliente.CpfCliente);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    VendaProduto vendaP = new VendaProduto();
                    //acessando os valores das colunas do resultado
                    vendaP.Venda.NumVenda = DbReader.GetInt32(DbReader.GetOrdinal("numVenda"));
                    vendaP.Venda.DataVenda = DbReader.GetDateTime(DbReader.GetOrdinal("dataVenda"));
                    vendaP.Venda.Cliente.CpfCliente = DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    vendaP.Venda.Funcionario.NomeFuncionario = DbReader.GetString(DbReader.GetOrdinal("nomeFuncionario"));
                    vendaP.Qtd = DbReader.GetInt32(DbReader.GetOrdinal("qtd"));
                    vendaP.Preco = DbReader.GetFloat(DbReader.GetOrdinal("preco"));
                    vendaP.Produto.NomeProduto = DbReader.GetString(DbReader.GetOrdinal("nomeProduto"));
                    vendaP.Produto.PrecoProduto = DbReader.GetFloat(DbReader.GetOrdinal("precoproduto"));
                    vendas.Add(vendaP);
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
                cmd.Parameters.AddWithValue("@codFuncionario", venda.Funcionario.CodFuncionario);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Venda vendass = new Venda();
                    //acessando os valores das colunas do resultado
                    vendass.NumVenda = DbReader.GetInt32(DbReader.GetOrdinal("numVenda"));
                    vendass.DataVenda = DbReader.GetDateTime(DbReader.GetOrdinal("dataVenda"));
                    vendass.Cliente.CpfCliente = DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    vendass.Funcionario.CodFuncionario = DbReader.GetInt32(DbReader.GetOrdinal("codFuncionario"));
                    vendas.Add(vendass);
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
        /*Método listar vendas canceladas
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
        }*/
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
                cmd.Parameters.AddWithValue("@numVenda", venda.NumVenda);
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
                
           