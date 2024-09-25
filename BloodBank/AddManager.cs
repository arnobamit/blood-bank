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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BloodBank
{
    public partial class AddManager : Form
    {




        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\arnob\\OneDrive\\Documents\\AIUB\\7th Semester\\ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM\\Project\\BBMSDB.mdf\";Integrated Security=True;Connect Timeout=30;";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();

        public AddManager()
        {
            InitializeComponent();
        }
        private void clearData()
        {

            firstNameText.Clear();
            surNameText.Clear();
            userNameText.Clear();
            phoneText.Clear();
            emailText.Clear();
            passwordText.Clear();
            doB.Text = null;
            bloodText.Text = "";
            maleRbtn.Checked = false;
            femaleRbtn.Checked = false;
            cityText.Clear();
            addressText.Clear();
            searchText.Clear();


        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (firstNameText.Text == "" && surNameText.Text == "" && userNameText.Text == "" && phoneText.Text == null && emailText.Text == "" && passwordText.Text == "" && doB.Text == "" && bloodText.Text == "" && maleRbtn.Checked == false || femaleRbtn.Checked == false && cityText.Text == "" && addressText.Text == "")
            {

                MessageBox.Show("Please fill up all required info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {

                string first_name = firstNameText.Text.ToString();
                string last_name = surNameText.Text.ToString();
                string user_name = userNameText.Text.ToString();
                //int phone = int.Parse(phoneText.Text.ToString());
                //txtid.Text.ToString()

                string email = emailText.Text.ToString();
                string password = passwordText.Text.ToString();
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

                string query = "INSERT INTO manager_info (f_name, l_name, m_username, m_phone, m_email, m_password, m_DOB, m_blood, m_gender, m_city, m_address) " +
                                  $"VALUES ('{first_name}', '{last_name}', '{user_name}', '{phoneText.Text.ToString()}', '{email}', '{password}', '{dob}', '{blood}', '{g}', '{city}', '{address}')";

                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                clearData();


                MessageBox.Show("User Added Successful", "Donor", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (searchText.Text != "")
            {

                SqlCommand cmd = new SqlCommand("Update manager_info set f_name = @fname, l_name = @lname, m_username =@username, m_phone = @phone, m_email = @email, m_password = @password, m_DOB = @dob, m_blood = @blood, m_gender =@gender, m_city = @city, m_address = @address where m_id = @id", conn);

                cmd.Parameters.AddWithValue("@id", int.Parse(searchText.Text));
                cmd.Parameters.AddWithValue("@fname", firstNameText.Text);
                cmd.Parameters.AddWithValue("@lname", surNameText.Text);
                cmd.Parameters.AddWithValue("@username", userNameText.Text);
                cmd.Parameters.AddWithValue("@phone", int.Parse(phoneText.Text));
                cmd.Parameters.AddWithValue("@email", emailText.Text);
                cmd.Parameters.AddWithValue("@password", passwordText.Text);
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
                searchText.Clear();

                MessageBox.Show("Update Successfull");

            }









        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Its may delete all informaton", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                if (searchText.Text != "")
                {

                    SqlCommand cmd = new SqlCommand("DELETE manager_info WHERE m_id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(searchText.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    clearData();
                    searchText.Clear();

                    MessageBox.Show("Successfully removed ");
                }
            }



        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();



            SqlCommand cmd = new SqlCommand("Select f_name, l_name, m_username, m_phone, m_email, m_password ,m_DOB , m_blood, m_gender, m_city, m_address from manager_info where m_id = @parm1", conn);

            cmd.Parameters.AddWithValue("@parm1", int.Parse(searchText.Text));
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                firstNameText.Text = reader.GetValue(0).ToString();
                surNameText.Text = reader.GetValue(1).ToString();
                userNameText.Text = reader.GetValue(2).ToString();
                phoneText.Text = reader.GetValue(3).ToString();
                emailText.Text = reader.GetValue(4).ToString();
                passwordText.Text = reader.GetValue(5).ToString();
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
    }
}
