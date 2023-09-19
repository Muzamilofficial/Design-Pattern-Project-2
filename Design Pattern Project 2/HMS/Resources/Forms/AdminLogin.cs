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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login L = new Login(txtAdminID,txtAdminPassword);
            L.LoginAdmin();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtAdminID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
