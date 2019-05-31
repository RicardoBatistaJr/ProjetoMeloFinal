using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.conexao;
using Biblioteca.classesBasicas;
using System.Data.SqlClient;
using System.Data;

namespace Biblioteca.dados
{
    public class DadosFuncionario : Conexao
    {
        //Método insert cliente
        public void CadastrarFuncionario(Funcionario funcionario)
        {
            try
            {
                this.AbrirConexao();
                string sql = "insert into Funcionario (cpfFuncionario,senhaUsuario,funcaoFuncionario,nomeFuncionario) ";
                sql += "values(@cpfFuncionario,@senhaUsuario,@funcaoFuncionario,@nomeFuncionario)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                //cmd.Parameters.Add("codFuncionario", SqlDbType.Int);
                //cmd.Parameters["@codFuncionario"].Value = funcionario.CodFuncionario;

                cmd.Parameters.Add("@cpfFuncionario", SqlDbType.VarChar);
                cmd.Parameters["@cpfFuncionario"].Value = funcionario.CpfFuncionario;

                cmd.Parameters.Add("@senhaUsuario", SqlDbType.VarChar);
                cmd.Parameters["@senhaUsuario"].Value = funcionario.SenhaUsuario;

                cmd.Parameters.Add("@funcaoFuncionario", SqlDbType.VarChar);
                cmd.Parameters["@funcaoFuncionario"].Value = funcionario.FuncaoFuncionario;

                cmd.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar);
                cmd.Parameters["@nomeFuncionario"].Value = funcionario.NomeFuncionario;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir funcionario: " + ex.Message);
            }

        }
        //Método update Funcionario
        public void AlterarFuncionario (Funcionario funcionario)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " update Funcionario set cpfFuncionario = @cpfFuncionario, senhaUsuario = @senhaUsuario, funcaoFuncionario = @funcaoFuncionario, nomeFuncionario = @nomeFuncionario ";
                sql += " where cpfFuncionario = @cpfFuncionario";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                //cmd.Parameters.Add("codFuncionario", SqlDbType.Int);
                //cmd.Parameters["@codFuncionario"].Value = funcionario.CodFuncionario;

                cmd.Parameters.Add("@cpfFuncionario", SqlDbType.VarChar);
                cmd.Parameters["@cpfFuncionario"].Value = funcionario.CpfFuncionario;

                cmd.Parameters.Add("@senhaUsuario", SqlDbType.VarChar);
                cmd.Parameters["@senhaUsuario"].Value = funcionario.SenhaUsuario;

                cmd.Parameters.Add("@funcaoFuncionario", SqlDbType.VarChar);
                cmd.Parameters["@funcaoFuncionario"].Value = funcionario.FuncaoFuncionario;

                cmd.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar);
                cmd.Parameters["@nomeFuncionario"].Value = funcionario.NomeFuncionario;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro em alterar funcionario: " + ex.Message);
            }

        }
        //Método delete funcionario
        public void DeletarFuncionario (Funcionario funcionario)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " delete from funcionario ";
                sql += " where cpfFuncionario = @cpfFuncionario";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpfFuncionario", SqlDbType.VarChar);
                cmd.Parameters["@cpfFuncionario"].Value = funcionario.CpfFuncionario;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar funcionario: " + ex.Message);
            }
        }
        //Método select funcionario
        public List<Funcionario> ConsultarFuncionario (Funcionario filtro)
        {
            List<Funcionario> retorno = new List<Funcionario>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * FROM funcionario ";
                sql += " WHERE cpfFuncionario = @cpfFuncionario ";

                if (filtro.CpfFuncionario != null)
                {
                    sql += " and cpfFuncionario = @cpfFuncionario";
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.NomeFuncionario != null && filtro.NomeFuncionario.Trim().Equals("") == false)
                {
                    sql += " and nomeFuncionario like @nomeFuncionario";
                }
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                
                if (filtro.CpfFuncionario != null)
                {
                    cmd.Parameters.Add("@cpfFuncionario", SqlDbType.VarChar);
                    cmd.Parameters["@cpfFuncionario"].Value = filtro.CpfFuncionario;
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.NomeFuncionario != null && filtro.NomeFuncionario.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar);
                    cmd.Parameters["@nomeFuncionario"].Value = "%" + filtro.NomeFuncionario + "%";

                }
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    //acessando os valores das colunas do resultado
                    funcionario.CodFuncionario = DbReader.GetInt32(DbReader.GetOrdinal("codFuncionario"));
                    funcionario.CpfFuncionario = DbReader.GetString(DbReader.GetOrdinal("cpfFuncionario"));
                    funcionario.SenhaUsuario = DbReader.GetString(DbReader.GetOrdinal("senhaUsuario"));
                    funcionario.FuncaoFuncionario = DbReader.GetString(DbReader.GetOrdinal("funcaoFuncionario"));
                    funcionario.NomeFuncionario = DbReader.GetString(DbReader.GetOrdinal("nomeFuncionario"));
                    retorno.Add (funcionario);
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
                throw new Exception("Erro ao selecionar funcionario: " + ex.Message);
            }
            return retorno;
        }
        //Método select todos os funcionarios
        public List<Funcionario> ListarFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * from funcionario ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    //acessando os valores das colunas do resultado
                    funcionario.CodFuncionario = DbReader.GetInt32(DbReader.GetOrdinal("codFuncionario"));
                    funcionario.CpfFuncionario = DbReader.GetString(DbReader.GetOrdinal("cpfFuncionario"));
                    funcionario.SenhaUsuario = DbReader.GetString(DbReader.GetOrdinal("senhaUsuario"));
                    funcionario.FuncaoFuncionario = DbReader.GetString(DbReader.GetOrdinal("funcaoFuncionario"));
                    funcionario.NomeFuncionario = DbReader.GetString(DbReader.GetOrdinal("nomeFuncionario"));
                    funcionarios.Add(funcionario);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
                return funcionarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
        }
        //Método verificar se funcionario ja existe no banco
        public bool ExisteFuncionario (Funcionario funcionario)
        {
            bool existe;
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT cpfFuncionario FROM funcionario";
                sql += " WHERE cpfFuncionario = @cpfFuncionario ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@cpfFuncionario", funcionario.CpfFuncionario);
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
                throw new Exception("Erro ao verificar funcionario existente: " + ex.Message);
            }
        }
        //Método para velidar se o cpf foi digitado corretamente
        public bool ValidarCpfFuncionario(string cpf)
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
        public Funcionario Logar (Funcionario funcionario)
        {
            try
            {
                //string retorno = "";
                this.AbrirConexao();
                Funcionario fun = null;

                //instrucao a ser executada
                string sql = "SELECT cpfFuncionario,senhaUsuario,funcaoFuncionario FROM Funcionario WHERE cpfFuncionario = '" + funcionario.CpfFuncionario + "'";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    fun = new Funcionario();
                    fun.CpfFuncionario = DbReader.GetString(DbReader.GetOrdinal("cpfFuncionario"));
                    fun.SenhaUsuario = DbReader.GetString(DbReader.GetOrdinal("senhaUsuario"));
                    fun.FuncaoFuncionario = DbReader.GetString(DbReader.GetOrdinal("funcaoFuncionario"));
                }

                return fun;
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao logar funcionario: " + ex.Message);
            }
        }

    }
}
