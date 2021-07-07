namespace LoginForm
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbUsesrtype = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(191, 268);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbUsesrtype);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 228);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbUsesrtype
            // 
            this.cmbUsesrtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsesrtype.FormattingEnabled = true;
            this.cmbUsesrtype.Items.AddRange(new object[] {
            "Admin",
            "Receptionist",
            "Product Manager"});
            this.cmbUsesrtype.Location = new System.Drawing.Point(74, 146);
            this.cmbUsesrtype.Name = "cmbUsesrtype";
            this.cmbUsesrtype.Size = new System.Drawing.Size(116, 21);
            this.cmbUsesrtype.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(74, 104);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(74, 63);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(9, 146);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User Type";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(9, 107);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "UserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(253, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 31);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 4;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(280, 300);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.ComboBox cmbUsesrtype;
    }
}

