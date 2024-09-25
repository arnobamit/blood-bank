using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BloodBank
{
    public partial class logIn : Form
    {


        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\arnob\\OneDrive\\Documents\\AIUB\\7th Semester\\ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM\\Project\\BBMSDB.mdf\";Integrated Security=True;Connect Timeout=100;";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();


        public logIn()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (userNameText.Text == "enter your username")
            {
                userNameText.Text = "";
                userNameText.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (userNameText.Text == "")
            {
                userNameText.Text = "enter your username";
                userNameText.ForeColor = Color.Silver;
            }
        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (passwordText.Text == "enter your password")
            {

                passwordText.Text = "";
                passwordText.ForeColor = Color.Black;
                passwordText.UseSystemPasswordChar = true;

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                passwordText.UseSystemPasswordChar = false;


            }
            else { passwordText.UseSystemPasswordChar = true; }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (passwordText.Text == "")
            {
                passwordText.Text = "enter your password";
                passwordText.ForeColor = Color.Silver;
                passwordText.UseSystemPasswordChar = false;
            }
        }



        private void loginBtn_Click(object sender, EventArgs e)

        {
            string username = userNameText.Text;
            string password = passwordText.Text;

            try {

                string querry = "SELECT * from donor_info where d_username = '" + userNameText.Text + "' AND d_password = '" + passwordText.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = userNameText.Text;
                    password = passwordText.Text;

                    dashboardPanel dp = new dashboardPanel();
                    dp.Show();
                    this.Hide();

                }

                else 
                { MessageBox.Show("Invalid login deatails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
           }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid login deatails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        } 

        private void regnowBtn_Click(object sender, EventArgs e)
        {
           
            {
                userRegistation ur = new userRegistation();
                ur.Show();
                this.Hide();
            }
        }

        private void authorityAccess_Click(object sender, EventArgs e)
        {
            authorityAccess aA = new authorityAccess();
            aA.Show();
            this.Hide();
        }
    }
}
