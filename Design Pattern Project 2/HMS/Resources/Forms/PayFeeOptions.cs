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
    public partial class PayFeeOptions : Form
    {
        public PayFeeOptions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PayFeeManager fee = new PayFeeManager();
            string save = fee.AddFee(comboBox1.Text, Convert.ToSingle(textBox2.Text));
            MessageBox.Show(save);
    //        private static  payfeemanager Instance=null;
    //        if(Instance==null)
    //{

    //}
           
         }

        private void PayFeeOptions_Load(object sender, EventArgs e)
        {
            Patient_Info pat_info = new Patient_Info();
            DataTable dt = new DataTable();
            dt = pat_info.ShowPatient();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = dt.Columns[0].ToString();
            comboBox1.DisplayMember = dt.Columns[0].ToString();
            

        }
    }
}
