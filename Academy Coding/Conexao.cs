using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Academy_Coding
{
    class Conexao
    {
        public Conexao() { }
        public SqlConnection Connection(string servidor, string dataBase)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["server"] = servidor;
            builder["Truested_Connection"] = true;     
            builder["Initial Catalog"] = dataBase;
    
            var conn = new SqlConnection(builder.ConnectionString);
            return conn;
         }
        public SqlConnection Connection(string servidor, string dataBase, string senha, string usuario)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["server"] = servidor;
            builder["Truested_Connection"] = false;
            builder["Initial Catalog"] = dataBase;
            builder["User id"] = usuario;
            builder["password"] = senha;

            var conn = new SqlConnection(builder.ConnectionString);
            return conn;

          
           
        }

    }
}
