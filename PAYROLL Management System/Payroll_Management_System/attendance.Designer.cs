namespace Payroll_Management_System
{
    partial class attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbox_emplyee = new System.Windows.Forms.GroupBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lblemname = new System.Windows.Forms.Label();
            this.txt_empid = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_emp_bpay = new System.Windows.Forms.Label();
            this.lbl_empid = new System.Windows.Forms.Label();
            this.lbl_emp_name = new System.Windows.Forms.Label();
            this.gbox_attend = new System.Windows.Forms.GroupBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.com_mont = new System.Windows.Forms.ComboBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.lbl_dabsent = new System.Windows.Forms.Label();
            this.txtDL = new System.Windows.Forms.TextBox();
            this.lbl_dlate = new System.Windows.Forms.Label();
            this.lbl_salarymon = new System.Windows.Forms.Label();
            this.txtDOT = new System.Windows.Forms.TextBox();
            this.lbl_dot = new System.Windows.Forms.Label();
            this.lbl_salaryear = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRetrieve2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.btn_btm = new System.Windows.Forms.Button();
            this.gbox_emplyee.SuspendLayout();
            this.gbox_attend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_emplyee
            // 
            this.gbox_emplyee.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gbox_emplyee.Controls.Add(this.lblsalary);
            this.gbox_emplyee.Controls.Add(this.lblemname);
            this.gbox_emplyee.Controls.Add(this.txt_empid);
            this.gbox_emplyee.Controls.Add(this.btn_search);
            this.gbox_emplyee.Controls.Add(this.lbl_emp_bpay);
            this.gbox_emplyee.Controls.Add(this.lbl_empid);
            this.gbox_emplyee.Controls.Add(this.lbl_emp_name);
            this.gbox_emplyee.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.gbox_emplyee.ForeColor = System.Drawing.Color.White;
            this.gbox_emplyee.Location = new System.Drawing.Point(6, 114);
            this.gbox_emplyee.Name = "gbox_emplyee";
            this.gbox_emplyee.Size = new System.Drawing.Size(376, 231);
            this.gbox_emplyee.TabIndex = 37;
            this.gbox_emplyee.TabStop = false;
            this.gbox_emplyee.Text = "EMPLOYEE INFO";
            this.gbox_emplyee.Enter += new System.EventHandler(this.gbox_emplyee_Enter);
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalary.Location = new System.Drawing.Point(209, 136);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(0, 25);
            this.lblsalary.TabIndex = 52;
            // 
            // lblemname
            // 
            this.lblemname.AutoSize = true;
            this.lblemname.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemname.Location = new System.Drawing.Point(209, 87);
            this.lblemname.Name = "lblemname";
            this.lblemname.Size = new System.Drawing.Size(0, 25);
            this.lblemname.TabIndex = 51;
            // 
            // txt_empid
            // 
            this.txt_empid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_empid.FormattingEnabled = true;
            this.txt_empid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_empid.Location = new System.Drawing.Point(206, 42);
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(144, 30);
            this.txt_empid.TabIndex = 50;
            this.txt_empid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_empid_KeyPress);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(249, 178);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 34);
            this.btn_search.TabIndex = 49;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_emp_bpay
            // 
            this.lbl_emp_bpay.AutoSize = true;
            this.lbl_emp_bpay.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_bpay.ForeColor = System.Drawing.Color.White;
            this.lbl_emp_bpay.Location = new System.Drawing.Point(22, 145);
            this.lbl_emp_bpay.Name = "lbl_emp_bpay";
            this.lbl_emp_bpay.Size = new System.Drawing.Size(163, 18);
            this.lbl_emp_bpay.TabIndex = 30;
            this.lbl_emp_bpay.Text = "Employee BasicPay";
            // 
            // lbl_empid
            // 
            this.lbl_empid.AutoSize = true;
            this.lbl_empid.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empid.ForeColor = System.Drawing.Color.White;
            this.lbl_empid.Location = new System.Drawing.Point(22, 51);
            this.lbl_empid.Name = "lbl_empid";
            this.lbl_empid.Size = new System.Drawing.Size(111, 18);
            this.lbl_empid.TabIndex = 16;
            this.lbl_empid.Text = "Employee ID";
            // 
            // lbl_emp_name
            // 
            this.lbl_emp_name.AutoSize = true;
            this.lbl_emp_name.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_name.ForeColor = System.Drawing.Color.White;
            this.lbl_emp_name.Location = new System.Drawing.Point(22, 96);
            this.lbl_emp_name.Name = "lbl_emp_name";
            this.lbl_emp_name.Size = new System.Drawing.Size(136, 18);
            this.lbl_emp_name.TabIndex = 1;
            this.lbl_emp_name.Text = "Employee Name";
            // 
            // gbox_attend
            // 
            this.gbox_attend.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gbox_attend.Controls.Add(this.txt_salary);
            this.gbox_attend.Controls.Add(this.com_mont);
            this.gbox_attend.Controls.Add(this.txtDA);
            this.gbox_attend.Controls.Add(this.lbl_dabsent);
            this.gbox_attend.Controls.Add(this.txtDL);
            this.gbox_attend.Controls.Add(this.lbl_dlate);
            this.gbox_attend.Controls.Add(this.lbl_salarymon);
            this.gbox_attend.Controls.Add(this.txtDOT);
            this.gbox_attend.Controls.Add(this.lbl_dot);
            this.gbox_attend.Controls.Add(this.lbl_salaryear);
            this.gbox_attend.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_attend.ForeColor = System.Drawing.Color.White;
            this.gbox_attend.Location = new System.Drawing.Point(388, 114);
            this.gbox_attend.Name = "gbox_attend";
            this.gbox_attend.Size = new System.Drawing.Size(354, 231);
            this.gbox_attend.TabIndex = 38;
            this.gbox_attend.TabStop = false;
            this.gbox_attend.Text = "ATTENDENCE";
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Location = new System.Drawing.Point(186, 74);
            this.txt_salary.MaxLength = 4;
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(137, 26);
            this.txt_salary.TabIndex = 107;
            this.txt_salary.Text = "2019";
            this.txt_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // com_mont
            // 
            this.com_mont.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.com_mont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_mont.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_mont.FormattingEnabled = true;
            this.com_mont.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.com_mont.Location = new System.Drawing.Point(185, 36);
            this.com_mont.Name = "com_mont";
            this.com_mont.Size = new System.Drawing.Size(138, 24);
            this.com_mont.TabIndex = 95;
            // 
            // txtDA
            // 
            this.txtDA.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDA.Location = new System.Drawing.Point(186, 191);
            this.txtDA.MaxLength = 2;
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(137, 26);
            this.txtDA.TabIndex = 45;
            this.txtDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDA_KeyPress);
            // 
            // lbl_dabsent
            // 
            this.lbl_dabsent.AutoSize = true;
            this.lbl_dabsent.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_dabsent.ForeColor = System.Drawing.Color.White;
            this.lbl_dabsent.Location = new System.Drawing.Point(22, 192);
            this.lbl_dabsent.Name = "lbl_dabsent";
            this.lbl_dabsent.Size = new System.Drawing.Size(107, 18);
            this.lbl_dabsent.TabIndex = 44;
            this.lbl_dabsent.Text = "Days Absent";
            // 
            // txtDL
            // 
            this.txtDL.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDL.Location = new System.Drawing.Point(186, 151);
            this.txtDL.MaxLength = 2;
            this.txtDL.Name = "txtDL";
            this.txtDL.Size = new System.Drawing.Size(137, 26);
            this.txtDL.TabIndex = 43;
            this.txtDL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDL_KeyPress);
            // 
            // lbl_dlate
            // 
            this.lbl_dlate.AutoSize = true;
            this.lbl_dlate.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_dlate.ForeColor = System.Drawing.Color.White;
            this.lbl_dlate.Location = new System.Drawing.Point(22, 151);
            this.lbl_dlate.Name = "lbl_dlate";
            this.lbl_dlate.Size = new System.Drawing.Size(88, 18);
            this.lbl_dlate.TabIndex = 42;
            this.lbl_dlate.Text = "Days Late";
            // 
            // lbl_salarymon
            // 
            this.lbl_salarymon.AutoSize = true;
            this.lbl_salarymon.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_salarymon.ForeColor = System.Drawing.Color.White;
            this.lbl_salarymon.Location = new System.Drawing.Point(22, 42);
            this.lbl_salarymon.Name = "lbl_salarymon";
            this.lbl_salarymon.Size = new System.Drawing.Size(115, 18);
            this.lbl_salarymon.TabIndex = 41;
            this.lbl_salarymon.Text = "Salary Month";
            // 
            // txtDOT
            // 
            this.txtDOT.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOT.Location = new System.Drawing.Point(185, 113);
            this.txtDOT.MaxLength = 2;
            this.txtDOT.Name = "txtDOT";
            this.txtDOT.Size = new System.Drawing.Size(137, 26);
            this.txtDOT.TabIndex = 40;
            this.txtDOT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDOT_KeyPress);
            // 
            // lbl_dot
            // 
            this.lbl_dot.AutoSize = true;
            this.lbl_dot.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_dot.ForeColor = System.Drawing.Color.White;
            this.lbl_dot.Location = new System.Drawing.Point(20, 115);
            this.lbl_dot.Name = "lbl_dot";
            this.lbl_dot.Size = new System.Drawing.Size(120, 18);
            this.lbl_dot.TabIndex = 39;
            this.lbl_dot.Text = "Days On Time";
            // 
            // lbl_salaryear
            // 
            this.lbl_salaryear.AutoSize = true;
            this.lbl_salaryear.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_salaryear.ForeColor = System.Drawing.Color.White;
            this.lbl_salaryear.Location = new System.Drawing.Point(21, 79);
            this.lbl_salaryear.Name = "lbl_salaryear";
            this.lbl_salaryear.Size = new System.Drawing.Size(102, 18);
            this.lbl_salaryear.TabIndex = 38;
            this.lbl_salaryear.Text = "Salary Year";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lavender;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(748, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 42);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRetrieve2
            // 
            this.btnRetrieve2.BackColor = System.Drawing.Color.Lavender;
            this.btnRetrieve2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve2.Location = new System.Drawing.Point(860, 181);
            this.btnRetrieve2.Name = "btnRetrieve2";
            this.btnRetrieve2.Size = new System.Drawing.Size(106, 42);
            this.btnRetrieve2.TabIndex = 46;
            this.btnRetrieve2.Text = "RETRIEVE";
            this.btnRetrieve2.UseVisualStyleBackColor = false;
            this.btnRetrieve2.Click += new System.EventHandler(this.btnRetrieve2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(748, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 40);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(748, 181);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 40);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lavender;
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(860, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 42);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendance.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAttendance.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAttendance.Location = new System.Drawing.Point(6, 363);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(958, 188);
            this.dgvAttendance.TabIndex = 48;
            this.dgvAttendance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvAttendance_KeyPress);
            // 
            // btn_btm
            // 
            this.btn_btm.BackColor = System.Drawing.Color.Lavender;
            this.btn_btm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_btm.Location = new System.Drawing.Point(858, 294);
            this.btn_btm.Name = "btn_btm";
            this.btn_btm.Size = new System.Drawing.Size(106, 42);
            this.btn_btm.TabIndex = 106;
            this.btn_btm.Text = "BACK";
            this.btn_btm.UseVisualStyleBackColor = false;
            this.btn_btm.Click += new System.EventHandler(this.btn_btm_Click);
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Payroll_Management_System.Properties.Resources.attendance_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 558);
            this.Controls.Add(this.btn_btm);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRetrieve2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbox_attend);
            this.Controls.Add(this.gbox_emplyee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "attendance";
            this.Load += new System.EventHandler(this.attenddance_Load);
            this.gbox_emplyee.ResumeLayout(false);
            this.gbox_emplyee.PerformLayout();
            this.gbox_attend.ResumeLayout(false);
            this.gbox_attend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_emplyee;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lblemname;
        private System.Windows.Forms.ComboBox txt_empid;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_emp_bpay;
        private System.Windows.Forms.Label lbl_empid;
        private System.Windows.Forms.Label lbl_emp_name;
        private System.Windows.Forms.GroupBox gbox_attend;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.Label lbl_dabsent;
        private System.Windows.Forms.TextBox txtDL;
        private System.Windows.Forms.Label lbl_dlate;
        private System.Windows.Forms.Label lbl_salarymon;
        private System.Windows.Forms.TextBox txtDOT;
        private System.Windows.Forms.Label lbl_dot;
        private System.Windows.Forms.Label lbl_salaryear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRetrieve2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.ComboBox com_mont;
        private System.Windows.Forms.Button btn_btm;
        private System.Windows.Forms.TextBox txt_salary;
    }
}