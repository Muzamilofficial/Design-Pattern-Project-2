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
    public partial class PatientLogin : Form
    {
        public PatientLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login L = new Login(txtPatientID, txtPatientPassword);
            L.LoginPatient();
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
