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
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
        }


        public void Clear()
        {
            txt_empid.Text = "";
            txtDA.Text = "";
            txtDL.Text = "";
            txtDOT.Text = "";
            txt_salary.Text = "";
            lblemname.Text = "";
            lblsalary.Text = "";
            com_mont.Text = "";
        }

        private void attenddance_Load(object sender, EventArgs e)
        {
            clsAttendence Attend = new clsAttendence();
            clsHiring hir = new clsHiring();
            try
            {
               Attend.LoadXML();
                hir.LoadXMLH();
                txt_empid.DataSource = clsHiring.HiringData.ToArray();
                txt_empid.DisplayMember = "EmployeeID";
                txt_empid.ValueMember = "EmployeeID";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Record not loaded\n" + ex.Message);
            }

            dgvAttendance.DataSource = clsAttendence.AttendenceData.ToArray();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int idx;
            clsHiring hir = new clsHiring();
            try
            {
                hir.Employeeid = Convert.ToInt32(txt_empid.Text);
                idx = hir.HRrtrive();
                if (idx == -1)
                {
                    MessageBox.Show("Record not found");
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            hir.HRrtrive();

            lblemname.Text = hir.First_Name.ToString();
            lblsalary.Text = hir.Salary.ToString();
        }

        private void gbox_emplyee_Enter(object sender, EventArgs e)
        {

        } 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClsRecuitment rec = new ClsRecuitment();
            clsAttendence Attend = new clsAttendence();
            clsHiring hir = new clsHiring();
            try
            {
                rec.Candidate_id = Convert.ToString(txt_empid.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Attend.EmployeeID = Convert.ToInt32(txt_empid.Text);
            Attend.EmployeeName = lblemname.Text;
            Attend.EmployeeBasicPay = Convert.ToInt32(lblsalary.Text);
            Attend.EmployeeDaysOnTime = Convert.ToInt32(txtDOT.Text);
            Attend.EmployeeDaysLate = Convert.ToInt32(txtDL.Text);
            Attend.EmployeeAbsent = Convert.ToInt32(txtDA.Text);
            Attend.EmployeeSalaryMonth = com_mont.Text;
            Attend.EmployeeSalaryYear = Convert.ToInt32(txt_salary.Text);



            try
            {
                Attend.Create();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
                return;
            }

            dgvAttendance.DataSource = clsAttendence.AttendenceData.ToArray();
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsAttendence Attend = new clsAttendence();
            try
            {
                Attend.SaveXML();
                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record not saved\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idx;
            clsAttendence Attend = new clsAttendence();
            try
            {
                Attend.EmployeeID = Convert.ToInt32(txt_empid.Text);
            }
            catch
                (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            idx = Attend.Delete();
            if (idx == -1)
                MessageBox.Show("Record not found");
            dgvAttendance.DataSource = clsAttendence.AttendenceData.ToArray();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsAttendence Attend = new clsAttendence();
            try
            {
                Attend.EmployeeID = Convert.ToInt32(txt_empid.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Attend.EmployeeDaysOnTime = Convert.ToInt32(txtDOT.Text);
            Attend.EmployeeDaysLate = Convert.ToInt32(txtDL.Text);
            Attend.EmployeeAbsent = Convert.ToInt32(txtDA.Text);
            Attend.EmployeeSalaryMonth = com_mont.Text;
            Attend.EmployeeSalaryYear = Convert.ToInt32(txt_salary.Text);
            Attend.Update();
            dgvAttendance.DataSource = clsAttendence.AttendenceData.ToArray();
            Clear();
        }

        private void btnRetrieve2_Click(object sender, EventArgs e)
        {
            int idx;
            clsAttendence Attend = new clsAttendence();
            clsHiring hir = new clsHiring();
            try
            {
                Attend.EmployeeID = Convert.ToInt32(txt_empid.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            idx = Attend.Retrieve();
            if (idx == -1)
            {
                MessageBox.Show("Record not found");
                return;
            }

            lblemname.Text = Attend.EmployeeName.ToString();
            lblsalary.Text = Attend.EmployeeBasicPay.ToString();
            txtDOT.Text = Attend.EmployeeDaysOnTime.ToString();
            txtDA.Text = Attend.EmployeeAbsent.ToString();
            txtDL.Text = Attend.EmployeeDaysLate.ToString();
            com_mont.Text = Attend.EmployeeSalaryMonth.ToString();
            txt_salary.Text = Attend.EmployeeSalaryYear.ToString();
        }

        private void btn_btm_Click(object sender, EventArgs e)
        {

            this.Hide();
            dashboard form = new dashboard();
            form.Show();
        }

        private void txt_empid_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDOT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDL_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvAttendance_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void com_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

     

    }
}
