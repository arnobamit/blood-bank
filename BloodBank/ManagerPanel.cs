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
    public partial class managerPanel : Form
    {
        public managerPanel()
        {
            InitializeComponent();
        }

        private void hospitalinfoBtn_Click(object sender, EventArgs e)
        {
            HospitalInfo hi = new HospitalInfo();
            hi.Show();  
            this.Hide();
        }

        private void hospitalstockBtn_Click(object sender, EventArgs e)
        {
     
        }

        private void bbankBtn_Click(object sender, EventArgs e)
        {
            BloodBankInformartion bbi = new BloodBankInformartion();
            bbi.Show();
            this.Hide();
        }

        private void bbankstockBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void mviewBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            authorityAccess aa = new authorityAccess();
            aa.Show();
            this.Hide();
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
