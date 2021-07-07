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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginClass frm = new LoginClass();

            frm.username = txtUsername.Text;
            frm.password = txtPassword.Text;
            frm.log();
            MessageBox.Show(frm.msg);

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}
