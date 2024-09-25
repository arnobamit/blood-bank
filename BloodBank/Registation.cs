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
    public partial class userRegistation : Form
    {

        private static string connectionString= "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\arnob\\OneDrive\\Documents\\AIUB\\7th Semester\\ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM\\Project\\BBMSDB.mdf\";Integrated Security=True;Connect Timeout=30;";
		

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();

        public userRegistation()
        {
            InitializeComponent();
            
        }

     

        private void regiBtn_Click(object sender, EventArgs e)
        {

            if (firstName.Text == "" && surName.Text == "" && userName.Text == "" && phoneText.Text == null && emailText.Text == "" && passwordFirst.Text == "" && confirmPassword.Text == "" && doB.Text == "" && bloodGroup.Text == "" && maleRbtn.Checked == false|| femaleRbtn.Checked== false && cityBox.Text== "" && addressBox.Text == "")
            {

                MessageBox.Show("Please fill up all required info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              

            }
           


            else if (passwordFirst.Text != confirmPassword.Text)
            {

                MessageBox.Show("confirm password must be same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            else
            {
                string first_name = firstName.Text.ToString();
                string last_name = surName.Text.ToString();
                string user_name = userName.Text.ToString();
                //int phone = int.Parse(phoneText.Text.ToString());
                //txtid.Text.ToString()

                string email = emailText.Text.ToString();
                string password = passwordFirst.Text.ToString();
                string dob = doB.Text.ToString();
                string blood = bloodGroup.Text.ToString();

                string g = "";
                if (maleRbtn.Checked == true)
                {
                    g = "Male";
                }
                if (femaleRbtn.Checked == true)
                {
                    g = "Female";
                }

                string city = cityBox.Text.ToString();
                string address = addressBox.Text.ToString();

                //Database

                cmd.Connection = conn;

                string query = "INSERT INTO donor_info (f_name, l_name, d_username, d_phone, d_email, d_password, d_DOB, d_blood, d_gender, d_city, d_address) " +
                                  $"VALUES ('{first_name}', '{last_name}', '{user_name}', '{phoneText.Text.ToString()}', '{email}', '{password}', '{dob}', '{blood}', '{g}', '{city}', '{address}')";

                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Registration Successfull");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            logIn ul = new logIn();
            ul.Show();
            this.Hide();
        }

        private void chickBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logIn bul = new logIn();
            bul.Show();
            this.Hide();
        }


        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog d1 = new OpenFileDialog();
            if (d1.ShowDialog() == DialogResult.OK)
            {
                uploadPic.Image = new Bitmap(d1.FileName);
            }
        }

        private void clearData()
        {

            firstName.Clear();
            surName.Clear();
            userName.Clear();
            phoneText.Clear();
            emailText.Clear();
            passwordFirst.Clear();
            confirmPassword.Clear();
            doB.Text = null;
            bloodGroup.Text = "";
            maleRbtn.Checked = false;
            femaleRbtn.Checked = false;
            cityBox.Clear();
            addressBox.Clear();


        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
