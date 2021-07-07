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
    public partial class selection : Form
    {
        public selection()
        {
            InitializeComponent();
        }

        private void selection_Load(object sender, EventArgs e)
        {
            clsSelection sel = new clsSelection();
            ClsRecuitment myrec = new ClsRecuitment();
            try
            {
                myrec.loadXML();
               //mysel.LoadXML();
                //sel.LoadXML();
                comb_cand_Id.DataSource = ClsRecuitment.Recdat.ToArray();
                comb_cand_Id.DisplayMember = "Candidate_id";
                comb_cand_Id.ValueMember = "Candidate_id";
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record not loaded\n" + ex.Message);
                return;
            }
            sel.LoadXML();
            dvgSelection.DataSource = clsSelection.SelectionData.ToArray();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ClsRecuitment rec = new ClsRecuitment();
          //  classRecruitment rec = new classRecruitment();
            clsSelection mysel = new clsSelection();
            try
            {
                if (comb_cand_Id.Text == "" && txtemp.Text == "")
                {
                    MessageBox.Show("Ops! Field Are Empty..\nFill the Fields which is Essential to Update");
                }
                else
                {
                    int idx;
                    mysel.Candidate_id = (comb_cand_Id.Text);
                    mysel.Employeeid = (txtemp.Text);
                    rec.Candidate_id = mysel.Candidate_id;
                    idx = rec.Retrieve();
                    mysel.First_Name = rec.First_Name;
                    mysel.Address = rec.Address;
                    mysel.City = rec.City;
                    mysel.Country = rec.Country;
                    mysel.Department = rec.Department;
                    mysel.E_mail = rec.E_mail;
                    mysel.Gender = rec.Gender;
                    mysel.Last_Name = rec.Last_Name;
                    mysel.Phone_number = rec.Phone_number;

                    mysel.CreateSel();
                    dvgSelection.DataSource = clsSelection.SelectionData.ToArray();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btn_selsave_Click(object sender, EventArgs e)
        {
            clsSelection sel = new clsSelection();
            sel.SaveXLM();
            MessageBox.Show("SAVE DATA");
            dvgSelection.DataSource = clsSelection.SelectionData.ToArray();
        }

        private void btn_selback_Click(object sender, EventArgs e)
        {
            this.Hide();
           recruitment form = new recruitment();
            form.Show();
        }

        private void btn_seldel_Click(object sender, EventArgs e)
        {
            int idx;
            ClsRecuitment r = new ClsRecuitment();
           // classRecruitment myrec = new classRecruitment();
            clsSelection mysel = new clsSelection();
            try
            {
                mysel.Candidate_id = comb_cand_Id.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            idx = mysel.DeleteS();
            if (idx == -1)
                MessageBox.Show("Record Not Found");
            dvgSelection.DataSource = clsSelection.SelectionData.ToArray();
            
        }

     
        private void btnhire_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Hiring h = new Hiring();
            h.ShowDialog();
        }

        private void txtemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dvgSelection_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
