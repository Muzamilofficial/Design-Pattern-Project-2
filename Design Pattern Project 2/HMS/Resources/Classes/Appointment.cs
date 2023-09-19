using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace HMS.Resources.Classes
{
    class Appointment
    {
        Connections con = Connections.getconnection();
        SqlCommand cmd = null;
        public string AddAppointment(string _name, string _disease, string _doctor)
        {
            SqlCommand cmd = new SqlCommand("insert into Appointment(Name,Disease,Doctor)values('" + _name + "','" + _disease + "','" + _doctor + "')", con.Open());
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Successfully!";
        }
        public DataTable ShowAppointment()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("select * from AddAppointment", con.Open());
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
