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
    public partial class PatientAppointmentOptions : Form
    {
        public PatientAppointmentOptions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appointment app = new Appointment();
            string save = app.AddAppointment(comboBox3.Text, textBox3.Text, comboBox1.Text);
            MessageBox.Show(save);
        }

        private void PatientAppointmentOptions_Load(object sender, EventArgs e)
        {
            Doctor_info doc_info = new Doctor_info();
            Patient_Info pat_info = new Patient_Info();
            DataTable dt = new DataTable();
            dt = doc_info.ShowDoctor();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = dt.Columns[0].ToString();
            comboBox1.DisplayMember = dt.Columns[0].ToString();

            dt = pat_info.ShowPatient();
            comboBox3.DataSource = dt;
            comboBox3.ValueMember = dt.Columns[0].ToString();
            comboBox3.DisplayMember = dt.Columns[0].ToString();

           
        }
    }
}
