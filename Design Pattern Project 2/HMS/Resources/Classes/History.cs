using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HMS.Resources.Classes
{
    class History
    {
        Connections con = Connections.getconnection();
        SqlCommand cmd = null;
        public string AddHistory(string _name, string _disease, int _age, string _inherital)
        {
            SqlCommand cmd = new SqlCommand("insert into History(Name,Disease,Age,Inherital)values('" + _name + "','" + _disease + "','" + _age + "','" + _inherital + "')", con.Open());
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Successfully!";
        }
        public DataTable ShowHistory()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("select * from History", con.Open());
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
