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
    public partial class AddReceptionistOptions : Form
    {
       
        public AddReceptionistOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receptionist_Info rec_info = new Receptionist_Info();
            string save = rec_info.AddReceptionist(textBox9.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text), textBox6.Text, textBox7.Text, Convert.ToInt32(textBox8.Text));
            MessageBox.Show(save);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void AddReceptionistOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
