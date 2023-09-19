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
    public partial class CalculateRecSalary : Form
    {
        public CalculateRecSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalaryManager obj = new SalaryManager(comboBox2, textBox2, textBox1, textBox3);
            obj.CalculateReceptionistSalary();
        }

        private void CalculateRecSalary_Load(object sender, EventArgs e)
        {
            
            Receptionist_Info r = new Receptionist_Info();
            DataTable dt = new DataTable();

            dt = r.ShowReceptionist();
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = dt.Columns[0].ToString();
            comboBox2.DisplayMember = dt.Columns[0].ToString();
        }
    }
}
