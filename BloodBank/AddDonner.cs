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
    public partial class addDonner : Form

    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\arnob\\OneDrive\\Documents\\AIUB\\7th Semester\\ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM\\Project\\BBMSDB.mdf\";Integrated Security=True;Connect Timeout=30;";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();



        public addDonner()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            registerPanel rp = new registerPanel();
            rp.Show();
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {


            if (firstName.Text == "" && surName.Text == "" && userName.Text == "" && phoneBox.Text == null && emailBox.Text == "" && firstPassword.Text == "" && confirmPassword.Text == "" && doB.Text == "" && bloodBox.Text == "" && maleRbtn.Checked == false || femaleRbtn.Checked == false && cityBox.Text == "" && addressBox.Text == "")
            {

                MessageBox.Show("Please fill up all required info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (firstPassword.Text != confirmPassword.Text)
            {
                {
                    MessageBox.Show("confirm password must be same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Donor Added Successful", "Donor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

           

            string first_name = firstName.Text.ToString();
            string last_name = surName.Text.ToString();
            string user_name = userName.Text.ToString();
            //int phone = int.Parse(phoneText.Text.ToString());
            //txtid.Text.ToString()

            string email = emailBox.Text.ToString();
            string password = firstPassword.Text.ToString();
            string dob = doB.Text.ToString();
            string blood = bloodBox.Text.ToString();

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
                              $"VALUES ('{first_name}', '{last_name}', '{user_name}', '{phoneBox.Text.ToString()}', '{email}', '{password}', '{dob}', '{blood}', '{g}', '{city}', '{address}')";

            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            clearData();


        }


        private void clearData()
        {

            firstName.Clear();
            surName.Clear();
            userName.Clear();
            phoneBox.Clear();
            emailBox.Clear();
            firstPassword.Clear();
            confirmPassword.Clear();
            doB.Text = null;
            bloodBox.Text = "";
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
