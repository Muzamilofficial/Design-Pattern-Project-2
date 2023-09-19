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
    public partial class GeneralWard : Form
    {
        public GeneralWard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneralWardPatient gwp = new GeneralWardPatient();
            string save = gwp.AddPatient(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            MessageBox.Show(save);
        }

        //private void GeneralWard_Load(object sender, EventArgs e)
        //{

        //}
    }
}
