using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace HMS.Resources.Forms
{
    class LoginProxy
    {
        Connections con = Connections.getconnection();
      
        SqlCommand cmd = null;
        private System.Windows.Forms.TextBox ID1;
        private System.Windows.Forms.TextBox Password1;

        public LoginProxy(System.Windows.Forms.TextBox ID1, System.Windows.Forms.TextBox Password1)
        {
            // TODO: Complete member initialization
            this.ID1 = ID1;
            this.Password1 = Password1;
        }
        public void LoginProxyAdmin()
        {
            if (ID1.Text != "" && Password1.Text != "")
            {
                Admin_Info p = new Admin_Info();
                string message = p.AdminLogin(ID1.Text, Password1.Text);
                MessageBox.Show(message);
                if (message == "Welcome")
                {
                    Receptionist recep = new Receptionist();
                    recep.Show();

                }

            }
            else
            {
                MessageBox.Show("Please Fill All The Fields");
            }
        }



        internal void LoginProxyForm(System.Windows.Forms.TextBox ID1, System.Windows.Forms.TextBox Password1)
        {
            throw new NotImplementedException();
        }
    }
}
