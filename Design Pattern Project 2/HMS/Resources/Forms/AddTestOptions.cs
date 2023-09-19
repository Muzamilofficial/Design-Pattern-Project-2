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
    public partial class AddTestOptions : Form
    {
        public AddTestOptions()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            History history = new History();
            DataTable dt = history.ShowHistory();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            string save = test.AddTest(Convert.ToInt32(comboBox2.Text), textBox3.Text);
            MessageBox.Show(save);
        }

        private void AddTestOptions_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Patient_Info pat_info = new Patient_Info();
            Doctor_info doc_info = new Doctor_info();

            dt = doc_info.ShowDoctor();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = dt.Columns[0].ToString();
            comboBox1.DisplayMember = dt.Columns[0].ToString();

            dt = pat_info.ShowPatient();
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = dt.Columns[0].ToString();
            comboBox2.DisplayMember = dt.Columns[0].ToString();
        }
    }
}
