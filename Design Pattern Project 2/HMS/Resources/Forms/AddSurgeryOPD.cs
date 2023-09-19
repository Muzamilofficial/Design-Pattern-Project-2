using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMS.Resources.Forms
{
    public partial class AddSurgeryOPD : Form
    {
        public AddSurgeryOPD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SurgeryOPDPatient sop = new SurgeryOPDPatient();
            string save = sop.addPatient(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            MessageBox.Show(save);
        }

        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
