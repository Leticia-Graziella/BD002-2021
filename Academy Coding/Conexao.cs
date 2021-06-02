using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AcademyCoding
{
    class Conexao
    {
        public SqlConnection SqlConnection;
        public string _connectionString;
        public Conexao() { }

        public void Connection(string servidor, string dataBase)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["server"] = servidor;
            builder["trusted_connection"] = true;     
            builder["Initial Catalog"] = dataBase;
    
            this.SqlConnection = new SqlConnection(builder.ConnectionString);
            this._connectionString = builder.ConnectionString;
            
         }
        public void Connection(string servidor, string dataBase, string senha, string usuario)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["server"] = servidor;
            builder["trusted_connection"] = false;
            builder["Initial Catalog"] = dataBase;
            builder["User id"] = usuario;
            builder["password"] = senha;
            
            this.SqlConnection = new SqlConnection(builder.ConnectionString);
            this._connectionString = builder.ConnectionString;
            
          
           
        }

    }
}
