using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payroll_Management_System
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnrecru_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frec = new recruitment();
            frec.Show();
        }

      

        private void btnattend_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendance attendance = new attendance();
            attendance.ShowDialog();
        }

        private void btnpayroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form payrol = new payroll();
            payrol.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_btl_Click(object sender, EventArgs e)
        {
            this.Hide();
            login form = new login();
            form.Show();
        }

        private void btn_sel_Click(object sender, EventArgs e)
        {
            this.Hide();
            selection s = new selection();
            s.ShowDialog();
        }

        private void btnhire_Click(object sender, EventArgs e)
        {
           // this.Close();
            Hiring h = new Hiring();
            h.ShowDialog();

        }

      
    }
}
