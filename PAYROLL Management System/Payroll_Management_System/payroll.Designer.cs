namespace Payroll_Management_System
{
    partial class payroll
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
            this.btn_cal = new System.Windows.Forms.Button();
            this.lblcn = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblgander = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.lbl_dabsent = new System.Windows.Forms.Label();
            this.lbl_dlate = new System.Windows.Forms.Label();
            this.lbl_dot = new System.Windows.Forms.Label();
            this.lbl_salmont = new System.Windows.Forms.Label();
            this.lbl_bpay = new System.Windows.Forms.Label();
            this.lbl_contnum = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_empid = new System.Windows.Forms.Label();
            this.gbox_empay = new System.Windows.Forms.GroupBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lblabsent = new System.Windows.Forms.Label();
            this.lbldl = new System.Windows.Forms.Label();
            this.lbldot = new System.Windows.Forms.Label();
            this.lblsm = new System.Windows.Forms.Label();
            this.lblbasicpay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_btm = new System.Windows.Forms.Button();
            this.gbox_empay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cal
            // 
            this.btn_cal.BackColor = System.Drawing.Color.Transparent;
            this.btn_cal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cal.Location = new System.Drawing.Point(592, 326);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(126, 32);
            this.btn_cal.TabIndex = 77;
            this.btn_cal.Text = "CALCULATE SALARY";
            this.btn_cal.UseVisualStyleBackColor = false;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // lblcn
            // 
            this.lblcn.AutoSize = true;
            this.lblcn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblcn.Location = new System.Drawing.Point(209, 203);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(0, 18);
            this.lblcn.TabIndex = 75;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblEmail.Location = new System.Drawing.Point(209, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 18);
            this.lblEmail.TabIndex = 74;
            // 
            // lblgander
            // 
            this.lblgander.AutoSize = true;
            this.lblgander.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblgander.Location = new System.Drawing.Point(209, 108);
            this.lblgander.Name = "lblgander";
            this.lblgander.Size = new System.Drawing.Size(0, 18);
            this.lblgander.TabIndex = 72;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblname.Location = new System.Drawing.Point(209, 60);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 18);
            this.lblname.TabIndex = 71;
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salary.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salary.Location = new System.Drawing.Point(407, 268);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(78, 18);
            this.lbl_salary.TabIndex = 70;
            this.lbl_salary.Text = "SALARY";
            // 
            // lbl_dabsent
            // 
            this.lbl_dabsent.AutoSize = true;
            this.lbl_dabsent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dabsent.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dabsent.Location = new System.Drawing.Point(407, 226);
            this.lbl_dabsent.Name = "lbl_dabsent";
            this.lbl_dabsent.Size = new System.Drawing.Size(129, 18);
            this.lbl_dabsent.TabIndex = 69;
            this.lbl_dabsent.Text = "DAYS ABSENT";
            // 
            // lbl_dlate
            // 
            this.lbl_dlate.AutoSize = true;
            this.lbl_dlate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dlate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dlate.Location = new System.Drawing.Point(407, 186);
            this.lbl_dlate.Name = "lbl_dlate";
            this.lbl_dlate.Size = new System.Drawing.Size(108, 18);
            this.lbl_dlate.TabIndex = 68;
            this.lbl_dlate.Text = "DAYS LATE";
            // 
            // lbl_dot
            // 
            this.lbl_dot.AutoSize = true;
            this.lbl_dot.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dot.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dot.Location = new System.Drawing.Point(407, 144);
            this.lbl_dot.Name = "lbl_dot";
            this.lbl_dot.Size = new System.Drawing.Size(136, 18);
            this.lbl_dot.TabIndex = 67;
            this.lbl_dot.Text = "DAYS ON TIME";
            // 
            // lbl_salmont
            // 
            this.lbl_salmont.AutoSize = true;
            this.lbl_salmont.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salmont.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salmont.Location = new System.Drawing.Point(407, 101);
            this.lbl_salmont.Name = "lbl_salmont";
            this.lbl_salmont.Size = new System.Drawing.Size(147, 18);
            this.lbl_salmont.TabIndex = 66;
            this.lbl_salmont.Text = "SALARY MONTH";
            // 
            // lbl_bpay
            // 
            this.lbl_bpay.AutoSize = true;
            this.lbl_bpay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bpay.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bpay.Location = new System.Drawing.Point(407, 60);
            this.lbl_bpay.Name = "lbl_bpay";
            this.lbl_bpay.Size = new System.Drawing.Size(101, 18);
            this.lbl_bpay.TabIndex = 65;
            this.lbl_bpay.Text = "BASIC PAY";
            // 
            // lbl_contnum
            // 
            this.lbl_contnum.AutoSize = true;
            this.lbl_contnum.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contnum.Location = new System.Drawing.Point(14, 203);
            this.lbl_contnum.Name = "lbl_contnum";
            this.lbl_contnum.Size = new System.Drawing.Size(166, 18);
            this.lbl_contnum.TabIndex = 64;
            this.lbl_contnum.Text = "CONTACT NUMBER";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(14, 154);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(73, 18);
            this.lbl_email.TabIndex = 61;
            this.lbl_email.Text = "E-MAIL";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(14, 108);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(81, 18);
            this.lbl_gender.TabIndex = 60;
            this.lbl_gender.Text = "GENDER";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(14, 60);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 18);
            this.lbl_name.TabIndex = 59;
            this.lbl_name.Text = "NAME";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(263, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 26);
            this.comboBox1.TabIndex = 80;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_load.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(443, 31);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(91, 33);
            this.btn_load.TabIndex = 79;
            this.btn_load.Text = "LOAD";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lbl_empid
            // 
            this.lbl_empid.AutoSize = true;
            this.lbl_empid.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empid.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_empid.Location = new System.Drawing.Point(86, 36);
            this.lbl_empid.Name = "lbl_empid";
            this.lbl_empid.Size = new System.Drawing.Size(108, 18);
            this.lbl_empid.TabIndex = 78;
            this.lbl_empid.Text = "EMPLOYEE ID";
            // 
            // gbox_empay
            // 
            this.gbox_empay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbox_empay.Controls.Add(this.lblsalary);
            this.gbox_empay.Controls.Add(this.lblabsent);
            this.gbox_empay.Controls.Add(this.lbldl);
            this.gbox_empay.Controls.Add(this.lbldot);
            this.gbox_empay.Controls.Add(this.lblsm);
            this.gbox_empay.Controls.Add(this.lblbasicpay);
            this.gbox_empay.Controls.Add(this.label1);
            this.gbox_empay.Controls.Add(this.btn_cal);
            this.gbox_empay.Controls.Add(this.lblcn);
            this.gbox_empay.Controls.Add(this.lblEmail);
            this.gbox_empay.Controls.Add(this.lblgander);
            this.gbox_empay.Controls.Add(this.lblname);
            this.gbox_empay.Controls.Add(this.lbl_salary);
            this.gbox_empay.Controls.Add(this.lbl_dabsent);
            this.gbox_empay.Controls.Add(this.lbl_dlate);
            this.gbox_empay.Controls.Add(this.lbl_dot);
            this.gbox_empay.Controls.Add(this.lbl_salmont);
            this.gbox_empay.Controls.Add(this.lbl_bpay);
            this.gbox_empay.Controls.Add(this.lbl_contnum);
            this.gbox_empay.Controls.Add(this.lbl_email);
            this.gbox_empay.Controls.Add(this.lbl_gender);
            this.gbox_empay.Controls.Add(this.lbl_name);
            this.gbox_empay.Font = new System.Drawing.Font("Bodoni MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_empay.Location = new System.Drawing.Point(33, 86);
            this.gbox_empay.Name = "gbox_empay";
            this.gbox_empay.Size = new System.Drawing.Size(751, 384);
            this.gbox_empay.TabIndex = 81;
            this.gbox_empay.TabStop = false;
            this.gbox_empay.Text = "EMPLOYEE PAYROLL";
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalary.Location = new System.Drawing.Point(589, 261);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(0, 18);
            this.lblsalary.TabIndex = 89;
            // 
            // lblabsent
            // 
            this.lblabsent.AutoSize = true;
            this.lblabsent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblabsent.Location = new System.Drawing.Point(589, 221);
            this.lblabsent.Name = "lblabsent";
            this.lblabsent.Size = new System.Drawing.Size(0, 18);
            this.lblabsent.TabIndex = 88;
            // 
            // lbldl
            // 
            this.lbldl.AutoSize = true;
            this.lbldl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldl.Location = new System.Drawing.Point(589, 185);
            this.lbldl.Name = "lbldl";
            this.lbldl.Size = new System.Drawing.Size(0, 18);
            this.lbldl.TabIndex = 87;
            // 
            // lbldot
            // 
            this.lbldot.AutoSize = true;
            this.lbldot.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldot.Location = new System.Drawing.Point(589, 145);
            this.lbldot.Name = "lbldot";
            this.lbldot.Size = new System.Drawing.Size(0, 18);
            this.lbldot.TabIndex = 86;
            // 
            // lblsm
            // 
            this.lblsm.AutoSize = true;
            this.lblsm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsm.Location = new System.Drawing.Point(589, 101);
            this.lblsm.Name = "lblsm";
            this.lblsm.Size = new System.Drawing.Size(0, 18);
            this.lblsm.TabIndex = 85;
            // 
            // lblbasicpay
            // 
            this.lblbasicpay.AutoSize = true;
            this.lblbasicpay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbasicpay.Location = new System.Drawing.Point(589, 58);
            this.lblbasicpay.Name = "lblbasicpay";
            this.lblbasicpay.Size = new System.Drawing.Size(0, 18);
            this.lblbasicpay.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 83;
            // 
            // btn_btm
            // 
            this.btn_btm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_btm.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_btm.Location = new System.Drawing.Point(550, 31);
            this.btn_btm.Name = "btn_btm";
            this.btn_btm.Size = new System.Drawing.Size(92, 33);
            this.btn_btm.TabIndex = 106;
            this.btn_btm.Text = "BACK ";
            this.btn_btm.UseVisualStyleBackColor = false;
            this.btn_btm.Click += new System.EventHandler(this.btn_btm_Click);
            // 
            // payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Payroll_Management_System.Properties.Resources.desk_blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 512);
            this.Controls.Add(this.btn_btm);
            this.Controls.Add(this.gbox_empay);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.lbl_empid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payroll";
            this.Load += new System.EventHandler(this.payroll_Load);
            this.gbox_empay.ResumeLayout(false);
            this.gbox_empay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblgander;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.Label lbl_dabsent;
        private System.Windows.Forms.Label lbl_dlate;
        private System.Windows.Forms.Label lbl_dot;
        private System.Windows.Forms.Label lbl_salmont;
        private System.Windows.Forms.Label lbl_bpay;
        private System.Windows.Forms.Label lbl_contnum;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lbl_empid;
        private System.Windows.Forms.GroupBox gbox_empay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lblabsent;
        private System.Windows.Forms.Label lbldl;
        private System.Windows.Forms.Label lbldot;
        private System.Windows.Forms.Label lblsm;
        private System.Windows.Forms.Label lblbasicpay;
        private System.Windows.Forms.Button btn_btm;

    }
}