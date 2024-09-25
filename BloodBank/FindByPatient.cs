using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace BloodBank
{
    public partial class findPatient : Form
    {


        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\arnob\\OneDrive\\Documents\\AIUB\\7th Semester\\ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM\\Project\\BBMSDB.mdf\";Integrated Security=True;Connect Timeout=30;";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();
        public findPatient()
        {
            InitializeComponent();

            //according custom userdashboard


            // Set the starting position of the form
            this.StartPosition = FormStartPosition.Manual; // You can change this to any other value mentioned above
            // Set the location of the form manually
            this.Location = new System.Drawing.Point(605, 195); // Change the values according to your requiremen

        }

      

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string blood = searchBox.Text;


            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT f_name, l_name, p_phone, p_email,p_blood, p_DOB, p_address, p_city from patient_info where p_blood = '" + searchBox.Text + "' ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
