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
    class Doctor_info:Observer
    {
        //int Doctor_ID;
        //string Doctor_Name;
        string state;
        Connections con = Connections.getconnection();
         SqlCommand cmd = null;

        public string DoctorLogin(string _ID, string pswrd)
        {
            cmd = new SqlCommand("select * from Doctor where ID ='" + _ID + "'  and Password='" + pswrd + "'", con.Open());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return "Welcome";
            }
            else
            {
                return "Invalid User";
            con.Close();
            }
        }
        public string AddDoctor(string _pswd, string _name, string _fName, string _qual, string _email, int _age, string _gender, long _cnum, float _salary)
        {
            SqlCommand cmd = new SqlCommand("insert into Doctor(Password,Name,FatherName,Qualification,Email,Age,Gender,ContactNumber,Salary)values('" + _pswd + "','" + _name + "','" + _fName + "','" + _qual + "','" + _email + "','" + _age + "','" + _gender + "','" + _cnum + "','" + _salary + "')", con.Open());
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Successfully!";
        }
        public DataTable ShowDoctor()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("select * from Doctor", con.Open());
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

        public string DeleteDoctor(int _ID)
        {
            try
            {
                cmd = new SqlCommand("Delete from Doctor where ID = '" + _ID + "'", con.Open());
                cmd.ExecuteNonQuery();
                con.Close();
                return "Doctor removed Successfully";
            }
            catch (Exception ex)
            {

                return ex.Message + "Data not removed";
            }
        }
        public void UpdateDoctor()
        {
            UpdateDoctor obj = new UpdateDoctor();
            obj.Show();
            /*try
            {
                cmd = new SqlCommand("UPDATE Doctor Set Password = '" + _pswd + "',Name = '" + _name + "',FatherName='" + _fname + "',Qualification='" + _qual + "',Age='" + _age + "',Email='" + _email + "',Gender='" + _gender + "',ContactNumber='" + _cnum + "',Salary='" + _salary + "'", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();
                return "DOCTOR UPDATED SUCCESSFULLY";
            }
            catch (Exception ex)
            {
                return ex.Message + "Data Not Retrieved";
            }
            //con.Close();*/
        }
        
        //public string AddEndoSurgeryDoctor(string _pswd, string _name, string _fName, string _qual, string _email, int _age, string _gender, long _cnum, float _salary)
        //{
        //    SqlCommand cmd = new SqlCommand("insert into EndoSurgerydoc(Password,Name,FatherName,Qualification,Email,Age,Gender,ContactNumber,Salary)values('" + _pswd + "','" + _name + "','" + _fName + "','" + _qual + "','" + _email + "','" + _age + "','" + _gender + "','" + _cnum + "','" + _salary + "')", con.Open());
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    return "Saved Successfully!";
        //}
        //public Surgery CreateEndocrineSurgery(String doctorID, string doctorname,string type)
        //{
        //    Surgery surgery = null;
        //    if (type == "endocrine")
        //    {
        //        surgery = new EndocrineSurgery(doctorID, doctorname);
        //    }
        //    else if (type == "pediatrics")
        //    {
        //        surgery = new PediatricsSurgery(doctorID, doctorname);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid doctor type");
        //    }
        //    return surgery;
        //    //switch (type)
        //    //{
        //    //    case "endocrine":
                    
        //    //        break;
        //    //    case "pediatrics ":
        //    //        surgery = new PediatricsSurgery(doctorID, doctorname);
        //    //        break;

        //    //    default:
        //    //        Console.WriteLine("Invalid doctor type");
        //    //}
           
        //}
        //public OPD CreateEndocrineOPD(string doctorID, string doctorname, string type)
        //{
        //    OPD opd = null;
        //    if (type == "endocrine")
        //    {
        //        opd = new EndocrineOPD(doctorID, doctorname);
        //    }
        //    else if (type == "pediatrics")
        //    {
        //        opd = new PediatricsOPD(doctorID, doctorname);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid doctor type");
        //    }
        //    return opd;
        //}
        public DataTable ShowSalary()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("select * from Salary", con.Open());
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
