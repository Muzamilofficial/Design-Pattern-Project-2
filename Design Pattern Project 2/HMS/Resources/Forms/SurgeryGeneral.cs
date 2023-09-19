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
    public partial class SurgeryWard : Form
    {
        public SurgeryWard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SurgeryWardOPD wardOPD = new SurgeryWardOPD();
            wardOPD.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneralWardOPD wardOPD = new GeneralWardOPD();
            wardOPD.Show();
            this.Hide();
        }
    }
}
