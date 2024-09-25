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



    public partial class HospitalInfo : Form
    {

        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\arnob\\OneDrive\\Documents\\AIUB\\7th Semester\\ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM\\Project\\BBMSDB.mdf\";Integrated Security=True;Connect Timeout=30;";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();


        public HospitalInfo()
        {
            InitializeComponent();
        }

        private void clearData()
        {

            hnameText.Clear();
            phoneText.Clear();
            emailText.Clear();
            cityText.Clear();
            addressText.Clear();
            hstockText.Clear();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (hidBox.Text != "")
            {

                SqlCommand cmd = new SqlCommand("UPDATE hospital_info set hospital_name = @name, h_phone = @phone, h_email = @email, h_city = @city, h_address = @address, h_stock =@stock where h_id = @id", conn);

                cmd.Parameters.AddWithValue("@id", int.Parse(hidBox.Text));
                cmd.Parameters.AddWithValue("@name", hnameText.Text);
                cmd.Parameters.AddWithValue("@phone", int.Parse(phoneText.Text));
                cmd.Parameters.AddWithValue("@email", emailText.Text);
                cmd.Parameters.AddWithValue("@city", cityText.Text);
                cmd.Parameters.AddWithValue("@address", addressText.Text);
                cmd.Parameters.AddWithValue("@stock", int.Parse(hstockText.Text));



                cmd.ExecuteNonQuery();
                conn.Close();
                clearData();
                hidBox.Clear();
               
                clearData();

                MessageBox.Show("Update Successfully");


            }

          




        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Its may delete all informaton", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                if (hidBox.Text != "")
                {

                    SqlCommand cmd = new SqlCommand("DELETE hospital_info WHERE h_id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(hidBox.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    clearData();
                    hidBox.Clear();

                    MessageBox.Show("Successfully removed ");
                }
                else { MessageBox.Show("Enter Value first"); }


            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            managerPanel ml = new managerPanel();
            ml.Show();
            this.Hide();
        }

        private void hsearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();



            SqlCommand cmd = new SqlCommand("Select hospital_name, h_phone, h_email, h_city, h_address, h_stock from hospital_info where h_id = @parm1", conn);

            cmd.Parameters.AddWithValue("@parm1", int.Parse(hidBox.Text));
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                hnameText.Text = reader.GetValue(0).ToString();
                phoneText.Text = reader.GetValue(1).ToString();
                emailText.Text = reader.GetValue(2).ToString();
                cityText.Text = reader.GetValue(3).ToString();
                addressText.Text = reader.GetValue(4).ToString();
                hstockText.Text = reader.GetValue(5).ToString();


            }


        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            if (hnameText.Text == "" && phoneText.Text == "" && emailText.Text == "" && cityText.Text == "" && addressText.Text == "" && hstockText.Text == "")
            {

                MessageBox.Show("Please fill up all required info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {

                string name = hnameText.Text.ToString();
                //int phone = int.Parse(phoneText.Text.ToString());
                //txtid.Text.ToString()

                string email = emailText.Text.ToString();
                string city = cityText.Text.ToString();
                string address = addressText.Text.ToString();

                //Database

                cmd.Connection = conn;

                string query = "INSERT INTO hospital_info (hospital_name, h_phone,h_email, h_city, h_address,h_stock ) " +
                                  $"VALUES ('{name}', '{phoneText.Text.ToString()}', '{email}', '{city}', '{address}', '{hstockText.Text.ToString()}')";

                MessageBox.Show("Information added successful ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                clearData();
                hidBox.Clear();





            }
        }
    }
}