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
    public partial class BloodBankInformartion : Form
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\arnob\\OneDrive\\Documents\\AIUB\\7th Semester\\ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM\\Project\\BBMSDB.mdf\";Integrated Security=True;Connect Timeout=30;";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();




        public BloodBankInformartion()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            managerPanel mp = new managerPanel();
            mp.Show();
            this.Hide();
        }

        private void clearData()
        {

            nameText.Clear();
            phoneText.Clear();
            emailText.Clear();
            cityText.Clear();
            addressText.Clear();
            stockText.Clear();
            searchBox.Clear();
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {


            if (nameText.Text == "" && phoneText.Text == "" && emailText.Text == "" && cityText.Text == "" && addressText.Text == "" && stockText.Text == "")
            {

                MessageBox.Show("Please fill up all required info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {

                string name = nameText.Text.ToString();
                //int phone = int.Parse(phoneText.Text.ToString());
                //txtid.Text.ToString()

                string email = emailText.Text.ToString();
                string city = cityText.Text.ToString();
                string address = addressText.Text.ToString();

                //Database

                cmd.Connection = conn;

                string query = "INSERT INTO bb_info (bb_name, bb_phone,bb_email, bb_city, bb_address,bb_stock ) " +
                                  $"VALUES ('{name}', '{phoneText.Text.ToString()}', '{email}', '{city}', '{address}', '{stockText.Text.ToString()}')";

                MessageBox.Show("Information added successful ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                clearData();
                searchBox.Clear();

            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (searchBox.Text != "")
            {

                SqlCommand cmd = new SqlCommand("UPDATE bb_info set bb_name = @name, bb_phone = @phone, bb_email = @email, bb_city = @city, bb_address = @address, bb_stock =@stock where bb_id = @id", conn);

                cmd.Parameters.AddWithValue("@id", int.Parse(stockText.Text));
                cmd.Parameters.AddWithValue("@name", nameText.Text);
                cmd.Parameters.AddWithValue("@phone", int.Parse(phoneText.Text));
                cmd.Parameters.AddWithValue("@email", emailText.Text);
                cmd.Parameters.AddWithValue("@city", cityText.Text);
                cmd.Parameters.AddWithValue("@address", addressText.Text);
                cmd.Parameters.AddWithValue("@stock", int.Parse(stockText.Text));



                cmd.ExecuteNonQuery();
                conn.Close();
                clearData();
                searchBox.Clear();

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

                if (searchBox.Text != "")
                {

                    SqlCommand cmd = new SqlCommand("DELETE bb_info WHERE bb_id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(searchBox.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    clearData();
                    searchBox.Clear();

                    MessageBox.Show("Successfully removed ");
                }
                else { MessageBox.Show("Enter Value first"); }


            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();



            SqlCommand cmd = new SqlCommand("Select bb_name, bb_phone,bb_email, bb_city, bb_address,bb_stock from bb_info where bb_id = @parm1", conn);

            cmd.Parameters.AddWithValue("@parm1", int.Parse(searchBox.Text));
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                nameText.Text = reader.GetValue(0).ToString();
                phoneText.Text = reader.GetValue(1).ToString();
                emailText.Text = reader.GetValue(2).ToString();
                cityText.Text = reader.GetValue(3).ToString();
                addressText.Text = reader.GetValue(4).ToString();
                stockText.Text = reader.GetValue(5).ToString();


            }
        }
    }
}