namespace LoginForm
{
    partial class BillingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lblRaaate = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbProductNme = new System.Windows.Forms.ComboBox();
            this.lblamt = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQntity = new System.Windows.Forms.Label();
            this.lblRte = new System.Windows.Forms.Label();
            this.lblprdctNm = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtBilling = new System.Windows.Forms.DataGridView();
            this.Cstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrdctName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAmnt = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnDlt = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.BackColor = System.Drawing.SystemColors.Control;
            this.grpBox.Controls.Add(this.lblRaaate);
            this.grpBox.Controls.Add(this.cmbCustomer);
            this.grpBox.Controls.Add(this.cmbProductNme);
            this.grpBox.Controls.Add(this.lblamt);
            this.grpBox.Controls.Add(this.btnClose);
            this.grpBox.Controls.Add(this.btnAdd);
            this.grpBox.Controls.Add(this.lblAmount);
            this.grpBox.Controls.Add(this.txtQuantity);
            this.grpBox.Controls.Add(this.lblQntity);
            this.grpBox.Controls.Add(this.lblRte);
            this.grpBox.Controls.Add(this.lblprdctNm);
            this.grpBox.Controls.Add(this.lblCustName);
            this.grpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox.Location = new System.Drawing.Point(9, 27);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(740, 266);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Product Details";
            // 
            // lblRaaate
            // 
            this.lblRaaate.AutoSize = true;
            this.lblRaaate.Location = new System.Drawing.Point(130, 105);
            this.lblRaaate.Name = "lblRaaate";
            this.lblRaaate.Size = new System.Drawing.Size(16, 16);
            this.lblRaaate.TabIndex = 103;
            this.lblRaaate.Text = "0";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(133, 27);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 24);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCustomer_KeyPress);
            // 
            // cmbProductNme
            // 
            this.cmbProductNme.FormattingEnabled = true;
            this.cmbProductNme.Location = new System.Drawing.Point(469, 31);
            this.cmbProductNme.Name = "cmbProductNme";
            this.cmbProductNme.Size = new System.Drawing.Size(139, 24);
            this.cmbProductNme.TabIndex = 2;
            this.cmbProductNme.SelectedValueChanged += new System.EventHandler(this.cmbProductNme_SelectedValueChanged);
            // 
            // lblamt
            // 
            this.lblamt.AutoSize = true;
            this.lblamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamt.Location = new System.Drawing.Point(129, 165);
            this.lblamt.Name = "lblamt";
            this.lblamt.Size = new System.Drawing.Size(19, 20);
            this.lblamt.TabIndex = 13;
            this.lblamt.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(628, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 26);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Items";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(27, 165);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(88, 24);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(469, 102);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(139, 22);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQntity
            // 
            this.lblQntity.AutoSize = true;
            this.lblQntity.Location = new System.Drawing.Point(338, 108);
            this.lblQntity.Name = "lblQntity";
            this.lblQntity.Size = new System.Drawing.Size(68, 16);
            this.lblQntity.TabIndex = 3;
            this.lblQntity.Text = "Quantity:";
            // 
            // lblRte
            // 
            this.lblRte.AutoSize = true;
            this.lblRte.Location = new System.Drawing.Point(9, 105);
            this.lblRte.Name = "lblRte";
            this.lblRte.Size = new System.Drawing.Size(45, 16);
            this.lblRte.TabIndex = 2;
            this.lblRte.Text = "Rate:";
            // 
            // lblprdctNm
            // 
            this.lblprdctNm.AutoSize = true;
            this.lblprdctNm.Location = new System.Drawing.Point(338, 35);
            this.lblprdctNm.Name = "lblprdctNm";
            this.lblprdctNm.Size = new System.Drawing.Size(110, 16);
            this.lblprdctNm.TabIndex = 1;
            this.lblprdctNm.Text = "Product Name:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(9, 35);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(118, 16);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Customer Name";
            // 
            // btnBill
            // 
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(659, 454);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(87, 30);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dtBilling);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Billing";
            // 
            // dtBilling
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtBilling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cstname,
            this.PrdctName,
            this.rate,
            this.Quantity,
            this.Amount});
            this.dtBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtBilling.Location = new System.Drawing.Point(3, 18);
            this.dtBilling.Name = "dtBilling";
            this.dtBilling.Size = new System.Drawing.Size(734, 131);
            this.dtBilling.TabIndex = 0;
            // 
            // Cstname
            // 
            this.Cstname.HeaderText = "CustomerName";
            this.Cstname.Name = "Cstname";
            // 
            // PrdctName
            // 
            this.PrdctName.HeaderText = "ProductName";
            this.PrdctName.Name = "PrdctName";
            // 
            // rate
            // 
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // lblTotalAmnt
            // 
            this.lblTotalAmnt.AutoSize = true;
            this.lblTotalAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmnt.Location = new System.Drawing.Point(11, 454);
            this.lblTotalAmnt.Name = "lblTotalAmnt";
            this.lblTotalAmnt.Size = new System.Drawing.Size(140, 24);
            this.lblTotalAmnt.TabIndex = 16;
            this.lblTotalAmnt.Text = "Total Amount:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(157, 457);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 24);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "0";
            // 
            // btnDlt
            // 
            this.btnDlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlt.Location = new System.Drawing.Point(578, 454);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(75, 30);
            this.btnDlt.TabIndex = 18;
            this.btnDlt.Text = "Delete";
            this.btnDlt.UseVisualStyleBackColor = true;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(497, 454);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 30);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 496);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalAmnt);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingForm";
            this.Text = "BillingSystem";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQntity;
        private System.Windows.Forms.Label lblRte;
        private System.Windows.Forms.Label lblprdctNm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtBilling;
        private System.Windows.Forms.Label lblTotalAmnt;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblamt;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrdctName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.ComboBox cmbProductNme;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblRaaate;
    }
}