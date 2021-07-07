using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void orderHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Order_Here ab = new Order_Here();
            ab.Show();

        }

     

        private void addCoffeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            addcoffe ad = new addcoffe();
            ad.Show();
        }
    }
}
