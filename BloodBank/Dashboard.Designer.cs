namespace BloodBank
{
    partial class dashboardPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bloodBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.bbBtn = new System.Windows.Forms.Button();
            this.hospitalBtn = new System.Windows.Forms.Button();
            this.locationBtn = new System.Windows.Forms.Button();
            this.donnerBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bloodBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.bbBtn);
            this.panel1.Controls.Add(this.hospitalBtn);
            this.panel1.Controls.Add(this.locationBtn);
            this.panel1.Controls.Add(this.donnerBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 615);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(8, 462);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 4);
            this.panel2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bloodBtn
            // 
            this.bloodBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.bloodBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bloodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bloodBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodBtn.Image = ((System.Drawing.Image)(resources.GetObject("bloodBtn.Image")));
            this.bloodBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bloodBtn.Location = new System.Drawing.Point(31, 227);
            this.bloodBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bloodBtn.Name = "bloodBtn";
            this.bloodBtn.Size = new System.Drawing.Size(166, 47);
            this.bloodBtn.TabIndex = 5;
            this.bloodBtn.Text = "Find Donner by BG";
            this.bloodBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bloodBtn.UseVisualStyleBackColor = false;
            this.bloodBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(55, 548);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(116, 47);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // bbBtn
            // 
            this.bbBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bbBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bbBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbBtn.Image = ((System.Drawing.Image)(resources.GetObject("bbBtn.Image")));
            this.bbBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bbBtn.Location = new System.Drawing.Point(31, 378);
            this.bbBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bbBtn.Name = "bbBtn";
            this.bbBtn.Size = new System.Drawing.Size(166, 47);
            this.bbBtn.TabIndex = 3;
            this.bbBtn.Text = "Blood Bank";
            this.bbBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bbBtn.UseVisualStyleBackColor = false;
            this.bbBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // hospitalBtn
            // 
            this.hospitalBtn.BackColor = System.Drawing.Color.Lavender;
            this.hospitalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hospitalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hospitalBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalBtn.Image = ((System.Drawing.Image)(resources.GetObject("hospitalBtn.Image")));
            this.hospitalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hospitalBtn.Location = new System.Drawing.Point(31, 303);
            this.hospitalBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hospitalBtn.Name = "hospitalBtn";
            this.hospitalBtn.Size = new System.Drawing.Size(166, 47);
            this.hospitalBtn.TabIndex = 2;
            this.hospitalBtn.Text = "Hospital Info";
            this.hospitalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hospitalBtn.UseVisualStyleBackColor = false;
            this.hospitalBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // locationBtn
            // 
            this.locationBtn.BackColor = System.Drawing.Color.LightCyan;
            this.locationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.locationBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationBtn.Image = ((System.Drawing.Image)(resources.GetObject("locationBtn.Image")));
            this.locationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationBtn.Location = new System.Drawing.Point(31, 150);
            this.locationBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.locationBtn.Name = "locationBtn";
            this.locationBtn.Size = new System.Drawing.Size(166, 47);
            this.locationBtn.TabIndex = 1;
            this.locationBtn.Text = "Find Donner by City";
            this.locationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.locationBtn.UseVisualStyleBackColor = false;
            this.locationBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // donnerBtn
            // 
            this.donnerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.donnerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.donnerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.donnerBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donnerBtn.Image = ((System.Drawing.Image)(resources.GetObject("donnerBtn.Image")));
            this.donnerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donnerBtn.Location = new System.Drawing.Point(31, 80);
            this.donnerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.donnerBtn.Name = "donnerBtn";
            this.donnerBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.donnerBtn.Size = new System.Drawing.Size(166, 47);
            this.donnerBtn.TabIndex = 0;
            this.donnerBtn.Text = "Help Patient";
            this.donnerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.donnerBtn.UseVisualStyleBackColor = false;
            this.donnerBtn.Click += new System.EventHandler(this.findDonner_Click);
            // 
            // dashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1040, 615);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "dashboardPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bloodBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button bbBtn;
        private System.Windows.Forms.Button hospitalBtn;
        private System.Windows.Forms.Button locationBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button donnerBtn;
        private System.Windows.Forms.Panel panel2;
    }
}