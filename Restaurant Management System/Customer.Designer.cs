namespace LoginForm
{
    partial class Customer
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.DgCustomer = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(23, 95);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(71, 16);
            this.lblPhoneNum.TabIndex = 1;
            this.lblPhoneNum.Text = "Phone No:";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(23, 130);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(74, 16);
            this.lblCategories.TabIndex = 2;
            this.lblCategories.Text = "Categories";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(23, 165);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 16);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(100, 95);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(124, 20);
            this.txtPhoneNum.TabIndex = 2;
            this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNum_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(100, 162);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(452, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // DgCustomer
            // 
            this.DgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCustomer.Location = new System.Drawing.Point(26, 268);
            this.DgCustomer.Name = "DgCustomer";
            this.DgCustomer.Size = new System.Drawing.Size(443, 150);
            this.DgCustomer.TabIndex = 8;
            this.DgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCustomer_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(26, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(107, 239);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(188, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(269, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Items.AddRange(new object[] {
            "Dine-In",
            "Walking Customer",
            "Home Delivery"});
            this.cmbCategories.Location = new System.Drawing.Point(100, 130);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(121, 21);
            this.cmbCategories.TabIndex = 3;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 418);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DgCustomer);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblName);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView DgCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbCategories;
    }
}