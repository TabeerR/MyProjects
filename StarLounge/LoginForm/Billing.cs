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

namespace LoginForm

{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            try
            {


                BillingClass bilcls = new BillingClass();
                BillingClass.add("insert into tbl_billing(selectcoffeedrink,category,quantity,netprice,discount,totalamount,finalamount,date,time)values ('" + txt_SelectCoffeeD.Text + "' ,'" + txt_Category.Text + "','" + txt_Quantity.Text + "','" + txt_NetPrice.Text + "','" + txtdiscount.Text + "','" + txt_TotalAmount.Text + "', '" + txt_FinalAmount.Text + "','" +txtDate.Text + "','" + txtTime.Text + "')");
                DataSet dset = BillingClass.dset("select * from tbl_billing");
                MessageBox.Show("Add Record Succesfully");
                
                dgvBilling.DataSource = dset;
                dgvBilling.DataMember = "data";
                
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void cmbCoffeeName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {


            string source = "Data Source=.;Initial Catalog=Star_lounge;Integrated Security=True";
            try
            {
                SqlConnection con = new SqlConnection(source);
                con.Open();
                string sqlselectquery = "select * from tbl_OrderHere where orderid  =" + cmbOrderID.Text + "";
                SqlCommand cmd = new SqlCommand(sqlselectquery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    txt_SelectCoffeeD.Text = (dr["coffeetype"].ToString());
                    txt_Category.Text = (dr["category"].ToString());
                    txt_Quantity.Text = (dr["quantity"].ToString());
                    txt_NetPrice.Text = (dr["netprice"].ToString());

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void Billing_Load(object sender, EventArgs e)
        {
            txtbillingID.Enabled = false;

            SqlConnection con = new SqlConnection("server = .; Database = Star_Lounge; integrated security = true");
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select orderid from tbl_OrderHere", con);
                DataSet dsa = new DataSet();
                da.Fill(dsa);
                cmbOrderID.DataSource = dsa.Tables[0];
                cmbOrderID.DisplayMember = "orderid";
                cmbOrderID.ValueMember = "orderid";
                txtTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                txtDate.Text = DateTime.Now.ToString("dd MMMM,yyyy");


                string str = @"select count(*) from tbl_billing";

                SqlCommand cmd = new SqlCommand(str, con);
                int i = (int)cmd.ExecuteScalar();
                i++;
                txtbillingID.Text = i.ToString();

                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_billingid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_NetPrice_TextChanged(object sender, EventArgs e)
        {
            txt_TotalAmount.Text = Convert.ToString(Convert.ToInt32(txt_Quantity.Text) * Convert.ToInt32(txt_NetPrice.Text));
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double originalPrice, discountPercentage, discountAmount, salePrice;

                // Get item's original price.
                originalPrice = double.Parse(txt_TotalAmount.Text);

                // Get discount percentage.
                discountPercentage = double.Parse(txtdiscount.Text);

                // Create decimal representation of %  (move point left two places)
                discountPercentage = discountPercentage / 100;

                // Calculate amount of the discount.
                discountAmount = originalPrice * discountPercentage;

                // Calculate sale price.
                salePrice = originalPrice - discountAmount;


                txt_FinalAmount.Text = salePrice.ToString();
            }
            catch  (Exception ex)
            {

                MessageBox.Show("Enter Discount Amount");
            }

        }
    }
}
