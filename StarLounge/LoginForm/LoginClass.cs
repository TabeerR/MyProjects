using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public class LoginClass
    {
        public string username { get; set; }
        public string password { get; set; }
        public string msg { get; set; }


        public void log()
        {

            if (username == "admin" && password == "123")
            {
                msg = ("Welcome Sir");

                DashBoard d1 = new DashBoard();
                d1.Show();
            }
            //else if ()
            //{
            //    msg = ("Logged In");


            //    DashBoard d2 = new DashBoard();
            //    d2.employeeToolStripMenuItem.Enabled = false;
            //    d2.coffeeToolStripMenuItem.Enabled = false;
            //    d2.inventoryToolStripMenuItem.Enabled = false;
            //    d2.Show();
            //    //Customer c1 = new Customer();
            //    //c1.btn_ret.Visible = true;
            //    //c1.btn_ret.Enabled = false;
            //    //c1.btn_create.Enabled = false; 

            //}
            else
            {
                msg = ("Invalid id/pass/user");
            }

        }
    }
}
