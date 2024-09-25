namespace BloodBank
{
    partial class managerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bbankBtn = new System.Windows.Forms.Button();
            this.hospitalinfoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bbankBtn);
            this.panel1.Controls.Add(this.hospitalinfoBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(787, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 615);
            this.panel1.TabIndex = 3;
            // 
            // bbankBtn
            // 
            this.bbankBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bbankBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbankBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bbankBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbankBtn.Image = ((System.Drawing.Image)(resources.GetObject("bbankBtn.Image")));
            this.bbankBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bbankBtn.Location = new System.Drawing.Point(47, 259);
            this.bbankBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bbankBtn.Name = "bbankBtn";
            this.bbankBtn.Size = new System.Drawing.Size(166, 47);
            this.bbankBtn.TabIndex = 26;
            this.bbankBtn.Text = "BloodBank Info";
            this.bbankBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bbankBtn.UseVisualStyleBackColor = false;
            this.bbankBtn.Click += new System.EventHandler(this.bbankBtn_Click);
            // 
            // hospitalinfoBtn
            // 
            this.hospitalinfoBtn.BackColor = System.Drawing.Color.Lavender;
            this.hospitalinfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hospitalinfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hospitalinfoBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalinfoBtn.Image = ((System.Drawing.Image)(resources.GetObject("hospitalinfoBtn.Image")));
            this.hospitalinfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hospitalinfoBtn.Location = new System.Drawing.Point(47, 121);
            this.hospitalinfoBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hospitalinfoBtn.Name = "hospitalinfoBtn";
            this.hospitalinfoBtn.Size = new System.Drawing.Size(166, 47);
            this.hospitalinfoBtn.TabIndex = 25;
            this.hospitalinfoBtn.Text = "Hospital Info";
            this.hospitalinfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hospitalinfoBtn.UseVisualStyleBackColor = false;
            this.hospitalinfoBtn.Click += new System.EventHandler(this.hospitalinfoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hospital Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(75, 544);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(117, 41);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // managerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 615);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "managerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button hospitalinfoBtn;
        private System.Windows.Forms.Button bbankBtn;
    }
}