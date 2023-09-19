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
    public partial class GeneralOPD : Form
    {
        public GeneralOPD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneralOPDPatient gop = new GeneralOPDPatient();
            string save = gop.AddPatient(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            MessageBox.Show(save);
        }
    }
}
