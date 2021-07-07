using Sales_And_Distribution.Repository.BAL;
using Sales_And_Distribution.Repository.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Sales_And_Distribution
{
    public partial class lbltotalammount : Form
    {
        public lbltotalammount()
        {
            InitializeComponent();
        }
        private void lbltotalammount_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ValidateMaterial();
            //if (txtCusAddress.Text == "" || txtCusName.Text == "" || txtCusPhone.Text == "")
            //{
            //    MessageBox.Show("Please Fill All The Feilds! ");
            //    return;
            //}


            SqlConnection con = new SqlConnection("Data Source=AIZAZ-PC;Initial Catalog=OOP2_ERP;Integrated Security=True;");

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("SELECT c_phone  from CustomerMaster where c_address = '" + txtCusAddress.Text + "' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            DataSet ds1 = new DataSet();
            SqlCommand cmd1 = new SqlCommand("SELECT c_address  from CustomerMaster where c_phone = '" + txtCusPhone.Text + "' ", con);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            int j = ds.Tables[0].Rows.Count;


            if (i > 0 || j > 0)
            {
                MessageBox.Show("Data Already Exist");
                ds.Clear();
                return;

            }
            else
            {
               
 
                if (!ValidateMaterial())
                        
                    return;

                    BAL_Customer bAL_Customer = new BAL_Customer();
                    bAL_Customer.C_Id = Convert.ToInt32(lblCusID.Text);
                    bAL_Customer.C_Name = txtCusName.Text;
                    bAL_Customer.C_phone = txtCusPhone.Text;
                    bAL_Customer.C_Address = txtCusAddress.Text;
                    bAL_Customer.C_PayTerms = rbcash.Checked ? rbcash.Text : rbcard.Text;


                    if (bAL_Customer.C_Id == 0)
                        new DAL_Customer().SaveCustomer(bAL_Customer);
                    else
                    {
                        new DAL_Customer().UpdateCustomer(bAL_Customer);

                    }
                    MessageBox.Show("Customer Saved Successfully");

                    ResetForm();
                    ReloadGrid();
                


            }
        }
            
        
        private bool ValidateMaterial()
        {
            bool Valid = true;
            string Msg = "";
            if (txtCusName.Text == "")
            {
                Msg = "Name required";
                Valid = false;
            }
            else if (txtCusPhone.Text == "")
            {
                Msg = "Phone required";
                Valid = false;
            }
            else if (txtCusAddress.Text == "")
            {
                Msg = "Address required";
                Valid = false;
            }


            if (!Valid)
            {
                MessageBox.Show(Msg);
            }
            return Valid;
        }
        private void ReloadGrid()
        {
            var Customer = new DAL_Customer().GetCustomer();
            GridMaterial.DataSource = Customer;
        }

        private void ResetForm()
        {
            lblCusID.Text = "0";
            txtCusName.Text = "";
            txtCusPhone.Text = "";
            txtCusAddress.Text = "";
            btnSave.Text = "Save";
        }

        private void GridMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
             e.RowIndex >= 0)
            {
                int CustomerID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (e.ColumnIndex == 6)//Delete
                {
                    new DAL_Customer().DeleteCustomer(new BAL_Customer { C_Id = CustomerID });
                    MessageBox.Show("Deleted Successfully");
                }
                else if (e.ColumnIndex == 5)//Update
                {

                    var MaterialByID = new DAL_Customer().GetCustomerByID(new BAL_Customer { C_Id = CustomerID }).Rows[0];
                    lblCusID.Text = MaterialByID["C_Id"].ToString();
                    txtCusName.Text = MaterialByID["C_Name"].ToString();
                    txtCusPhone.Text = MaterialByID["C_phone"].ToString();
                    txtCusAddress.Text = MaterialByID["C_Address"].ToString();

                    string PayCash = MaterialByID["C_PayTerms"].ToString();
                    if (PayCash == "Cash")
                        rbcash.Checked = true;

                    btnSave.Text = "Update";
                }

                ReloadGrid();
            }
        }

        private void lblate_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Main abc = new Main();
            abc.Show();
        }
        

        private void txtCusName_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 32 && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCusPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

         private void txtCusAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 32 && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main abcd = new Main();
            abcd.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }

}
