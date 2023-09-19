using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HMS
{
    public partial class UpdateDoctor : Form
    {
        public UpdateDoctor()
        {
            InitializeComponent();
        }

        private void UpdateDoctor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin obj = new Admin();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connections con = Connections.getconnection();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("Update Doctor set Name = '"+textBox1.Text.Trim()+"', Password = '"+textBox2.Text.Trim()+ "', ContactNumber ='" + textBox3.Text.Trim() + "', Salary = '" + textBox4.Text.Trim() + "', Qualification = '" + textBox5.Text.Trim() + "' where ID = '"+textBox6.Text+"'",con.Open());
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    
                }
                MessageBox.Show("Updated Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connections con = Connections.getconnection();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("Update Receptionist set Name = '" + textBox8.Text.Trim() + "', Password = '" + textBox9.Text.Trim() + "', ContactNumber ='" + textBox10.Text.Trim() + "', Salary = '" + textBox11.Text.Trim() + "', Qualification = '" + textBox12.Text.Trim() + "' where ID = '" + textBox7.Text + "'", con.Open());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                }
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
