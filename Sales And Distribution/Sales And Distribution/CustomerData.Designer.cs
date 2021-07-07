namespace Sales_And_Distribution
{
    partial class lbltotalammount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbltotalammount));
            this.lblCusID = new System.Windows.Forms.Label();
            this.lblcustomername = new System.Windows.Forms.Label();
            this.lblcustomeraddress = new System.Windows.Forms.Label();
            this.lblcustomerphno = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbcash = new System.Windows.Forms.RadioButton();
            this.rbcard = new System.Windows.Forms.RadioButton();
            this.GridMaterial = new System.Windows.Forms.DataGridView();
            this.C_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PayTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.blheadingcmd = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridMaterial)).BeginInit();
            this.blheadingcmd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.BackColor = System.Drawing.Color.Transparent;
            this.lblCusID.Location = new System.Drawing.Point(2, 7);
            this.lblCusID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(13, 13);
            this.lblCusID.TabIndex = 0;
            this.lblCusID.Text = "0";
            this.lblCusID.Visible = false;
            // 
            // lblcustomername
            // 
            this.lblcustomername.AutoSize = true;
            this.lblcustomername.BackColor = System.Drawing.Color.Transparent;
            this.lblcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcustomername.Location = new System.Drawing.Point(72, 80);
            this.lblcustomername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcustomername.Name = "lblcustomername";
            this.lblcustomername.Size = new System.Drawing.Size(95, 13);
            this.lblcustomername.TabIndex = 0;
            this.lblcustomername.Text = "Customer Name";
            // 
            // lblcustomeraddress
            // 
            this.lblcustomeraddress.AutoSize = true;
            this.lblcustomeraddress.BackColor = System.Drawing.Color.Transparent;
            this.lblcustomeraddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomeraddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcustomeraddress.Location = new System.Drawing.Point(72, 144);
            this.lblcustomeraddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcustomeraddress.Name = "lblcustomeraddress";
            this.lblcustomeraddress.Size = new System.Drawing.Size(108, 13);
            this.lblcustomeraddress.TabIndex = 0;
            this.lblcustomeraddress.Text = "Customer Address";
            // 
            // lblcustomerphno
            // 
            this.lblcustomerphno.AutoSize = true;
            this.lblcustomerphno.BackColor = System.Drawing.Color.Transparent;
            this.lblcustomerphno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerphno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcustomerphno.Location = new System.Drawing.Point(72, 111);
            this.lblcustomerphno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcustomerphno.Name = "lblcustomerphno";
            this.lblcustomerphno.Size = new System.Drawing.Size(119, 13);
            this.lblcustomerphno.TabIndex = 0;
            this.lblcustomerphno.Text = "Customer Phone No";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(250, 109);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusPhone.MaxLength = 11;
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.ShortcutsEnabled = false;
            this.txtCusPhone.Size = new System.Drawing.Size(266, 20);
            this.txtCusPhone.TabIndex = 1;
            this.txtCusPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusPhone_KeyPress);
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(250, 140);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusAddress.MaxLength = 50;
            this.txtCusAddress.Multiline = true;
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.ShortcutsEnabled = false;
            this.txtCusAddress.Size = new System.Drawing.Size(266, 93);
            this.txtCusAddress.TabIndex = 2;
            this.txtCusAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusAddress_KeyPress);
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(250, 76);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusName.MaxLength = 20;
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.ShortcutsEnabled = false;
            this.txtCusName.Size = new System.Drawing.Size(266, 20);
            this.txtCusName.TabIndex = 0;
            this.txtCusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusName_KeyPress);
            // 
            // lblate
            // 
            this.lblate.AutoSize = true;
            this.lblate.BackColor = System.Drawing.Color.Transparent;
            this.lblate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblate.Location = new System.Drawing.Point(72, 258);
            this.lblate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblate.Name = "lblate";
            this.lblate.Size = new System.Drawing.Size(149, 13);
            this.lblate.TabIndex = 0;
            this.lblate.Text = "Customer Payment Terms";
            this.lblate.Click += new System.EventHandler(this.lblate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1064, 579);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Master Data";
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.BackColor = System.Drawing.Color.Transparent;
            this.rbcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbcash.Location = new System.Drawing.Point(294, 254);
            this.rbcash.Margin = new System.Windows.Forms.Padding(2);
            this.rbcash.Name = "rbcash";
            this.rbcash.Size = new System.Drawing.Size(53, 17);
            this.rbcash.TabIndex = 3;
            this.rbcash.TabStop = true;
            this.rbcash.Text = "Cash";
            this.rbcash.UseVisualStyleBackColor = false;
            // 
            // rbcard
            // 
            this.rbcard.AutoSize = true;
            this.rbcard.BackColor = System.Drawing.Color.Transparent;
            this.rbcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbcard.Location = new System.Drawing.Point(370, 254);
            this.rbcard.Margin = new System.Windows.Forms.Padding(2);
            this.rbcard.Name = "rbcard";
            this.rbcard.Size = new System.Drawing.Size(85, 17);
            this.rbcard.TabIndex = 4;
            this.rbcard.TabStop = true;
            this.rbcard.Text = "Debit Card";
            this.rbcard.UseVisualStyleBackColor = false;
            // 
            // GridMaterial
            // 
            this.GridMaterial.AllowUserToAddRows = false;
            this.GridMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Id,
            this.C_Name,
            this.C_Address,
            this.C_phone,
            this.C_PayTerms,
            this.Edit,
            this.Delete});
            this.GridMaterial.Location = new System.Drawing.Point(-94, 287);
            this.GridMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.GridMaterial.Name = "GridMaterial";
            this.GridMaterial.ReadOnly = true;
            this.GridMaterial.RowHeadersWidth = 51;
            this.GridMaterial.RowTemplate.Height = 24;
            this.GridMaterial.Size = new System.Drawing.Size(804, 157);
            this.GridMaterial.TabIndex = 7;
            this.GridMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMaterial_CellContentClick);
            // 
            // C_Id
            // 
            this.C_Id.DataPropertyName = "C_Id";
            this.C_Id.HeaderText = "C_Id";
            this.C_Id.MinimumWidth = 6;
            this.C_Id.Name = "C_Id";
            this.C_Id.ReadOnly = true;
            this.C_Id.ToolTipText = "Delete";
            this.C_Id.Visible = false;
            this.C_Id.Width = 125;
            // 
            // C_Name
            // 
            this.C_Name.DataPropertyName = "C_Name";
            this.C_Name.HeaderText = "C_Name";
            this.C_Name.MinimumWidth = 6;
            this.C_Name.Name = "C_Name";
            this.C_Name.ReadOnly = true;
            this.C_Name.Width = 125;
            // 
            // C_Address
            // 
            this.C_Address.DataPropertyName = "C_Address";
            this.C_Address.HeaderText = "C_Address";
            this.C_Address.MinimumWidth = 6;
            this.C_Address.Name = "C_Address";
            this.C_Address.ReadOnly = true;
            this.C_Address.Width = 125;
            // 
            // C_phone
            // 
            this.C_phone.DataPropertyName = "C_phone";
            this.C_phone.HeaderText = "C_phone";
            this.C_phone.MinimumWidth = 6;
            this.C_phone.Name = "C_phone";
            this.C_phone.ReadOnly = true;
            this.C_phone.Width = 125;
            // 
            // C_PayTerms
            // 
            this.C_PayTerms.DataPropertyName = "C_PayTerms";
            this.C_PayTerms.HeaderText = "C_PayTerms";
            this.C_PayTerms.MinimumWidth = 6;
            this.C_PayTerms.Name = "C_PayTerms";
            this.C_PayTerms.ReadOnly = true;
            this.C_PayTerms.Width = 125;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "C_Id";
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "C_Id";
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(548, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(548, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // blheadingcmd
            // 
            this.blheadingcmd.BackColor = System.Drawing.Color.Black;
            this.blheadingcmd.Controls.Add(this.label4);
            this.blheadingcmd.Controls.Add(this.label3);
            this.blheadingcmd.Controls.Add(this.lblID);
            this.blheadingcmd.Controls.Add(this.label2);
            this.blheadingcmd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blheadingcmd.Location = new System.Drawing.Point(4, 5);
            this.blheadingcmd.Margin = new System.Windows.Forms.Padding(2);
            this.blheadingcmd.Name = "blheadingcmd";
            this.blheadingcmd.Size = new System.Drawing.Size(717, 67);
            this.blheadingcmd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(692, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "_";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 39);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(234, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Master Data";
            // 
            // lbltotalammount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 455);
            this.Controls.Add(this.blheadingcmd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GridMaterial);
            this.Controls.Add(this.rbcard);
            this.Controls.Add(this.rbcash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCusAddress);
            this.Controls.Add(this.txtCusPhone);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.lblcustomerphno);
            this.Controls.Add(this.lblate);
            this.Controls.Add(this.lblcustomeraddress);
            this.Controls.Add(this.lblcustomername);
            this.Controls.Add(this.lblCusID);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "lbltotalammount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.lbltotalammount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMaterial)).EndInit();
            this.blheadingcmd.ResumeLayout(false);
            this.blheadingcmd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.Label lblcustomername;
        private System.Windows.Forms.Label lblcustomeraddress;
        private System.Windows.Forms.Label lblcustomerphno;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label lblate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbcash;
        private System.Windows.Forms.RadioButton rbcard;
        private System.Windows.Forms.DataGridView GridMaterial;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PayTerms;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel blheadingcmd;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}