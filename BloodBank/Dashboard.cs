using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class dashboardPanel : Form
    {
        public dashboardPanel()
        {
            InitializeComponent();
        }

        private void findDonner_Click(object sender, EventArgs e)
        {
            findPatient fp = new findPatient();
            fp.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindByLocation findByLocation = new FindByLocation();
            findByLocation.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FindByBlood fb = new FindByBlood();
            fb.Show(this);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindByHospital fh = new FindByHospital(this);
            fh.Show(this);
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FindByBloodBank fbb = new FindByBloodBank(this);
            fbb.Show(this);
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Blood Donation is a nobel, Thank you", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            logIn li = new logIn();
            li.Show(this);
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Still in progress, Thank you", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //ViewProfile vp = new ViewProfile();
            //vp.Show();

        }
    }
}
