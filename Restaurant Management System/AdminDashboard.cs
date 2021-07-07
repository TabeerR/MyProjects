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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new BillingForm();
            x.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form g = new Products();
            g.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form j = new Login();
            j.ShowDialog();
        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form C = new Customer();
            C.ShowDialog();
        }

       
        

        

        

               
    }
}

