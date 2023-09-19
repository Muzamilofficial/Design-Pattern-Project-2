using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HMS.Resources.Classes;

namespace HMS
{
    public partial class Patient : Form
    {
        int pid;
        int ppass;

        public Patient()
        {
            InitializeComponent();
        }
       public Patient(System.Windows.Forms.TextBox id,System.Windows.Forms.TextBox pass)
        {
             pid = Convert.ToInt32(id.Text);
             ppass = Convert.ToInt32(pass.Text);
        }
        
        private void btnRegisterforAppointment_Click(object sender, EventArgs e)
        {
            PatientAppointmentOptions pao = new PatientAppointmentOptions();
            pao.Show();
        }

        private void btnPayFee_Click(object sender, EventArgs e)
        {
            PayFeeOptions pfo = new PayFeeOptions();
            pfo.Show();
        }

        private void btnAddHistory_Click(object sender, EventArgs e)
        {
            AddHistoryOptions aho = new AddHistoryOptions();
            aho.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicine med = new Medicine();
            DataTable dt = med.ShowMedicine();
            dataGridPatient.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            DataTable dt = test.ShowTest();
            dataGridPatient.DataSource = dt;

        }

       
    }
}
