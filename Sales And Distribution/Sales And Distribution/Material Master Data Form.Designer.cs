namespace Sales_And_Distribution
{
    partial class Material_Master_Data_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblmaterialname = new System.Windows.Forms.Label();
            this.lblmaterialquantity = new System.Windows.Forms.Label();
            this.lblstoragelock = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtStorageLoc = new System.Windows.Forms.TextBox();
            this.GridMaterial = new System.Windows.Forms.DataGridView();
            this.materialid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materialquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Storageloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.blheadingmmd = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridMaterial)).BeginInit();
            this.blheadingmmd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(153, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Material Master Data";
            // 
            // lblmaterialname
            // 
            this.lblmaterialname.AutoSize = true;
            this.lblmaterialname.BackColor = System.Drawing.Color.Transparent;
            this.lblmaterialname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaterialname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblmaterialname.Location = new System.Drawing.Point(100, 99);
            this.lblmaterialname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmaterialname.Name = "lblmaterialname";
            this.lblmaterialname.Size = new System.Drawing.Size(88, 13);
            this.lblmaterialname.TabIndex = 0;
            this.lblmaterialname.Text = "Material Name";
            // 
            // lblmaterialquantity
            // 
            this.lblmaterialquantity.AutoSize = true;
            this.lblmaterialquantity.BackColor = System.Drawing.Color.Transparent;
            this.lblmaterialquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaterialquantity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblmaterialquantity.Location = new System.Drawing.Point(100, 151);
            this.lblmaterialquantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmaterialquantity.Name = "lblmaterialquantity";
            this.lblmaterialquantity.Size = new System.Drawing.Size(103, 13);
            this.lblmaterialquantity.TabIndex = 0;
            this.lblmaterialquantity.Text = "Material Quantity";
            // 
            // lblstoragelock
            // 
            this.lblstoragelock.AutoSize = true;
            this.lblstoragelock.BackColor = System.Drawing.Color.Transparent;
            this.lblstoragelock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstoragelock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblstoragelock.Location = new System.Drawing.Point(100, 201);
            this.lblstoragelock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstoragelock.Name = "lblstoragelock";
            this.lblstoragelock.Size = new System.Drawing.Size(104, 13);
            this.lblstoragelock.TabIndex = 0;
            this.lblstoragelock.Text = "Storage Location";
            this.lblstoragelock.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 95);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 15;
            this.txtName.Name = "txtName";
            this.txtName.ShortcutsEnabled = false;
            this.txtName.Size = new System.Drawing.Size(223, 20);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(218, 147);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.MaxLength = 3;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ShortcutsEnabled = false;
            this.txtQuantity.Size = new System.Drawing.Size(223, 20);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtStorageLoc
            // 
            this.txtStorageLoc.Location = new System.Drawing.Point(218, 197);
            this.txtStorageLoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtStorageLoc.MaxLength = 15;
            this.txtStorageLoc.Name = "txtStorageLoc";
            this.txtStorageLoc.ShortcutsEnabled = false;
            this.txtStorageLoc.Size = new System.Drawing.Size(223, 20);
            this.txtStorageLoc.TabIndex = 2;
            this.txtStorageLoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStorageLock_KeyPress);
            // 
            // GridMaterial
            // 
            this.GridMaterial.AllowUserToAddRows = false;
            this.GridMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialid,
            this.materialname,
            this.Materialquantity,
            this.Storageloc,
            this.Edit,
            this.Delete});
            this.GridMaterial.Location = new System.Drawing.Point(30, 284);
            this.GridMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.GridMaterial.Name = "GridMaterial";
            this.GridMaterial.ReadOnly = true;
            this.GridMaterial.RowHeadersWidth = 51;
            this.GridMaterial.RowTemplate.Height = 24;
            this.GridMaterial.Size = new System.Drawing.Size(500, 194);
            this.GridMaterial.TabIndex = 2;
            this.GridMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialid
            // 
            this.materialid.DataPropertyName = "M_Id";
            this.materialid.HeaderText = "Material ID";
            this.materialid.MinimumWidth = 6;
            this.materialid.Name = "materialid";
            this.materialid.ReadOnly = true;
            this.materialid.Visible = false;
            this.materialid.Width = 125;
            // 
            // materialname
            // 
            this.materialname.DataPropertyName = "M_Name";
            this.materialname.HeaderText = "Material Name";
            this.materialname.MinimumWidth = 6;
            this.materialname.Name = "materialname";
            this.materialname.ReadOnly = true;
            this.materialname.Width = 125;
            // 
            // Materialquantity
            // 
            this.Materialquantity.DataPropertyName = "M_Quantity";
            this.Materialquantity.HeaderText = "Material Quantity";
            this.Materialquantity.MinimumWidth = 6;
            this.Materialquantity.Name = "Materialquantity";
            this.Materialquantity.ReadOnly = true;
            this.Materialquantity.Width = 125;
            // 
            // Storageloc
            // 
            this.Storageloc.DataPropertyName = "StorageLoc";
            this.Storageloc.HeaderText = "Storage Loc";
            this.Storageloc.MinimumWidth = 6;
            this.Storageloc.Name = "Storageloc";
            this.Storageloc.ReadOnly = true;
            this.Storageloc.Width = 125;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "M_Id";
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "M_Id";
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(236, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(356, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Reset";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // blheadingmmd
            // 
            this.blheadingmmd.BackColor = System.Drawing.Color.Black;
            this.blheadingmmd.Controls.Add(this.label4);
            this.blheadingmmd.Controls.Add(this.label3);
            this.blheadingmmd.Controls.Add(this.lblID);
            this.blheadingmmd.Controls.Add(this.label2);
            this.blheadingmmd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blheadingmmd.Location = new System.Drawing.Point(2, 1);
            this.blheadingmmd.Margin = new System.Windows.Forms.Padding(2);
            this.blheadingmmd.Name = "blheadingmmd";
            this.blheadingmmd.Size = new System.Drawing.Size(558, 72);
            this.blheadingmmd.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "_";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Material_Master_Data_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 498);
            this.Controls.Add(this.blheadingmmd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GridMaterial);
            this.Controls.Add(this.txtStorageLoc);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblstoragelock);
            this.Controls.Add(this.lblmaterialquantity);
            this.Controls.Add(this.lblmaterialname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Material_Master_Data_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material_Master_Data_Form";
            this.Load += new System.EventHandler(this.Material_Master_Data_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMaterial)).EndInit();
            this.blheadingmmd.ResumeLayout(false);
            this.blheadingmmd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmaterialname;
        private System.Windows.Forms.Label lblmaterialquantity;
        private System.Windows.Forms.Label lblstoragelock;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtStorageLoc;
        private System.Windows.Forms.DataGridView GridMaterial;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialid;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materialquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Storageloc;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel blheadingmmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}