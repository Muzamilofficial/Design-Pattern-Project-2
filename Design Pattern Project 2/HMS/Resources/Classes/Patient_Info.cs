using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;
namespace HMS
{
    class Patient_Info
    {
        int p_id;
        public Patient_Info()
        {
        }
        public Patient_Info(int id)
        {
            p_id = id;
        }


        Connections con = Connections.getconnection();
        List<PatientLogin> lst = new List<PatientLogin>();
        SqlCommand cmd = null;
        public string PatientLogin(int _ID, string pswrd)
        {
            cmd = new SqlCommand("select * from Patient where ID ='" + _ID + "'  and Password ='" + pswrd + "'", con.Open());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return "Welcome";
            }
            else
            {
                con.Close();
                return "Invalid User";
            }
        }
        public string AddPatient(string _Pswd, string _name, string _fName, string _disease, string _age, string _gender, string _cnum)
        {
            SqlCommand cmd = new SqlCommand("insert into Patient(Password,Name,FatherName,Disease,Age,Gender,ContactNumber)values('" + _Pswd + "','" + _name + "','" + _fName + "','" + _disease + "','" + _age + "','" + _gender + "','" + _cnum + "')", con.Open());
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Successfully!";
        }
        public DataTable ShowPatient()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("select * from Patient", con.Open());
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
