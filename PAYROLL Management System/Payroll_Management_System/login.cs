using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Payroll_Management_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            loginform log = new loginform();
            try
            {
                if (txtusername.Text == "admin" && txtpass.Text == "admin123")
                {
                    this.Hide();
                    dashboard d1 = new dashboard();
                    d1.Show();
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
            
            
        }
        
         
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    
    }
}
