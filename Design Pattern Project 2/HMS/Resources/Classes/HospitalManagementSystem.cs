using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMS.Resources.Classes
{
    public partial class HospitalManagementSystem : Form
    {
        public HospitalManagementSystem()
        {
            InitializeComponent();
        }

        private void HospitalManagementSystem_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HMS hms = new HMS();
            hms.Show();
            this.Hide();
        }

        


        

        
    }
}
