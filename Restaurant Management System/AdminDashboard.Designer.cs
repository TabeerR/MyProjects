namespace LoginForm
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.billingToolStripMenuItem.Text = "Billing";
            this.billingToolStripMenuItem.Click += new System.EventHandler(this.billingToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.customerInfoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip2.Size = new System.Drawing.Size(674, 27);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuPrdandbill";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.productToolStripMenuItem.Text = "Products";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // customerInfoToolStripMenuItem
            // 
            this.customerInfoToolStripMenuItem.Name = "customerInfoToolStripMenuItem";
            this.customerInfoToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.customerInfoToolStripMenuItem.Text = "Customer Info";
            this.customerInfoToolStripMenuItem.Click += new System.EventHandler(this.customerInfoToolStripMenuItem_Click);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(643, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(31, 27);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 3;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(167, 191);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Restaurant Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(674, 422);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInfoToolStripMenuItem;

    }
}