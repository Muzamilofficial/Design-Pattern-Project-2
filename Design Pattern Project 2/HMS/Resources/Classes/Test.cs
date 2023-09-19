using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace HMS.Resources.Classes
{
    class Test
    {
        Connections con = Connections.getconnection();
        SqlCommand cmd = null;

        public string AddTest(int _PID, string _test)
        {
            SqlCommand cmd = new SqlCommand("insert into Test(PID,Test)values('" + _PID + "','" + _test + "')", con.Open());
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Successfully!";
        }
        public DataTable ShowTest()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("select * from AddTest", con.Open());
                SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
                DataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                string exception = ex.Message + "No data is avaiable";

            }
            con.Close();
            return dt;
        }
    }
}
