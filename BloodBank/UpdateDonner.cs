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
using System.Xml.Linq;

namespace BloodBank
{
    public partial class donnerUpdate : Form
    {

        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\arnob\\OneDrive\\Documents\\AIUB\\7th Semester\\ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM\\Project\\BBMSDB.mdf\";Integrated Security=True;Connect Timeout=30;";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();

        public donnerUpdate()
        {
            InitializeComponent();
        }


        private void clearData()
        {

            firstName.Clear();
            surName.Clear();
            userName.Clear();
            firstName.Clear();
            phoneText.Clear();
            emailText.Clear();
            firstpasswordText.Clear();
            confirmpasswordText.Clear();
            doB.Text = null;
            bloodText.Text = "";
            maleRbtn.Checked = false;
            femaleRbtn.Checked = false;
            cityText.Clear();
            addressText.Clear();
            didText.Clear();


        }


        private void saveBtn_Click_1(object sender, EventArgs e)
        {

            if (firstName.Text == "" && surName.Text == "" && userName.Text == "" && phoneText.Text == null && emailText.Text == "" && firstpasswordText.Text == "" && confirmpasswordText.Text == "" && doB.Text == "" && bloodText.Text == "" && maleRbtn.Checked == false || femaleRbtn.Checked == false && cityText.Text == "" && addressText.Text == "")
            {

                MessageBox.Show("Please fill up all required info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (firstpasswordText.Text != confirmpasswordText.Text)
            {

                {

                    MessageBox.Show("confirm password must be same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {

                MessageBox.Show("User updated successful ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);


                string first_name = firstName.Text.ToString();
                string last_name = surName.Text.ToString();
                string user_name = userName.Text.ToString();
                //int phone = int.Parse(phoneText.Text.ToString());
                //txtid.Text.ToString()

                string email = emailText.Text.ToString();
                string password = firstpasswordText.Text.ToString();
                string dob = doB.Text.ToString();
                string blood = bloodText.Text.ToString();

                string g = "";
                if (maleRbtn.Checked == true)
                {
                    g = "Male";
                }
                else if (femaleRbtn.Checked == true)
                {
                    g = "Female";
                }

                string city = cityText.Text.ToString();
                string address = addressText.Text.ToString();

                //Database

                cmd.Connection = conn;

                string query = "" +
                                  $"VALUES ('{first_name}', '{last_name}', '{user_name}', '{phoneText.Text.ToString()}', '{email}', '{password}', '{dob}', '{blood}', '{g}', '{city}', '{address}')";



                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void resetBtn_Click_1(object sender, EventArgs e)
        {
            clearData();
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            registerPanel rp = new registerPanel();
            rp.Show();
            this.Hide();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Its may delete all informaton", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                if (didText.Text != "")
                {

                    SqlCommand cmd = new SqlCommand("DELETE donor_info WHERE d_id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(didText.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    clearData();
                    didText.Clear();

                    MessageBox.Show("Successfully removed ");
                }
            }




        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(didText.Text.ToString());

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();



            SqlCommand cmd = new SqlCommand("Select f_name, l_name, d_username, d_phone, d_email, d_password, d_DOB, d_blood, d_gender, d_city, d_address from donor_info where d_id = @parm1", conn);

            cmd.Parameters.AddWithValue("@parm1", int.Parse(didText.Text));
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                firstName.Text = reader.GetValue(0).ToString();
                surName.Text = reader.GetValue(1).ToString();
                userName.Text = reader.GetValue(2).ToString();
                phoneText.Text = reader.GetValue(3).ToString();
                emailText.Text = reader.GetValue(4).ToString();
                firstpasswordText.Text = reader.GetValue(5).ToString();
                confirmpasswordText.Text = reader.GetValue(5).ToString();
                doB.Text = reader.GetValue(6).ToString();
                bloodText.Text = reader.GetValue(7).ToString();

                string g = reader.GetValue(8).ToString();
                if (g == "Male")
                {
                    maleRbtn.Checked = true;
                }
                if (g == "Female")
                {
                    femaleRbtn.Checked = true;
                }


                cityText.Text = reader.GetValue(9).ToString();
                addressText.Text = reader.GetValue(10).ToString();
                //firstName.Text = reader.GetValue(0).ToString();

            }




        }

        private void saveBtn_Click(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (didText.Text != "")
            {

                SqlCommand cmd = new SqlCommand("Update donor_info set f_name = @fname, l_name = @lname, d_username =@username, d_phone = @phone, d_email = @email, d_password =@password, d_DOB = @dob, d_blood = @blood, d_gender =@gender, d_city = @city, d_address = @address where d_id = @id", conn);

                cmd.Parameters.AddWithValue("@id", int.Parse(didText.Text));
                cmd.Parameters.AddWithValue("@fname", firstName.Text);
                cmd.Parameters.AddWithValue("@lname", surName.Text);
                cmd.Parameters.AddWithValue("@username", userName.Text);
                cmd.Parameters.AddWithValue("@phone", int.Parse(phoneText.Text));
                cmd.Parameters.AddWithValue("@email", emailText.Text);
                cmd.Parameters.AddWithValue("@password", firstpasswordText.Text);
                cmd.Parameters.AddWithValue("@dob", doB.Text);
                cmd.Parameters.AddWithValue("@blood", bloodText.Text);
               
                string g = "";
                
                if (g == "Male")
                {
                    maleRbtn.Checked = true;
                }
                if (g == "Female")
                {
                    femaleRbtn.Checked = true;
                }
                cmd.Parameters.AddWithValue("@gender", g);
                cmd.Parameters.AddWithValue("@city", cityText.Text);
                cmd.Parameters.AddWithValue("@address", addressText.Text);



                cmd.ExecuteNonQuery();
                conn.Close();
                clearData();
                didText.Clear();

                MessageBox.Show("Update Successfull");
            }


        }
    }
}