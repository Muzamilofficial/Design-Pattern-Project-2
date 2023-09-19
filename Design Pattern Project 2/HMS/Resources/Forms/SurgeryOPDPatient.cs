using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace HMS.Resources.Forms
{
    class SurgeryOPDPatient:SurgeryPatient
    {
        Connections con = Connections.getconnection();
        SqlCommand cmd = null;
        
        public  override string addPatient(string _Pswd, string _name, string _fName, string _disease, string _age, string _gender, string _cnum)
        {
            SqlCommand cmd = new SqlCommand("insert into SurgeryOPDPatient(Password,Name,FatherName,Disease,Age,Gender,ContactNumber)values('" + _Pswd + "','" + _name + "','" + _fName + "','" + _disease + "','" + _age + "','" + _gender + "','" + _cnum + "')", con.Open());
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Successfully!";
        }
    }
}
