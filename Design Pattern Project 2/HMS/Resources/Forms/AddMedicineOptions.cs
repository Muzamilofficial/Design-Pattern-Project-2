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
    public partial class AddMedicineOptions : Form
    {
        public AddMedicineOptions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            History h = new History();
            DataTable dt = h.ShowHistory();
            dataGridView1.DataSource = dt;
        }

        private void AddMedicineOptions_Load(object sender, EventArgs e)
        {

            Patient_Info pat_info = new Patient_Info();
            Doctor_info doc_info = new Doctor_info();
            DataTable dt = new DataTable();
            dt = doc_info.ShowDoctor();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = dt.Columns[0].ToString();
            comboBox1.DisplayMember = dt.Columns[0].ToString();

            dt = pat_info.ShowPatient();
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = dt.Columns[0].ToString();
            comboBox2.DisplayMember = dt.Columns[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicine m = new Medicine();
            string save = m.AddMedicine(Convert.ToInt32(comboBox1.Text),Convert.ToInt32(comboBox2.Text),textBox3.Text);
            MessageBox.Show(save);
        }
    }
}
