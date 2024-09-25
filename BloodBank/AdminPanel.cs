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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void managerBtn_Click(object sender, EventArgs e)
        {
            managerPanel mp = new managerPanel();
            mp.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRegister ar = new AddRegister();
            ar.Show();
            this.Hide();
        }

        private void addmanagerBtn_Click(object sender, EventArgs e)
        {
            AddManager am = new AddManager();
            am.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            authorityAccess al = new authorityAccess();
            al.Show();
            this.Hide();
        }
    }
}
