using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Academy_Coding
{
    class Class1
    { 

        static void Main(string[] args)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["server"] = ".\\SQLEXPRESS";
            builder["Truested_Connection"] = true;     
            builder["Initial Catalog"] = "";
            

            builder["Truested_Connection"] = false;
            builder["User id"] = "AliciaV";
            builder["password"] = "AC2021";
            
            Console.WriteLine(builder.ConnectionString);

            var conn = new SqlConnection(builder.ConnectionString);

            conn.Open();
       
        
        
         }

    }
}
