using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMS.Resources.Forms
{
    public partial class LoginProxyForm : Form
    {
        public LoginProxyForm()
        {
            InitializeComponent();
        }

        public LoginProxyForm(TextBox ID1, TextBox Password1)
        {
            // TODO: Complete member initialization
            this.ID1 = ID1;
            this.Password1 = Password1;
        }

        private void btnLoginProxyAdmin_Click(object sender, EventArgs e)
        {
            LoginProxy Loginproxy = new LoginProxy(ID1,Password1);
            Loginproxy.LoginProxyAdmin();
        }

      
    }
}
