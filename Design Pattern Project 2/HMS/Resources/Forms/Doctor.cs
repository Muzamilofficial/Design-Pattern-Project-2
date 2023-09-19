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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void btnViewPatientHistory_Click(object sender, EventArgs e)
        {
            History h = new History();
            DataTable dt = h.ShowHistory();
            dataGridDoctor.DataSource = dt;
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicineOptions med = new AddMedicineOptions();
            med.Show();
        }

        private void btn_AddTest_Click(object sender, EventArgs e)
        {
            AddTestOptions test = new AddTestOptions();
            test.Show();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //System.Windows.Forms.MessageBox.Show("YOUR SALARY HAS BEEN UPDATED");
            SalaryManager salarymanager = new SalaryManager();
            Doctor_info dinfo = new Doctor_info();
            salarymanager.NotifySalary();
            DataTable dt = dinfo.ShowSalary();
            dataGridDoctor.DataSource = dt;
        }
    }
}
