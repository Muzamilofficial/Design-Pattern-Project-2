using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HMS.Resources.Forms;

namespace HMS
{ 
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        
       
      
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            //AddDoctor adddoc = new AddDoctor();
            //adddoc.Show();
            AddDoctorOptions ado = new AddDoctorOptions();
            ado.Show();
        }

        private void btn_AddReceptionist_Click(object sender, EventArgs e)
        {
            AddReceptionistOptions addRec = new AddReceptionistOptions();
            addRec.Show();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            Patient_Info pi = new Patient_Info();
            DataTable dt = pi.ShowPatient();
            gridViewAdmin.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            LoginProxyForm lpf = new LoginProxyForm();
            lpf.Show();
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            UpdateDoctor ud = new UpdateDoctor();
            ud.Show();
            this.Hide();

           // string up = A.UpdateDoctor(textBox10.Text,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
           // MessageBox.Show(up);
           
        }

        private void btnPrepareDoctorSalary_Click(object sender, EventArgs e)
        {
            CalculateSalary CS = new CalculateSalary();
            this.Hide();
            CS.Show();
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            Doctor_info d_i = new Doctor_info();
            string ans = d_i.DeleteDoctor(Convert.ToInt16(comboBox1.Text));
            MessageBox.Show(ans);
           

        }

        private void Admin_Load(object sender, EventArgs e)
        {


            Doctor_info doc_info = new Doctor_info();
            Receptionist_Info r=new Receptionist_Info();
            DataTable dt = new DataTable();
            dt = doc_info.ShowDoctor();
            comboBox1.DataSource = dt;
           comboBox1.ValueMember = dt.Columns[0].ToString();
            comboBox1.DisplayMember = dt.Columns[0].ToString();

            dt = r.ShowReceptionist();
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = dt.Columns[0].ToString();
            comboBox2.DisplayMember = dt.Columns[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receptionist_Info recep_info = new Receptionist_Info();
            string ans = recep_info.DeleteReceptionist(Convert.ToInt16(comboBox2.Text));
            MessageBox.Show(ans);
        }

        private void btn_UpdateReceptionist_Click(object sender, EventArgs e)
        {
            UpdateDoctor obj = new UpdateDoctor();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PayFeeManager fee = new PayFeeManager();
            DataTable dt = fee.ShowFee();
            gridViewAdmin.DataSource = dt;
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void gridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Doctor_info doc_info = new Doctor_info();
            DataTable dt = doc_info.ShowDoctor();
            gridViewAdmin.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Receptionist_Info rece_info = new Receptionist_Info();
            DataTable dt = rece_info.ShowReceptionist();
            gridViewAdmin.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CalculateRecSalary CS = new CalculateRecSalary();
            this.Hide();
            CS.Show();
        }
    }
}
