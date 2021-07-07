using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace LoginForm
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int selectedRow;

        private void Customer_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("PhoneNumber", typeof(double));
            dt.Columns.Add("Categories", typeof(string));
            dt.Columns.Add("Address", typeof(string));

            DgCustomer.DataSource = dt;


            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Aizzy\Documents\Customers.xls");
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            // dt.Column = colCount;  
            DgCustomer.ColumnCount = colCount;
            DgCustomer.RowCount = rowCount;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {


                    //write the value to the Grid  


                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        DgCustomer.Rows[i - 1].Cells[j - 1].Value = xlRange.Cells[i, j].Value2.ToString();
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string pr_name = txtName.Text;
            string pr_phoneno = txtPhoneNum.Text;
            string catog = cmbCategories.Text;
            string address = txtAddress.Text;

            dt.Rows.Add(pr_name, pr_phoneno, catog, address);
            
            DgCustomer.DataSource = dt;
            
            MessageBox.Show("Customer Added Successfully");

            txtName.Text = "";
            txtPhoneNum.Text = "";
            cmbCategories.Text = "";
            txtAddress.Text = "";
        }

        private void DgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = DgCustomer.Rows[selectedRow];
            txtName.Text = row.Cells[0].Value.ToString();
            txtPhoneNum.Text = row.Cells[1].Value.ToString();
            cmbCategories.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = DgCustomer.Rows[selectedRow];
            newDataRow.Cells[0].Value = txtName.Text;
            newDataRow.Cells[1].Value = txtPhoneNum.Text;
            newDataRow.Cells[2].Value = cmbCategories.Text;
            newDataRow.Cells[3].Value = txtAddress.Text;
            MessageBox.Show("Customer Updated Succesfully");

            txtName.Text = "";
            txtPhoneNum.Text = "";
            cmbCategories.Text = "";
            txtAddress.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedRow = DgCustomer.CurrentCell.RowIndex;
            DgCustomer.Rows.RemoveAt(selectedRow);
            MessageBox.Show("Customer Deleted Succesfully");

            txtName.Text = "";
            txtPhoneNum.Text = "";
            cmbCategories.Text = "";
            txtAddress.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            int i = 0;
            int j = 0;

            for (i = 0; i <= DgCustomer.RowCount - 1; i++)
            {
                for (j = 0; j <= DgCustomer.ColumnCount - 1; j++)
                {

                    DataGridViewCell cell = DgCustomer[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs("Customers", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Excel file created");
        }

        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 32 && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}