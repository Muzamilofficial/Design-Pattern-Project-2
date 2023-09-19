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
    public partial class Add_PatientOptions : Form
    {
        
        public Add_PatientOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient_Info pat_info = new Patient_Info();
            string save = pat_info.AddPatient(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            MessageBox.Show(save);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Add_PatientOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
