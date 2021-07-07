namespace Sales_And_Distribution
{
    partial class LogIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIN));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtpbuser = new System.Windows.Forms.TextBox();
            this.txtpbpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.imglogin = new System.Windows.Forms.PictureBox();
            this.pbuser = new System.Windows.Forms.PictureBox();
            this.pbpass = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imglogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(199, 171);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 27);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // txtpbuser
            // 
            this.txtpbuser.BackColor = System.Drawing.Color.White;
            this.txtpbuser.Location = new System.Drawing.Point(150, 248);
            this.txtpbuser.Margin = new System.Windows.Forms.Padding(5);
            this.txtpbuser.MaxLength = 5;
            this.txtpbuser.Name = "txtpbuser";
            this.txtpbuser.Size = new System.Drawing.Size(243, 30);
            this.txtpbuser.TabIndex = 0;
            this.txtpbuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpbuser_KeyPress);
            // 
            // txtpbpassword
            // 
            this.txtpbpassword.Location = new System.Drawing.Point(150, 336);
            this.txtpbpassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtpbpassword.MaxLength = 4;
            this.txtpbpassword.Name = "txtpbpassword";
            this.txtpbpassword.Size = new System.Drawing.Size(243, 30);
            this.txtpbpassword.TabIndex = 1;
            this.txtpbpassword.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(116, 429);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(110, 40);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(268, 429);
            this.btnexit.Margin = new System.Windows.Forms.Padding(5);
            this.btnexit.Name = "btnexit";
            this.btnexit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnexit.Size = new System.Drawing.Size(103, 40);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "E&XIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // imglogin
            // 
            this.imglogin.BackColor = System.Drawing.Color.Transparent;
            this.imglogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imglogin.Image = ((System.Drawing.Image)(resources.GetObject("imglogin.Image")));
            this.imglogin.Location = new System.Drawing.Point(176, 25);
            this.imglogin.Name = "imglogin";
            this.imglogin.Size = new System.Drawing.Size(130, 131);
            this.imglogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imglogin.TabIndex = 4;
            this.imglogin.TabStop = false;
            // 
            // pbuser
            // 
            this.pbuser.Image = ((System.Drawing.Image)(resources.GetObject("pbuser.Image")));
            this.pbuser.Location = new System.Drawing.Point(80, 238);
            this.pbuser.Name = "pbuser";
            this.pbuser.Size = new System.Drawing.Size(62, 51);
            this.pbuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbuser.TabIndex = 5;
            this.pbuser.TabStop = false;
            // 
            // pbpass
            // 
            this.pbpass.Image = ((System.Drawing.Image)(resources.GetObject("pbpass.Image")));
            this.pbpass.Location = new System.Drawing.Point(80, 327);
            this.pbpass.Name = "pbpass";
            this.pbpass.Size = new System.Drawing.Size(63, 52);
            this.pbpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpass.TabIndex = 6;
            this.pbpass.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(80, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(80, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 1);
            this.panel2.TabIndex = 7;
            // 
            // LogIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbpass);
            this.Controls.Add(this.pbuser);
            this.Controls.Add(this.imglogin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpbpassword);
            this.Controls.Add(this.txtpbuser);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LogIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIN";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.imglogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtpbuser;
        private System.Windows.Forms.TextBox txtpbpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox imglogin;
        private System.Windows.Forms.PictureBox pbuser;
        private System.Windows.Forms.PictureBox pbpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

