using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Academy_Coding
{
    class ConexaoTarget
    {


        public SqlConnection SqlConnection;
        public string connectionString;
        public ConexaoTarget() { }

        public void Connection(string servidor, string dataBase)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["server"] = servidor;
            builder["trusted_connection"] = true;
            builder["Initial Catalog"] = dataBase;

            this.SqlConnection = new SqlConnection(builder.ConnectionString);
            this.connectionString = builder.ConnectionString;

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
            this.connectionString = builder.ConnectionString;



        }

    }
}
