namespace Payroll_Management_System
{
    partial class selection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblcan_id = new System.Windows.Forms.Label();
            this.lbl_emploid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtemp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comb_cand_Id = new System.Windows.Forms.ComboBox();
            this.dvgSelection = new System.Windows.Forms.DataGridView();
            this.btn_selsave = new System.Windows.Forms.Button();
            this.btn_seldel = new System.Windows.Forms.Button();
            this.btn_selback = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnhire = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcan_id
            // 
            this.lblcan_id.AutoSize = true;
            this.lblcan_id.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcan_id.ForeColor = System.Drawing.Color.White;
            this.lblcan_id.Location = new System.Drawing.Point(29, 51);
            this.lblcan_id.Name = "lblcan_id";
            this.lblcan_id.Size = new System.Drawing.Size(110, 19);
            this.lblcan_id.TabIndex = 76;
            this.lblcan_id.Text = "Candidate Id";
            // 
            // lbl_emploid
            // 
            this.lbl_emploid.AutoSize = true;
            this.lbl_emploid.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emploid.Location = new System.Drawing.Point(21, 51);
            this.lbl_emploid.Name = "lbl_emploid";
            this.lbl_emploid.Size = new System.Drawing.Size(107, 19);
            this.lbl_emploid.TabIndex = 97;
            this.lbl_emploid.Text = "Employee Id";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.txtemp);
            this.groupBox1.Controls.Add(this.lbl_emploid);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(410, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 115);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Selection";
            // 
            // txtemp
            // 
            this.txtemp.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemp.Location = new System.Drawing.Point(143, 51);
            this.txtemp.Name = "txtemp";
            this.txtemp.Size = new System.Drawing.Size(175, 27);
            this.txtemp.TabIndex = 98;
            this.txtemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemp_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox2.Controls.Add(this.comb_cand_Id);
            this.groupBox2.Controls.Add(this.lblcan_id);
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(30, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 115);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Candidate Info";
            // 
            // comb_cand_Id
            // 
            this.comb_cand_Id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_cand_Id.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_cand_Id.FormattingEnabled = true;
            this.comb_cand_Id.Location = new System.Drawing.Point(171, 47);
            this.comb_cand_Id.Name = "comb_cand_Id";
            this.comb_cand_Id.Size = new System.Drawing.Size(152, 27);
            this.comb_cand_Id.TabIndex = 111;
            // 
            // dvgSelection
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSelection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgSelection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dvgSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgSelection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSelection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgSelection.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgSelection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgSelection.Location = new System.Drawing.Point(5, 345);
            this.dvgSelection.Name = "dvgSelection";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSelection.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgSelection.Size = new System.Drawing.Size(779, 153);
            this.dvgSelection.TabIndex = 106;
            this.dvgSelection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dvgSelection_KeyPress);
            // 
            // btn_selsave
            // 
            this.btn_selsave.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_selsave.Location = new System.Drawing.Point(201, 266);
            this.btn_selsave.Name = "btn_selsave";
            this.btn_selsave.Size = new System.Drawing.Size(94, 59);
            this.btn_selsave.TabIndex = 107;
            this.btn_selsave.Text = "SAVE";
            this.btn_selsave.UseVisualStyleBackColor = true;
            this.btn_selsave.Click += new System.EventHandler(this.btn_selsave_Click);
            // 
            // btn_seldel
            // 
            this.btn_seldel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_seldel.Location = new System.Drawing.Point(320, 266);
            this.btn_seldel.Name = "btn_seldel";
            this.btn_seldel.Size = new System.Drawing.Size(91, 59);
            this.btn_seldel.TabIndex = 108;
            this.btn_seldel.Text = "DELETE";
            this.btn_seldel.UseVisualStyleBackColor = true;
            this.btn_seldel.Click += new System.EventHandler(this.btn_seldel_Click);
            // 
            // btn_selback
            // 
            this.btn_selback.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_selback.Location = new System.Drawing.Point(440, 266);
            this.btn_selback.Name = "btn_selback";
            this.btn_selback.Size = new System.Drawing.Size(91, 59);
            this.btn_selback.TabIndex = 110;
            this.btn_selback.Text = "BACK";
            this.btn_selback.UseVisualStyleBackColor = true;
            this.btn_selback.Click += new System.EventHandler(this.btn_selback_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnadd.Location = new System.Drawing.Point(84, 266);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(91, 59);
            this.btnadd.TabIndex = 111;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnhire
            // 
            this.btnhire.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnhire.Location = new System.Drawing.Point(559, 266);
            this.btnhire.Name = "btnhire";
            this.btnhire.Size = new System.Drawing.Size(91, 59);
            this.btnhire.TabIndex = 113;
            this.btnhire.Text = "HIRING";
            this.btnhire.UseVisualStyleBackColor = true;
            this.btnhire.Click += new System.EventHandler(this.btnhire_Click_1);
            // 
            // selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::Payroll_Management_System.Properties.Resources.selection;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 510);
            this.Controls.Add(this.btnhire);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btn_selback);
            this.Controls.Add(this.btn_seldel);
            this.Controls.Add(this.btn_selsave);
            this.Controls.Add(this.dvgSelection);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "selection";
            this.Load += new System.EventHandler(this.selection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblcan_id;
        private System.Windows.Forms.Label lbl_emploid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comb_cand_Id;
        private System.Windows.Forms.DataGridView dvgSelection;
        private System.Windows.Forms.Button btn_selsave;
        private System.Windows.Forms.Button btn_seldel;
        private System.Windows.Forms.Button btn_selback;
        private System.Windows.Forms.TextBox txtemp;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnhire;
    }
}