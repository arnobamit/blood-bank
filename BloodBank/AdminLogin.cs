using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class adminLogin : Form
    {
        authorityAccess authaccess;
        public adminLogin(authorityAccess authaccess)
        {
            InitializeComponent();

            //according custom userdashboard


            // Set the starting position of the form
            this.StartPosition = FormStartPosition.Manual; // You can change this to any other value mentioned above
            // Set the location of the form manually
            this.Location = new System.Drawing.Point(605, 175);
            this.authaccess = authaccess;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (adminuserName.Text == "admin" && adminPassword.Text == "admin32")
            {
                AdminPanel ap = new AdminPanel();
                
                ap.Show();
                this.Hide();
                authaccess.Hide();
            }
            else if (adminuserName.Text == "" && adminPassword.Text == "")
            {
                MessageBox.Show("Please fill up all required info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (adminuserName.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (adminPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void adminuserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
