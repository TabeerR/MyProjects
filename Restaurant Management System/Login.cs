using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String UserID, Password, Usertype;
            UserID = txtID.Text;
            Password = txtPass.Text;
            Usertype = cmbUsesrtype.Text;
            if (UserID == "Admin" && Password == "tabz" && Usertype == "Admin")
            {
                this.Hide();
                Form f = new AdminDashboard();
                f.ShowDialog();     
            }
            else if (UserID == "user" && Password == "user" && Usertype == "Receptionist")
            {
            this.Hide();
            Form d = new BillingForm();
            d.ShowDialog();
           
            }
            else if (UserID == "manage" && Password == "product" && Usertype == "Product Manager")
            {
                this.Hide();
            Form d = new Products();
            d.ShowDialog();
            

            }
            else
                MessageBox.Show("Invalid User ID or Password");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        
    }
}
