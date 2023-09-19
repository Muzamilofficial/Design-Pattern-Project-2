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
  
    public partial class AddHistoryOptions : Form
    {
        public AddHistoryOptions()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddHistoryOptions_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            Patient_Info pat_info = new Patient_Info();
            dt = pat_info.ShowPatient();
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = dt.Columns[0].ToString();
            comboBox2.DisplayMember = dt.Columns[0].ToString();
          
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            History h = new History();
            string save = h.AddHistory(comboBox2.Text, textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text);
            MessageBox.Show(save);
        }

       
    }
}
