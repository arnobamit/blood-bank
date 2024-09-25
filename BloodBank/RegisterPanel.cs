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
    public partial class registerPanel : Form
    {
        public registerPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adddonnerBtn_Click(object sender, EventArgs e)
        {
            addDonner ad = new addDonner();
            ad.Show();
            this.Hide();
        }

        private void donnerupdateBtn_Click(object sender, EventArgs e)
        {
            donnerUpdate du = new donnerUpdate();
            du.Show();
            this.Hide();
        }

        private void addpaitientBtn_Click(object sender, EventArgs e)
        {
            addPatient ap = new addPatient();
            ap.Show();
            this.Hide();
        }

        private void parientupdateBtn_Click(object sender, EventArgs e)
        {
            updatePatient up = new updatePatient();
            up.Show();
            this.Hide();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            registerViewinfo vf = new registerViewinfo();
            vf.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            authorityAccess aa = new authorityAccess();
            aa.Show();
            this.Hide();
        }
    }
}
