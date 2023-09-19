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
    public partial class ReceiveChargesOptions : Form
    {
        public ReceiveChargesOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ReceiveChargesOptions_Load(object sender, EventArgs e)
        {
            Patient_Info patient_Info = new Patient_Info();
            DataTable dt = new DataTable();
            dt = patient_Info.ShowPatient();
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = dt.Columns[0].ToString();
            comboBox2.DisplayMember = dt.Columns[0].ToString();
        }
    }
}
