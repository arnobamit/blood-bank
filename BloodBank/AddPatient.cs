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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BloodBank
{
    public partial class addPatient : Form
    {

        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\arnob\\OneDrive\\Documents\\AIUB\\7th Semester\\ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM\\Project\\BBMSDB.mdf\";Integrated Security=True;Connect Timeout=30;";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();

        public addPatient()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            registerPanel rp = new registerPanel();
            rp.Show();
            this.Hide();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (firstName.Text == "" && surName.Text == "" && phoneText.Text == null && doB.Text == "" && bloodText.Text == "" && maleRbtn.Checked == false || femaleRbtn.Checked == false && cityText.Text == "" && addressText.Text == "" && emailText.Text == "")
            {

                MessageBox.Show("Please fill up all required info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {

                string first_name = firstName.Text.ToString();
                string last_name = surName.Text.ToString();
                //int phone = int.Parse(phoneText.Text.ToString());
                //txtid.Text.ToString()

                string email = emailText.Text.ToString(); ;
                string dob = doB.Text.ToString();
                string blood = bloodText.Text.ToString();
                string g = "";
                if (maleRbtn.Checked == true)
                {
                    g = "Male";
                }
                if (femaleRbtn.Checked == true)
                {
                    g = "Female";
                }

                string city = cityText.Text.ToString();
                string address = addressText.Text.ToString();

                //Database

                cmd.Connection = conn;

                string query = "INSERT INTO patient_info (f_name, l_name, p_phone, p_age, p_DOB, p_blood, p_gender, p_city, p_address, p_email) " +
                                  $"VALUES ('{first_name}', '{last_name}', '{phoneText.Text.ToString()}', '{ageText.Text.ToString()}','{dob}', '{blood}', '{g}','{city}','{address}', '{email}')";

                MessageBox.Show("Patient added successful ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();


            }

        }

         private void clearData()
        {

            firstName.Clear();
            surName.Clear();
            phoneText.Clear();
            emailText.Clear();
            doB.Text = null;
            ageText.Clear();
            bloodText.Text = "";
            maleRbtn.Checked = false;
            femaleRbtn.Checked = false;
            cityText.Clear();
            addressText.Clear();


        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
