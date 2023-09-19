using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace HMS
{
    class Connections
    {
        SqlConnection connectionString = new SqlConnection(@"Data Source=DESKTOP-IA90CT6\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");
        static Connections conn = null;
        private Connections()
        {

        }

        public static Connections getconnection()
        {
            if (conn == null)
            {
                conn = new Connections();
                return conn;
            }
            else
            {
                return conn;
            }
        }
        public SqlConnection Open()
        {
            connectionString.Open();
            return connectionString;
        }
        public SqlConnection Close()
        {
            connectionString.Close();
            return connectionString;




        }
    }
}
