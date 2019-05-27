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
    public class DadosCliente : Conexao
    {
        //Método insert cliente
        public void CadastrarCliente(Cliente cliente)
        {
           try
            {
                this.AbrirConexao();
                string sql = "insert into Cliente (cpfCliente,nomeCliente,emailCliente,telCliente) ";
                sql += "values(@cpfCliente,@nomeCliente,@emailCliente,@telCliente)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                cmd.Parameters["@cpfCliente"].Value = cliente.CpfCliente;

                cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar);
                cmd.Parameters["@nomeCliente"].Value = cliente.NomeCliente;

                cmd.Parameters.Add("@emailCliente", SqlDbType.VarChar);
                cmd.Parameters["@emailCliente"].Value = cliente.EmailCliente;

                cmd.Parameters.Add("@telCliente", SqlDbType.VarChar);
                cmd.Parameters["@telCliente"].Value = cliente.TelCliente;

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
        //Método update cliente
        public void AlterarCliente(Cliente cliente)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " update cliente set cpfCliente = @cpfCliente, nomeCliente = @nomeCliente,emailCliente = @emailCliente, telCliente = @telCliente where cpfCliente = @cpfCliente";

                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                cmd.Parameters["@cpfCliente"].Value = cliente.CpfCliente;

                cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar);
                cmd.Parameters["@nomeCliente"].Value = cliente.NomeCliente;

                cmd.Parameters.Add("@emailCliente", SqlDbType.VarChar);
                cmd.Parameters["@emailCliente"].Value = cliente.EmailCliente;

                cmd.Parameters.Add("@telCliente", SqlDbType.VarChar);
                cmd.Parameters["@telCliente"].Value = cliente.TelCliente;

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
        //Método delete cliente
        public void DeletarCliente (Cliente cliente)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " delete from cliente ";
                sql += " where cpfCliente = @cpfCliente";
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
        //Método select cliente
        public List<Cliente> ConsultarCliente (Cliente filtro)
        {
            List<Cliente> retorno = new List<Cliente>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT cpfCliente,nomeCliente,emailCliente,telCliente ";
                sql += " FROM cliente ";
                sql += " WHERE cpfCliente = cpfCliente ";
                //se for passado um cpf válido, este cpf entrará como critério de filtro
                if (filtro.CpfCliente != null)
                {
                    sql += " and cpfCliente = @cpfCliente";
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.NomeCliente != null && filtro.NomeCliente.Trim().Equals("") == false)
                {
                    sql += " and nomeCliente like @nomeCliente";
                }
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
                if (filtro.CpfCliente != null)
                {
                    cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                    cmd.Parameters["@cpfCliente"].Value = filtro.CpfCliente;
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.NomeCliente != null && filtro.NomeCliente.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar);
                    cmd.Parameters["@nomeCliente"].Value = "%" + filtro.NomeCliente + "%";

                }
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Cliente cliente = new Cliente();
                    //acessando os valores das colunas do resultado
                    cliente.CpfCliente = DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    cliente.NomeCliente = DbReader.GetString(DbReader.GetOrdinal("nomeCliente"));
                    cliente.EmailCliente = DbReader.GetString(DbReader.GetOrdinal("emailCliente"));
                    cliente.TelCliente = DbReader.GetString(DbReader.GetOrdinal("telCliente"));
                    retorno.Add(cliente);
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
        //Método select todos os clientes
        public List<Cliente> ListarClientes ()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * from cliente ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);               
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Cliente cliente = new Cliente();               
                    //acessando os valores das colunas do resultado
                    cliente.CpfCliente = DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    cliente.NomeCliente = DbReader.GetString(DbReader.GetOrdinal("nomeCliente"));
                    cliente.EmailCliente = DbReader.GetString(DbReader.GetOrdinal("emailCliente"));
                    cliente.TelCliente = DbReader.GetString(DbReader.GetOrdinal("telCliente"));
                    clientes.Add(cliente);                  
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
        }
        //Método listar vendas de um determinado cliente
        public List<VendaProduto> ListarVendaCliente (Cliente cliente)
        {
            List<VendaProduto> vendas = new List<VendaProduto>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "select cliente.cpfCliente, venda_produto.numVenda, venda.dataVenda, produto.nomeProduto, venda_produto.qtd, venda_produto.preco";
                sql += "from cliente";
                sql += "inner join venda on cliente.cpfCliente = venda.cpfCliente";
                sql += "inner join venda_produto on venda.numVenda = venda_produto.numVenda";
                sql += "inner join produto on venda_produto.codProduto = produto.codProduto";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@cpfCliente", cliente.CpfCliente);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    VendaProduto vendaP = new VendaProduto();
                    //acessando os valores das colunas do resultado
                    vendaP.Venda.Cliente.CpfCliente = DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    vendaP.Venda.NumVenda = DbReader.GetInt32(DbReader.GetOrdinal("numVenda"));
                    vendaP.Venda.DataVenda = DbReader.GetDateTime(DbReader.GetOrdinal("dataVenda"));
                    vendaP.Produto.NomeProduto = DbReader.GetString(DbReader.GetOrdinal("nomeProduto"));
                    vendaP.Qtd = DbReader.GetInt32(DbReader.GetOrdinal("qtd"));
                    vendaP.Preco = DbReader.GetFloat(DbReader.GetOrdinal("preco"));
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
                throw new Exception("Erro ao listar as vendas: " + ex.Message);
            }
        }
        //Método verificar se cliente ja existe no banco
        public bool VerificarDuplicidadeCliente (Cliente cliente)
        {
            bool existe;
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT cpfCliente FROM cliente";
                sql += " WHERE cpfCliente = @cpfCliente ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@cpfCliente", cliente.CpfCliente);
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
        //Método para velidar se o cpf foi digitado corretamente
        public bool ValidaCpfCliente(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }
            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];               
            }
            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);

        }
    }
}
