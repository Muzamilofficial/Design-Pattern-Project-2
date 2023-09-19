using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace HMS.Resources.Classes
{
    class Medicine
    {
        SqlCommand cmd = null;
        Connections con = Connections.getconnection();
        public string AddMedicine(int _Did, int _PID, string _med)
        {
            
            cmd = new SqlCommand("insert into AddMedicine(DoctorID,PID,Medicine)values('" + _Did + "','" + _PID + "','" + _med + "')", con.Open());
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Successfully!";

        }
        public DataTable ShowMedicine()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("select * from AddMedicine", con.Open());
                SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
                DataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                string exception = ex.Message + "No data is available";

            }
            con.Close();
            return dt;
        }
    }
}
