using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LoginForm
{
    public partial class BillingForm : Form
    {

        public BillingForm()
        {
            InitializeComponent();
        }
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        int IRow;


        Double amnt, total = 0;
        int qntity, rte = 0;
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(lblRaaate.Text, out rte))
                if (int.TryParse(txtQuantity.Text, out qntity))
                    amnt = rte * qntity;
            lblamt.Text = amnt.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtBilling.Rows.Add(cmbCustomer.Text, cmbProductNme.Text, rte, qntity, amnt);

            cmbProductNme.Text = "";
            lblRaaate.Text = "";
            txtQuantity.Text = "";
            lblamt.Text = "0";
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtBilling.Rows.Count; i++)
            {
                total += Convert.ToDouble(dtBilling.Rows[i].Cells["Amount"].Value);
            }
            lblTotal.Text = total.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            dtBilling.Rows.RemoveAt(dtBilling.Rows[0].Index);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cmbCustomer.Text = "";
            cmbProductNme.Text = "";
            lblamt.Text = "0";
            lblTotal.Text = "0";
            lblRaaate.Text = "0";
            txtQuantity.Text = "";
            dtBilling.DataSource = null;
            dtBilling.Rows.Clear();
            dtBilling.Refresh();
        }

        private void cmbCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 32 && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            populateCustomer();
            populateProduct();


        }

        private void populateProduct()
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\Aizzy\Documents\Products.xls");
            xlWorkSheet = xlWorkBook.Worksheets["sheet1"];

            for (IRow = 1; IRow <= xlWorkSheet.Rows.Count; IRow++)
            {
                if (xlWorkSheet.Cells[IRow, 1].value == null)
                {
                    break;
                }
                else
                {               // POPULATE COMBO BOX.
                    cmbProductNme.Items.Add(xlWorkSheet.Cells[IRow, 2].value);
                }
            }
            xlWorkBook.Close();
            xlApp.Quit();
        }

        private void populateCustomer()
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\Aizzy\Documents\Customer.xls");
            xlWorkSheet = xlWorkBook.Worksheets["sheet1"];

            for (IRow = 1; IRow <= xlWorkSheet.Rows.Count; IRow++)
            {
                if (xlWorkSheet.Cells[IRow, 1].value == null)
                {
                    break;
                }
                else
                {               // POPULATE COMBO BOX.
                    cmbCustomer.Items.Add(xlWorkSheet.Cells[IRow, 1].value);
                }
            }
            xlWorkBook.Close();
            xlApp.Quit();
        }



        private void SelectRate(string productName)
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\Aizzy\Documents\Products.xls");
            xlWorkSheet = xlWorkBook.Worksheets["sheet1"];

            for (IRow = 1; IRow <= xlWorkSheet.Rows.Count; IRow++)
            {
                if (xlWorkSheet.Cells[IRow, 1].value == null)
                {
                    break;
                }
                else
                    if (xlWorkSheet.Cells[IRow, 2].value == productName)
                    {
                        lblRaaate.Text = xlWorkSheet.Cells[IRow, 3].Value2.ToString();
                    }
            }
            xlWorkBook.Close();
            xlApp.Quit();
        }

        private void cmbProductNme_SelectedValueChanged(object sender, EventArgs e)
        {
            int f = cmbProductNme.SelectedIndex;
            SelectRate(cmbProductNme.Items[f].ToString());
        }
    }
}




