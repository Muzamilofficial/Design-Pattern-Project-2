using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    public partial class CalculateSalary : Form
    {
        public CalculateSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SalaryManager obj = new SalaryManager(comboBox1, textBox2, textBox3, textBox4);
            obj.CalculateDoctorSalary();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CalculateSalary_Load(object sender, EventArgs e)
        {
            Doctor_info doc_info = new Doctor_info();
         
            DataTable dt = new DataTable();
            dt = doc_info.ShowDoctor();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = dt.Columns[0].ToString();
            comboBox1.DisplayMember = dt.Columns[0].ToString();
           
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    SalaryManager obj = new SalaryManager(combobox2,textBox2,textBox1,textBox3);
        //    obj.CalculateReceptionistSalary();
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
       
    }
}
