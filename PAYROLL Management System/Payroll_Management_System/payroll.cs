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
    public partial class payroll : Form
    {
        public payroll()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            int idx1;
            clsHiring hir = new clsHiring();
            ClsRecuitment rec = new ClsRecuitment();
           // classRecruitment rec = new classRecruitment();
            clsAttendence att = new clsAttendence();
           // Payroll pay = new Payroll();
            try
            {
                hir.Employeeid = Convert.ToInt32(comboBox1.Text);
                att.EmployeeID = Convert.ToInt32(comboBox1.Text);

                idx1 = hir.PRetrive();
                idx1 = att.SRetieve();

                if (idx1 == -1)
                {
                    MessageBox.Show("record not found");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            hir.PRetrive();
            lblname.Text = hir.First_Name.ToString();
            lblgander.Text = hir.Gender.ToString();
          //  lblDOB.Text = hir.DOB.ToString();
            lblEmail.Text = hir.E_mail.ToString();
           // lblQulification.Text = hir.Qualification.ToString();
            lblcn.Text = hir.Phone_number.ToString();
            idx1 = att.SRetieve();
            lblabsent.Text = att.EmployeeAbsent.ToString();
            lblbasicpay.Text = att.EmployeeBasicPay.ToString();
            lbldot.Text = att.EmployeeDaysOnTime.ToString();
            lbldl.Text = att.EmployeeDaysLate.ToString();
            lblabsent.Text = att.EmployeeAbsent.ToString();
            lblsm.Text = att.EmployeeSalaryMonth.ToString();
        }

        private void payroll_Load(object sender, EventArgs e)
        {
            clsAttendence att = new clsAttendence();
            clsHiring hir = new clsHiring();
          //  Payroll pay = new Payroll();

            try
            {
                att.LoadXML();
                comboBox1.DataSource = clsAttendence.AttendenceData.ToArray();

                comboBox1.DisplayMember = "EmployeeID";
                comboBox1.ValueMember = "EmployeeID";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Record not found \n" + ex.Message);
            }
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double Basic_pay, DOT, Absent, DL;
            //string Salary_month;
            double salary;



            DL = Convert.ToDouble(lbldl.Text);
            Basic_pay = Convert.ToDouble(lblbasicpay.Text);
            DOT = Convert.ToDouble(lbldot.Text);
            Absent = Convert.ToDouble(lblabsent.Text);



            Absent = Basic_pay / 25;
            DL = DL * 3 / Absent;
            salary = Basic_pay - Absent * DL * DOT;

            lblsalary.Text = salary.ToString("C");

        }

        private void btn_btm_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard form = new dashboard();
            form.Show();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        }
    }

