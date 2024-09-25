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
    public partial class updatePatient : Form
    {

        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\arnob\\OneDrive\\Documents\\AIUB\\7th Semester\\ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM\\Project\\BBMSDB.mdf\";Integrated Security=True;Connect Timeout=30;";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();


        public updatePatient()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            registerPanel rp = new registerPanel();
            rp.Show();
            this.Hide();
        }


        private void clearData()
        {

            firstName.Clear();
            surName.Clear();
            phoneText.Clear();
            agetext.Clear();
            doB.Text = null;
            bloodText.Text = "";
            maleRbtn.Checked = false;
            femaleRbtn.Checked = false;
            cityText.Clear();
            addressText.Clear();
            emailText.Clear();

        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearData();
        }



        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();



            SqlCommand cmd = new SqlCommand("Select f_name, l_name, p_phone, p_age ,p_DOB, p_blood, p_gender, p_city, p_address, p_email from patient_info where p_id = @parm1", conn);

            cmd.Parameters.AddWithValue("@parm1", int.Parse(psearchBox.Text));
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                firstName.Text = reader.GetValue(0).ToString();
                surName.Text = reader.GetValue(1).ToString();
                phoneText.Text = reader.GetValue(2).ToString();
                agetext.Text = reader.GetValue(3).ToString();
                doB.Text = reader.GetValue(4).ToString();
                bloodText.Text = reader.GetValue(5).ToString();

                string g = reader.GetValue(6).ToString();
                if (g == "Male")
                {
                    maleRbtn.Checked = true;
                }
                if (g == "Female")
                {
                    femaleRbtn.Checked = true;
                    
                }


                cityText.Text = reader.GetValue(7).ToString();
                addressText.Text = reader.GetValue(8).ToString();
                emailText.Text = reader.GetValue(9).ToString();
                //firstName.Text = reader.GetValue(0).ToString();

            }




        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (psearchBox.Text != "")
            {

                SqlCommand cmd = new SqlCommand("Update patient_info set f_name = @fname, l_name = @lname, p_phone = @phone, p_age = @age, p_DOB = @dob, p_blood = @blood, p_gender =@gender, p_city = @city, p_address = @address, p_email = @email where p_id = @id", conn);

                cmd.Parameters.AddWithValue("@id", int.Parse(psearchBox.Text));
                cmd.Parameters.AddWithValue("@fname", firstName.Text);
                cmd.Parameters.AddWithValue("@lname", surName.Text);
                cmd.Parameters.AddWithValue("@phone", int.Parse(phoneText.Text));
                cmd.Parameters.AddWithValue("@age", agetext.Text);
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
                cmd.Parameters.AddWithValue("@email", emailText.Text);


                cmd.ExecuteNonQuery();
                conn.Close();
                clearData();
                psearchBox.Clear();

                MessageBox.Show("Update Successfull");

            }

            else
            {
               // MessageBox.Show("");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Its may delete all informaton", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                if (psearchBox.Text != "")
                {

                    SqlCommand cmd = new SqlCommand("DELETE donor_info WHERE d_id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(psearchBox.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    clearData();
                    psearchBox.Clear();

                    MessageBox.Show("Successfully removed ");
                }
            }




        }
    }
}

