using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
namespace HMS
{
    class PayFeeManager
    {
        //float TestCharges;
        //float BedCharges;
        //float OPDCharges;
        //float SurgeryCharges;
        float amount;
        Connections con = Connections.getconnection();
        SqlCommand cmd = null;
        public string AddFee(string _name, float _amount)
        {
            SqlCommand cmd = new SqlCommand("insert into AddFee(Name,Amount)values('" + _name + "','" + _amount + "')", con.Open());
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Successfully!";
        }
        public string CalculateFee(string _name,float _amount)
        {
            SqlCommand cmd = new SqlCommand("insert into AddFee(Name,Amount)values('" + _name+ "','" + _amount + "')", con.Open());
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Successfully!";
            
        }
       public DataTable ShowFee()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("select * from AddFee", con.Open());
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
