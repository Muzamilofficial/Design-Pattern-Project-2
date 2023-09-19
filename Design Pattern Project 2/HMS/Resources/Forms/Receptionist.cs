using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HMS.Resources.Classes;
using HMS.Resources.Forms;

namespace HMS
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            SurgeryWard surward = new SurgeryWard();
            surward.Show();
        }

        private void btnRecievePatientCharges_Click(object sender, EventArgs e)
        {
            ReceiveChargesOptions rco = new ReceiveChargesOptions();
            rco.Show();
        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            Doctor_info doc_info = new Doctor_info();
            DataTable dt = doc_info.ShowDoctor();
            dataGridReceptionist.DataSource = dt;
        }

        private void btnViewPatientAppoinment_Click(object sender, EventArgs e)
        {
            Appointment app = new Appointment();
            DataTable dt = app.ShowAppointment();
            dataGridReceptionist.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SalaryManager salarymanager = new SalaryManager();
            Receptionist_Info rinfo = new Receptionist_Info();
            salarymanager.NotifySalary();
            DataTable dt = rinfo.ShowSalary();
            dataGridReceptionist.DataSource = dt;

           

        }

        
    }
}
