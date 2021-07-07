using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace LoginForm
{
    public partial class addcoffe : Form
    {

        public addcoffe()
        {
            InitializeComponent();
        }

        //SqlConnection cont = new SqlConnection("Data Source =.; Initial Catalog = Star_lounge; Integrated Security = True");
        //SqlCommand cmd;
        //SqlDataAdapter da;
        //DataTable dt;
        //DataSet ds = new DataSet();
        public void clear()
        {

            txtName.Text = null;
            txtType.Text = null;
            txtQuantity.Text = null;
            txtNetPrice.Text = null;
        }


        private bool ValidateMaterial()
        {
            bool Valid = true;
            string Msg = "";
            if (txtID.Text == "")
            {
                Msg = "ID required";
                Valid = false;
            }
            else if (txtName.Text == "")
            {
                Msg = "Select Coffee Name ";
                Valid = false;
            }
            else if (txtType.Text == "")
            {
                Msg = "Select Coffee Type";
                Valid = false;
            }
            else if (txtQuantity.Text == "")
            {
                Msg = "Select Quantity";
                Valid = false;
            }
            else if (txtNetPrice.Text == "")
            {
                Msg = "Select Net Price ";
                Valid = false;
            }
            if (!Valid)
            {
                MessageBox.Show(Msg);
            }
            return Valid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int number;
            if (int.TryParse(txtQuantity.Text, out number))
            {
                if (number <= 0)
                {
                    MessageBox.Show("0 NotAllowed");
                }

                else if (int.TryParse(txtNetPrice.Text, out number))
                {
                    if (number <= 0)
                    {
                        MessageBox.Show("0 NotAllowed");
                    }

                    //if (txtName.Text == "" || txtType.Text == "")
                    //{ MessageBox.Show("Please Enter"); }

                    //else
                    //{
                    //    cmd = new SqlCommand("Select * From tbl_AddCoffee Where quantity ='" + txtQuantity.Text + "'", cont);
                    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //    da.Fill(ds);
                    //    int i = ds.Tables[0].Rows.Count;
                    //    if (i > 0)
                    //    {
                    //        MessageBox.Show("Duplicate Data");

                    //    }
                    //}

                    if (!ValidateMaterial())
                        return;


                    NewCoffeeCls det = new NewCoffeeCls();
                    {
                        
                            NewCoffeeCls.add("insert into tbl_AddCoffee(coffeename,category, quantity,netprice)values( '" + txtName.Text + "','" + txtType.Text + "','" + txtQuantity.Text + "','" + txtNetPrice.Text + "')");
                            DataSet dset = NewCoffeeCls.dset("select * from tbl_AddCoffee");
                        

                            
                                MessageBox.Show("Add Record Succesfully");
                                txtID.Enabled = true;
                                clear();
                                DgvData.DataSource = dset;
                                DgvData.DataMember = "data";

                            }

                        
                    }
                }


                string strConnString = @"Data Source=DESKTOP-NP8NSQ0\SQLEXPRESS;Initial Catalog=CollegeManagementSystem;Integrated Security=True";
                try
                {
                    string str;
                    SqlCommand com;
                    int count;

                    SqlConnection conn = new SqlConnection(strConnString);
                    str = "select count(*) from Create_Teahcer";
                    com = new SqlCommand(str, conn);
                    conn.Open();
                    count = Convert.ToInt16(com.ExecuteScalar()) + 1;
                    txtID.Text = "" + count;
                    conn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        




        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!ValidateMaterial())
                return;
            NewCoffeeCls det = new NewCoffeeCls();
            try
            {
                NewCoffeeCls.delete("delete from tbl_AddCoffee where  coffeeid='" + txtID.Text + "';");
                DataSet dset = NewCoffeeCls.dset("select * from tbl_AddCoffee");
                MessageBox.Show("Data Deleted Succesfully");
                clear();
                DgvData.DataSource = dset;
                DgvData.DataMember = "data";
                txtID.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            string strConnString = "Data Source=DESKTOP-FUADHO6;Initial Catalog=Star_lounge;Integrated Security=True";
            try
            {
                string str;
                SqlCommand com;
                int count;

                SqlConnection conn = new SqlConnection(strConnString);
                str = "select count(*) from tbl_AddCoffee";
                com = new SqlCommand(str, conn);
                conn.Open();
                count = Convert.ToInt16(com.ExecuteScalar()) + 1;
                txtID.Text = "" + count;
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!ValidateMaterial())
                return;
            NewCoffeeCls det = new NewCoffeeCls();
            try
            {
                NewCoffeeCls.update("update tbl_AddCoffee set  coffeename='" + txtName.Text + "',category='" + txtType.Text + "',quantity='" + txtQuantity.Text + "',netprice='" + txtNetPrice.Text + "' where coffeeid=" + txtID.Text + ";");
                DataSet dset = NewCoffeeCls.dset("select * from tbl_AddCoffee");
                MessageBox.Show("Data Update Succesfully");
                clear();
                DgvData.DataSource = dset;
                DgvData.DataMember = "data";
                txtID.Enabled = true;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            string strConnString = "Data Source=DESKTOP-FUADHO6;Initial Catalog=Star_lounge;Integrated Security=True";
            try
            {
                string str;
                SqlCommand com;
                int count;

                SqlConnection conn = new SqlConnection(strConnString);
                str = "select count(*) from tbl_AddCoffee";
                com = new SqlCommand(str, conn);
                conn.Open();
                count = Convert.ToInt16(com.ExecuteScalar()) + 1;
                txtID.Text = "" + count;
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void btn_retrive_Click(object sender, EventArgs e)
        {
            string source = "server = .; Database = Star_Lounge ; integrated security = true";
            try
            {
                SqlConnection con = new SqlConnection(source);
                con.Open();
                string sqlselectquery = "select * from tbl_AddCoffee where coffeeid  =" + txtID.Text + "";
                SqlCommand cmd = new SqlCommand(sqlselectquery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    txtName.Text = (dr["CoffeeName"].ToString());
                    txtType.Text = (dr["Category"].ToString());
                    txtQuantity.Text = (dr["Quantity"].ToString());
                    txtNetPrice.Text = (dr["NetPrice"].ToString());

                }
                txtID.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addcoffe_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("server = .; Database = Star_Lounge; Integrated Security = True");
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_AddCoffee", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DgvData.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            string strConnString = "Data Source=DESKTOP-FUADHO6;Initial Catalog=Star_lounge;Integrated Security=True";
            try
            {
                string str;
                SqlCommand com;
                int count;

                SqlConnection conn = new SqlConnection(strConnString);
                str = "select count(*) from tbl_AddCoffee";
                com = new SqlCommand(str, conn);
                conn.Open();
                count = Convert.ToInt16(com.ExecuteScalar()) + 1;
                txtID.Text = "" + count;
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"\d");
            if (r.IsMatch(txtName.Text))
            {
                int i = txtName.SelectionStart;
                txtName.Text = r.Replace(txtName.Text, "");
                txtName.SelectionStart = i;
            }

        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "^[0-9]*$"))
            {
                txtQuantity.Text = string.Empty;
            }
        }
        private void txtNetPrice_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNetPrice.Text, "^[0-9]*$"))
            {
                txtNetPrice.Text = string.Empty;
            }
        }
        private void txtType_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"\d");
            if (r.IsMatch(txtType.Text))
            {
                int i = txtType.SelectionStart;
                txtType.Text = r.Replace(txtType.Text, "");
                txtType.SelectionStart = i;
            }
        }
    }
}

