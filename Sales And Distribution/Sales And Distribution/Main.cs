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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lbltotalammount ss = new lbltotalammount();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Material_Master_Data_Form ss = new Material_Master_Data_Form();
            ss.Show();
        }
        

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form x = new LogIN();
            x.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
