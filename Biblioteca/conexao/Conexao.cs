using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.conexao
{
    public class Conexao
    {
        public SqlConnection sqlConn;
        private const string local = "Localhost";
        private const string banco_de_dados = "FarmaPopTec";
        private const string usuario = "FarmaPopTec";
        private const string senha = "123456";

        //string de conexão obtida para o sql sever
        string connectionStringSqlServer = @"Data Source=" + local + ";Initial Catalog=" + banco_de_dados + ";UId=" + usuario + ";Password=" + senha + ";";

        public void AbrirConexao()
        {
            //iniciando uma conexão com o sql server, utilizando os parâmetros da string de conexão
            this.sqlConn = new SqlConnection(connectionStringSqlServer);
            //abrindo a conexão com a base de dados
            this.sqlConn.Open();
        }
        public void FecharConexao()
        {
            //fechando a conexao com a base de dados
            this.sqlConn.Close();
            //liberando a conexao da memoria
            this.sqlConn.Dispose();
        }

    }
}
