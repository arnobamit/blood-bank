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
    public partial class authorityAccess : Form
    {
        public authorityAccess()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            adminLogin al = new adminLogin(this);
               al.Show();
               
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            
        }


        private void managerBtn_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin(this);
            ml.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logIn logIn = new logIn();
            logIn.Show();
            this.Hide();
        }

        private void authorityAccess_Load(object sender, EventArgs e)
        {

        }
    }
}
