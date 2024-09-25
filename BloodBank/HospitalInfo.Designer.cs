namespace BloodBank
{
    partial class HospitalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalInfo));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hnameText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hidBox = new System.Windows.Forms.TextBox();
            this.hsearchBtn = new System.Windows.Forms.Button();
            this.hstockText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hospital Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "CIty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email :";
            // 
            // hnameText
            // 
            this.hnameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hnameText.Location = new System.Drawing.Point(193, 211);
            this.hnameText.Name = "hnameText";
            this.hnameText.Size = new System.Drawing.Size(585, 30);
            this.hnameText.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Address :";
            // 
            // phoneText
            // 
            this.phoneText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneText.Location = new System.Drawing.Point(193, 267);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(204, 30);
            this.phoneText.TabIndex = 19;
            // 
            // addressText
            // 
            this.addressText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressText.Location = new System.Drawing.Point(572, 324);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(204, 113);
            this.addressText.TabIndex = 21;
            this.addressText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Unispace", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(341, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 48);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hospital Info";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetBtn.Image")));
            this.resetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetBtn.Location = new System.Drawing.Point(839, 232);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(106, 47);
            this.resetBtn.TabIndex = 25;
            this.resetBtn.Text = "Reset";
            this.resetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(837, 383);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 47);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.Location = new System.Drawing.Point(837, 537);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(106, 47);
            this.closeBtn.TabIndex = 27;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 488);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(808, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 389);
            this.panel2.TabIndex = 38;
            // 
            // emailText
            // 
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailText.Location = new System.Drawing.Point(193, 326);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(204, 30);
            this.emailText.TabIndex = 39;
            // 
            // cityText
            // 
            this.cityText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityText.Location = new System.Drawing.Point(572, 267);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(204, 30);
            this.cityText.TabIndex = 20;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeBtn.Location = new System.Drawing.Point(837, 467);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(108, 46);
            this.removeBtn.TabIndex = 44;
            this.removeBtn.Text = "Remove";
            this.removeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(742, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "H-ID :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(739, 162);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(213, 2);
            this.flowLayoutPanel1.TabIndex = 48;
            // 
            // hidBox
            // 
            this.hidBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hidBox.Location = new System.Drawing.Point(801, 127);
            this.hidBox.Name = "hidBox";
            this.hidBox.Size = new System.Drawing.Size(64, 30);
            this.hidBox.TabIndex = 49;
            // 
            // hsearchBtn
            // 
            this.hsearchBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.hsearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsearchBtn.Location = new System.Drawing.Point(869, 126);
            this.hsearchBtn.Name = "hsearchBtn";
            this.hsearchBtn.Size = new System.Drawing.Size(76, 30);
            this.hsearchBtn.TabIndex = 50;
            this.hsearchBtn.Text = "Search";
            this.hsearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsearchBtn.UseVisualStyleBackColor = false;
            this.hsearchBtn.Click += new System.EventHandler(this.hsearchBtn_Click);
            // 
            // hstockText
            // 
            this.hstockText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hstockText.Location = new System.Drawing.Point(193, 383);
            this.hstockText.Name = "hstockText";
            this.hstockText.Size = new System.Drawing.Size(204, 30);
            this.hstockText.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 52;
            this.label4.Text = "Stock :";
            // 
            // addBtn
            // 
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(837, 304);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(106, 47);
            this.addBtn.TabIndex = 53;
            this.addBtn.Text = "ADD";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.hstockText);
            this.panel1.Controls.Add(this.hsearchBtn);
            this.panel1.Controls.Add(this.hidBox);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.cityText);
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addressText);
            this.panel1.Controls.Add(this.phoneText);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.hnameText);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 700);
            this.panel1.TabIndex = 3;
            // 
            // HospitalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HospitalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HospitalInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hnameText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.RichTextBox addressText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox hidBox;
        private System.Windows.Forms.Button hsearchBtn;
        private System.Windows.Forms.TextBox hstockText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel1;
    }
}