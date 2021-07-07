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

namespace Sales_And_Distribution
{
    public partial class Material_Master_Data_Form : Form
    {
        public Material_Master_Data_Form()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Material_Master_Data_Form_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void ReloadGrid()
        {
            var Materials = new DAL_Material().GetMaterial();
            GridMaterial.DataSource = Materials;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "" || Convert.ToInt32(txtQuantity.Text) <= 0 || txtName.Text == "" || txtStorageLoc.Text == "")
            {
                MessageBox.Show("Please Fill All The Feidls! ");
                return;
            }
            else
            {
                if (!ValidateMaterial())
                    return;

                BAL_Material bAL_Material = new BAL_Material();
                bAL_Material.M_Id = Convert.ToInt32(lblID.Text);
                bAL_Material.M_Name = txtName.Text;
                bAL_Material.M_Quantity = Convert.ToInt32(txtQuantity.Text);
                bAL_Material.StorageLoc = txtStorageLoc.Text;
                if (bAL_Material.M_Id == 0)
                    new DAL_Material().SaveMaterial(bAL_Material);
                else
                {
                    new DAL_Material().UpdateMaterial(bAL_Material);

                }
                MessageBox.Show("Material Saved Successfully");

                ResetForm();
                ReloadGrid();
            }
            
        }

        private bool ValidateMaterial()
        {
            bool Valid = true;
            string Msg = "";
            if (txtName.Text == "")
            {
                Msg = "Name required";
                Valid = false;
            }
            else if (txtQuantity.Text == "")
            {
                Msg = "Quantity required";
                Valid = false;
            }
            else if (txtStorageLoc.Text == "")
            {
                Msg = "StorageLock required";
                Valid = false;
            }


            if (!Valid)
            {
                MessageBox.Show(Msg);
            }
            return Valid;
        }
        
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
             e.RowIndex >= 0)
            {
                int MaterialID =Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (e.ColumnIndex == 5)//Delete
                {
                    new DAL_Material().DeleteMaterial(new BAL_Material { M_Id = MaterialID });
                    MessageBox.Show("Deleted Successfully");
                }
                else if (e.ColumnIndex == 4)//Update
                {
              
                    var MaterialByID = new DAL_Material().GetMaterialByID(new BAL_Material { M_Id = MaterialID }).Rows[0];
                    lblID.Text = MaterialByID["M_Id"].ToString();
                    txtName.Text = MaterialByID["M_Name"].ToString();
                    txtQuantity.Text = MaterialByID["M_Quantity"].ToString();
                    txtStorageLoc.Text = MaterialByID["StorageLoc"].ToString();
                    
                    btnSave.Text = "Update";
                }

                ReloadGrid();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
            
        }

        private void ResetForm()
        {
            lblID.Text = "0";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtStorageLoc.Text = "";
            btnSave.Text = "Save";
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 32 && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtStorageLock_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 32 && ch != 8)
            {
                e.Handled = true;
            }
        }
        


        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main ab = new Main();
            ab.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
