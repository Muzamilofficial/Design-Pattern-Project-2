using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMS
{
    class Login
    {
         System.Windows.Forms.TextBox tb1;
              System.Windows.Forms.TextBox tb2;
        public Login(System.Windows.Forms.TextBox tb1,System.Windows.Forms.TextBox tb2)
        {
            this.tb1 = tb1;
            this.tb2 = tb2;
        }
        public void LoginAdmin()
        {
            if (tb1.Text != "" && tb2.Text != "")
            {
                Admin_Info p = new Admin_Info();
                string message = p.AdminLogin(tb1.Text, tb2.Text);
                MessageBox.Show(message);
                if (message == "Welcome")
                {
                    Admin obj = new Admin();
                    obj.Show();
                   
                }

            }
            else
            {
                MessageBox.Show("Please Fill All The Fields");
            }
        }
        public void LoginDoctor()
        {
            if (tb1.Text != "" && tb2.Text != "")
            {
                Doctor_info p = new Doctor_info();
                string message = p.DoctorLogin(tb1.Text, tb2.Text);
                MessageBox.Show(message);
                if (message == "Welcome")
                {
                    Doctor obj = new Doctor();
                    obj.Show();

                }

            }
            else
            {
                MessageBox.Show("Please Fill All The Fields");
            }
        }
        public void LoginPatient()
        {
            if (tb1.Text != "" && tb2.Text != "")
            {
                Patient_Info p = new Patient_Info();
                string message = p.PatientLogin(Convert.ToInt32(tb1.Text), tb2.Text);
                Patient p1 = new Patient(tb1, tb2);
                MessageBox.Show(message);
                if (message == "Welcome")
                {
                    Patient obj = new Patient();
                    obj.Show();

                }

            }
            else
            {
                MessageBox.Show("Please Fill All The Fields");
            }
        }
        public void LoginReceptionist()
        {
            if (tb1.Text != "" && tb2.Text != "")
            {
                Receptionist_Info p = new Receptionist_Info();
                string message = p.ReceptionistLogin(tb1.Text, tb2.Text);
                MessageBox.Show(message);
                if (message == "Welcome")
                {
                    Receptionist obj = new Receptionist();
                    obj.Show();

                }

            }
            else
            {
                MessageBox.Show("Please Fill All The Fields");
            }
        }
    }
}
