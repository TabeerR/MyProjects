using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_And_Distribution
{
    public partial class LogIN : Form
    {
        public LogIN()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            string user, pass;
            user = txtpbuser.Text;
            pass = txtpbpassword.Text;

            

            if (user=="Ansab" && pass == "saad" )
            {
                MessageBox.Show("User Logged In Sucessfully! ");
                Main ss = new Main();
                ss.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Username and Password");
               
                
            }
        }

        private void txtpbuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 32 && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
