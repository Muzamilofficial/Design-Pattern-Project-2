using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using HMS.Resources.Classes;

namespace HMS
{
    class Receptionist_Info:Observer
    {
        int Receptionist_ID;
        string Receptionist_Name;
        string state;
        Connections con = Connections.getconnection();
        List<ReceptionistLogin> lst = new List<ReceptionistLogin>();
        SqlCommand cmd = null;
        public string ReceptionistLogin(string _ID, string pswrd)
        {
            cmd = new SqlCommand("select * from Receptionist where ID ='" + _ID + "'  and Password='" + pswrd + "'", con.Open());
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
        public string AddReceptionist(string _pswd, string _name, string _fName, string _qual, string _email, int _age, string _gender, string _cnum, int _salary)
        {
            SqlCommand cmd = new SqlCommand("insert into Receptionist(Password,Name,FatherName,Qualification,Email,Age,Gender,ContactNumber,Salary)values('" + _pswd + "','" + _name + "','" + _fName + "','" + _qual + "','" + _email + "','" + _age + "','" + _gender + "','" + _cnum + "','" + _salary + "')", con.Open());
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Successfully!";
        }
        public string DeleteReceptionist(int _ID)
        {
            try
            {
                cmd = new SqlCommand("Delete  from Receptionist where ID = '" + _ID + "'", con.Open());
                cmd.ExecuteNonQuery();
                con.Close();
                return "Receptionist removed Successfully";
            }
            catch (Exception ex)
            {

                return ex.Message + "Data not removed";
            }
        }
        public DataTable ShowReceptionist()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("select * from Receptionist", con.Open());
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



        public DataTable ShowSalary()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("select * from RecSalary", con.Open());
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
        //public void UpdateSalary()
        //{
        //}
    }
}
