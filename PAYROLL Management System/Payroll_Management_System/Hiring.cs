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
    public partial class Hiring : Form
    {
        public  Hiring()
        {
            InitializeComponent();
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            clsSelection sel = new clsSelection();
            clsHiring hire = new clsHiring();
           
            try
            {
                int idx;
                hire.Employeeid = Convert.ToInt16(txtempId2.Text);
                // hire.Name = txtempname.Text;
                // hire.LastName = txtlastname.Text;

                hire.Salary = Convert.ToDouble(txtSalary.Text);
                sel.Employeeid = hire.Employeeid.ToString();

                idx = sel.RetrieveS();
              

                hire.First_Name = sel.First_Name;
                hire.Department = sel.Department;
                hire.Address = sel.Address;
                hire.Country = sel.Country;
                hire.City = sel.City;
                hire.Last_Name = sel.Last_Name;
                hire.Gender = sel.Gender;
                hire.Phone_number = sel.Phone_number;
                hire.E_mail= sel.E_mail;
                

                hire.GetHired();
                dvgHiringList.DataSource = clsHiring.HiringData.ToArray();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard form = new dashboard();
            form.Show();
        }

        private void btnSaveH_Click(object sender, EventArgs e)
        {
            clsHiring hire = new clsHiring();
            try
            {
                hire.SaveXLMH();
                MessageBox.Show("Data Saved Successfully");
                dvgHiringList.DataSource = clsHiring.HiringData.ToArray();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Record not saved\n" + ex.Message);
                return;
            }
        }

        private void Hiring_Load(object sender, EventArgs e)
        {
            clsSelection mysel = new clsSelection();
            clsHiring hire = new clsHiring();
            try
            {
                hire.LoadXMLH();

                mysel.LoadXML();

                txtempId2.DataSource = clsSelection.SelectionData.ToArray();
                txtempId2.DisplayMember = "Employeeid";
                txtempId2.ValueMember = "Employeeid";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record not loaded\n" + ex.Message);
                return;
            }
            dvgHiringList.DataSource = clsHiring.HiringData.ToArray();
          
        }

        private void btnDeleteH_Click(object sender, EventArgs e)
        {
            int idx;
            clsHiring hire = new clsHiring();
            try
            {
                hire.Employeeid = Convert.ToInt16(txtempId2.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            idx = hire.DeleteH();
            if (idx == -1)
                MessageBox.Show("Record Not Found");
            dvgHiringList.DataSource = clsHiring.HiringData.ToArray();
        }

        private void txtempId2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dvgHiringList_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    
    }
}
