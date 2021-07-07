using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


namespace Payroll_Management_System
{
    public partial class recruitment : Form
    {
        public recruitment()
        {
            InitializeComponent();
        }



        public void clear()
        {
            txtbox_add.Text = "";
            txtbox_fname.Text = "";
            txtbox_id.Text = "";
            txtbox_lname.Text = "";
            txtbox_mail.Text = "";
            txtbox_pnum.Text = "";
            com_dep.Text = "";
            txt_country.Text = "";
            comb_gender.Text = "";
            combo_city.Text = "";


        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            ClsRecuitment rec = new ClsRecuitment();
            try
            {
                rec.Candidate_id = txtbox_id.Text;
                rec.First_Name = txtbox_fname.Text;
                rec.Last_Name = txtbox_lname.Text;      
                rec.Address = txtbox_add.Text;
                rec.City = combo_city.Text;
                rec.Country = txt_country.Text;
                rec.E_mail = txtbox_mail.Text;
                rec.Phone_number = txtbox_pnum.Text;
                rec.Department = com_dep.Text;
                rec.Gender = comb_gender.Text;


                rec.Add();
                dvgRec.DataSource = ClsRecuitment.Recdat.ToArray();
                MessageBox.Show("ADD DATA");
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_btm_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard form = new dashboard();
            form.Show();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {

            int idx;
            ClsRecuitment rec = new ClsRecuitment();
            try
            {
                rec.Candidate_id = txtbox_id.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            idx = rec.Delete();
            dvgRec.DataSource = ClsRecuitment.Recdat.ToArray();
            MessageBox.Show("DELETE DATA");
            clear();
        }

        private void btn_ret_Click(object sender, EventArgs e)
        {
            int idx;
            ClsRecuitment rec = new ClsRecuitment();
            try
            {
                rec.Candidate_id = txtbox_id.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            idx = rec.Retrieve();
            if (idx == -1)
            {
                MessageBox.Show("Record not found");
                return;
            }
            txtbox_id.Text = rec.Candidate_id.ToString();
            txtbox_fname.Text = rec.First_Name.ToString();
            txtbox_lname.Text = rec.Last_Name.ToString();
            txtbox_add.Text = rec.Address.ToString();
            combo_city.Text = rec.City.ToString();
            txt_country.Text = rec.Country.ToString();
            txtbox_mail.Text= rec.E_mail.ToString();
            txtbox_pnum.Text = rec.Phone_number.ToString();
            com_dep.Text = rec.Department.ToString();
            comb_gender.Text = rec.Gender.ToString();


        }


        private void txtbox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbox_pnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbox_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbox_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

     

        private void btn_update_Click(object sender, EventArgs e)
        {
            ClsRecuitment rec = new ClsRecuitment();
            try
            {
                rec.Candidate_id = txtbox_id.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            rec.Candidate_id = txtbox_id.Text.ToString();
            rec.First_Name = txtbox_fname.Text.ToString();
            rec.Last_Name = txtbox_lname.Text.ToString();
            rec.Address = txtbox_add.Text.ToString();
            rec.City = combo_city.Text.ToString();
            rec.Country = txt_country.Text.ToString();
            rec.E_mail = txtbox_mail.Text.ToString();
            rec.Phone_number =  txtbox_pnum.Text .ToString();
            rec.Department = com_dep.Text.ToString();
            rec.Gender = comb_gender.Text.ToString();

            rec.Update();
            dvgRec.DataSource = ClsRecuitment.Recdat.ToArray();

        }

        private void dvgRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void recruitment_Load(object sender, EventArgs e)
        {
            ClsRecuitment rec = new ClsRecuitment();
            rec.loadXML();
            dvgRec.DataSource = ClsRecuitment.Recdat.ToArray();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            ClsRecuitment rec = new ClsRecuitment();
            rec.saveXLM();
            MessageBox.Show("SAVE DATA");
            dvgRec.DataSource = ClsRecuitment.Recdat.ToArray();


        }

        private void btn_sel_Click(object sender, EventArgs e)
        {
            this.Hide();
            selection s = new selection();
            s.ShowDialog();
        }

       

        private void txt_country_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dvgRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
