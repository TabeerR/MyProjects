namespace LoginForm
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.cmbOrderID = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCategory = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCoffee = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblnetprice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTotalAmount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Discount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_FinalAmount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_bill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_BillingId = new System.Windows.Forms.Label();
            this.lbl_NetPrice = new System.Windows.Forms.Label();
            this.lbl_FAount = new System.Windows.Forms.Label();
            this.txtdiscount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtbillingID = new System.Windows.Forms.TextBox();
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            this.txt_FinalAmount = new System.Windows.Forms.TextBox();
            this.txt_SelectCoffeeD = new System.Windows.Forms.TextBox();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_NetPrice = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOrderID
            // 
            this.cmbOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrderID.FormattingEnabled = true;
            this.cmbOrderID.Location = new System.Drawing.Point(160, 71);
            this.cmbOrderID.Name = "cmbOrderID";
            this.cmbOrderID.Size = new System.Drawing.Size(143, 21);
            this.cmbOrderID.TabIndex = 18;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(18, 265);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(54, 13);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(21, 225);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 13);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Category";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffee.Location = new System.Drawing.Point(18, 189);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(118, 13);
            this.lblCoffee.TabIndex = 15;
            this.lblCoffee.Text = "Select Coffee Drink";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(18, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(53, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "Order Id";
            // 
            // lblnetprice
            // 
            this.lblnetprice.AutoSize = true;
            this.lblnetprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnetprice.Location = new System.Drawing.Point(18, 308);
            this.lblnetprice.Name = "lblnetprice";
            this.lblnetprice.Size = new System.Drawing.Size(60, 13);
            this.lblnetprice.TabIndex = 22;
            this.lblnetprice.Text = "Net Price";
            // 
            // dgvBilling
            // 
            this.dgvBilling.Location = new System.Drawing.Point(64, 337);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.Size = new System.Drawing.Size(600, 150);
            this.dgvBilling.TabIndex = 43;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(249, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(233, 42);
            this.bunifuCustomLabel3.TabIndex = 25;
            this.bunifuCustomLabel3.Text = "Star Lounge";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(400, 175);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(82, 13);
            this.lblTotalAmount.TabIndex = 27;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(400, 141);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(57, 13);
            this.lbl_Discount.TabIndex = 31;
            this.lbl_Discount.Text = "Discount";
            // 
            // lbl_FinalAmount
            // 
            this.lbl_FinalAmount.AutoSize = true;
            this.lbl_FinalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FinalAmount.Location = new System.Drawing.Point(400, 217);
            this.lbl_FinalAmount.Name = "lbl_FinalAmount";
            this.lbl_FinalAmount.Size = new System.Drawing.Size(80, 13);
            this.lbl_FinalAmount.TabIndex = 33;
            this.lbl_FinalAmount.Text = "Final Amount";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(400, 265);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(34, 13);
            this.bunifuCustomLabel6.TabIndex = 35;
            this.bunifuCustomLabel6.Text = "Date";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(21, 154);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(56, 13);
            this.bunifuCustomLabel2.TabIndex = 39;
            this.bunifuCustomLabel2.Text = "Billing Id";
            // 
            // btn_bill
            // 
            this.btn_bill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_bill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bill.BorderRadius = 0;
            this.btn_bill.ButtonText = "Bill";
            this.btn_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bill.DisabledColor = System.Drawing.Color.Gray;
            this.btn_bill.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_bill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_bill.Iconimage")));
            this.btn_bill.Iconimage_right = null;
            this.btn_bill.Iconimage_right_Selected = null;
            this.btn_bill.Iconimage_Selected = null;
            this.btn_bill.IconMarginLeft = 0;
            this.btn_bill.IconMarginRight = 0;
            this.btn_bill.IconRightVisible = true;
            this.btn_bill.IconRightZoom = 0D;
            this.btn_bill.IconVisible = true;
            this.btn_bill.IconZoom = 90D;
            this.btn_bill.IsTab = false;
            this.btn_bill.Location = new System.Drawing.Point(507, 493);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_bill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_bill.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_bill.selected = false;
            this.btn_bill.Size = new System.Drawing.Size(157, 48);
            this.btn_bill.TabIndex = 41;
            this.btn_bill.Text = "Bill";
            this.btn_bill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bill.Textcolor = System.Drawing.Color.White;
            this.btn_bill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btnload
            // 
            this.btnload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnload.BorderRadius = 0;
            this.btnload.ButtonText = "Load";
            this.btnload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnload.DisabledColor = System.Drawing.Color.Gray;
            this.btnload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnload.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnload.Iconimage")));
            this.btnload.Iconimage_right = null;
            this.btnload.Iconimage_right_Selected = null;
            this.btnload.Iconimage_Selected = null;
            this.btnload.IconMarginLeft = 0;
            this.btnload.IconMarginRight = 0;
            this.btnload.IconRightVisible = true;
            this.btnload.IconRightZoom = 0D;
            this.btnload.IconVisible = true;
            this.btnload.IconZoom = 90D;
            this.btnload.IsTab = false;
            this.btnload.Location = new System.Drawing.Point(403, 66);
            this.btnload.Name = "btnload";
            this.btnload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnload.selected = false;
            this.btnload.Size = new System.Drawing.Size(126, 26);
            this.btnload.TabIndex = 44;
            this.btnload.Text = "Load";
            this.btnload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnload.Textcolor = System.Drawing.Color.White;
            this.btnload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // lbl_BillingId
            // 
            this.lbl_BillingId.AutoSize = true;
            this.lbl_BillingId.Location = new System.Drawing.Point(337, 135);
            this.lbl_BillingId.Name = "lbl_BillingId";
            this.lbl_BillingId.Size = new System.Drawing.Size(0, 13);
            this.lbl_BillingId.TabIndex = 45;
            // 
            // lbl_NetPrice
            // 
            this.lbl_NetPrice.AutoSize = true;
            this.lbl_NetPrice.Location = new System.Drawing.Point(333, 308);
            this.lbl_NetPrice.Name = "lbl_NetPrice";
            this.lbl_NetPrice.Size = new System.Drawing.Size(0, 13);
            this.lbl_NetPrice.TabIndex = 49;
            // 
            // lbl_FAount
            // 
            this.lbl_FAount.AutoSize = true;
            this.lbl_FAount.Location = new System.Drawing.Point(697, 222);
            this.lbl_FAount.Name = "lbl_FAount";
            this.lbl_FAount.Size = new System.Drawing.Size(0, 13);
            this.lbl_FAount.TabIndex = 50;
            // 
            // txtdiscount
            // 
            this.txtdiscount.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtdiscount.Location = new System.Drawing.Point(539, 138);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(143, 20);
            this.txtdiscount.TabIndex = 52;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // txtbillingID
            // 
            this.txtbillingID.Location = new System.Drawing.Point(160, 143);
            this.txtbillingID.Name = "txtbillingID";
            this.txtbillingID.Size = new System.Drawing.Size(143, 20);
            this.txtbillingID.TabIndex = 55;
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.Enabled = false;
            this.txt_TotalAmount.Location = new System.Drawing.Point(539, 172);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.Size = new System.Drawing.Size(143, 20);
            this.txt_TotalAmount.TabIndex = 57;
            // 
            // txt_FinalAmount
            // 
            this.txt_FinalAmount.Enabled = false;
            this.txt_FinalAmount.Location = new System.Drawing.Point(539, 217);
            this.txt_FinalAmount.Name = "txt_FinalAmount";
            this.txt_FinalAmount.Size = new System.Drawing.Size(143, 20);
            this.txt_FinalAmount.TabIndex = 58;
            // 
            // txt_SelectCoffeeD
            // 
            this.txt_SelectCoffeeD.Enabled = false;
            this.txt_SelectCoffeeD.Location = new System.Drawing.Point(160, 182);
            this.txt_SelectCoffeeD.Name = "txt_SelectCoffeeD";
            this.txt_SelectCoffeeD.Size = new System.Drawing.Size(143, 20);
            this.txt_SelectCoffeeD.TabIndex = 59;
            // 
            // txt_Category
            // 
            this.txt_Category.Enabled = false;
            this.txt_Category.Location = new System.Drawing.Point(160, 222);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(143, 20);
            this.txt_Category.TabIndex = 60;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Enabled = false;
            this.txt_Quantity.Location = new System.Drawing.Point(160, 262);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(143, 20);
            this.txt_Quantity.TabIndex = 61;
            // 
            // txt_NetPrice
            // 
            this.txt_NetPrice.Enabled = false;
            this.txt_NetPrice.Location = new System.Drawing.Point(160, 301);
            this.txt_NetPrice.Name = "txt_NetPrice";
            this.txt_NetPrice.Size = new System.Drawing.Size(143, 20);
            this.txt_NetPrice.TabIndex = 62;
            this.txt_NetPrice.TextChanged += new System.EventHandler(this.txt_NetPrice_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(539, 262);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(143, 20);
            this.txtDate.TabIndex = 63;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(400, 304);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 64;
            this.lblTime.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(539, 301);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 65;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(764, 545);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txt_NetPrice);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Category);
            this.Controls.Add(this.txt_SelectCoffeeD);
            this.Controls.Add(this.txt_FinalAmount);
            this.Controls.Add(this.txt_TotalAmount);
            this.Controls.Add(this.txtbillingID);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.lbl_FAount);
            this.Controls.Add(this.lbl_NetPrice);
            this.Controls.Add(this.lbl_BillingId);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btn_bill);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.lbl_FinalAmount);
            this.Controls.Add(this.lbl_Discount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.dgvBilling);
            this.Controls.Add(this.lblnetprice);
            this.Controls.Add(this.cmbOrderID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbOrderID;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQuantity;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCoffee;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private Bunifu.Framework.UI.BunifuCustomLabel lblnetprice;
        private System.Windows.Forms.DataGridView dgvBilling;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotalAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Discount;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_FinalAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_bill;
        private Bunifu.Framework.UI.BunifuFlatButton btnload;
        private System.Windows.Forms.Label lbl_BillingId;
        private System.Windows.Forms.Label lbl_NetPrice;
        private System.Windows.Forms.Label lbl_FAount;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtdiscount;
        private System.Windows.Forms.TextBox txtbillingID;
        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.TextBox txt_FinalAmount;
        private System.Windows.Forms.TextBox txt_SelectCoffeeD;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_NetPrice;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
    }
}