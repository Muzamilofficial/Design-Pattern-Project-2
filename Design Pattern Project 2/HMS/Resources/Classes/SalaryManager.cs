using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using HMS.Resources.Classes;

namespace HMS
{
     class SalaryManager
    {
        Connections con = Connections.getconnection();
        SqlCommand cmd = null;
        List<Observer> observers = new List<Observer>();
        private string state;
        int doctor_id;
        double BasicPay;
        int AttendanceReport;
        int time;
        double Salary;
        int d_Fid;
        int r_Fid;

        public SalaryManager(System.Windows.Forms.ComboBox c1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4)
        {
            doctor_id = Convert.ToInt32(c1.Text);
            BasicPay = Convert.ToDouble(t4.Text);
            AttendanceReport = Convert.ToInt32(t3.Text);
            time = Convert.ToInt32(t2.Text);
        }
        public SalaryManager()
        {
        }
        public void CalculateDoctorSalary()
        {
            if (time == 6)
            {
                Salary = BasicPay;

            }
            else if (time == 12)
            {
                Salary = BasicPay * 2;
            }

            if (AttendanceReport >= 0)
            {
                for (int i = 1; i <= AttendanceReport; i++)
                {
                    Salary = Salary - 100;
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

            Connections con = Connections.getconnection();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Salary(NoOfAbsent,Timing,BasicPay,DoctorSalary,d_Fid) values(" + AttendanceReport + "," + time + "," + BasicPay + "," + Salary + ","+d_Fid+")", con.Open());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                }
                MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }
        public void CalculateReceptionistSalary()
        {
            if (time == 6)
            {
                Salary = BasicPay;

            }
            else if (time == 12)
            {
                Salary = BasicPay * 2;
            }

            if (AttendanceReport >= 0)
            {
                for (int i = 1; i <= AttendanceReport; i++)
                {
                    Salary = Salary - 100;
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

            Connections con = Connections.getconnection();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into RecSalary(NoOfAbsent,Timing,BasicPay,RecepSalary,r_Fid) values(" + AttendanceReport + "," + time + "," + BasicPay + ", " + Salary +","+r_Fid+")", con.Open());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                }
                MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }
        
       
         public void NotifySalary()
         {
            int i=0;
            foreach (Observer observer in observers)
	        {
		    i++;
            Console.WriteLine("Notifying Observer#"+i+" of the changed state of blog...");
            observer.ShowSalary();  
	        }
            System.Windows.Forms.MessageBox.Show("YOUR SALARY HAS BEEN UPDATED");
         }
        
    }
}
