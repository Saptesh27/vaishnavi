using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace customer_registration__form
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l1 = new login();
            l1.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product p1 = new product();
            p1.Show();

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buyproduct b1 = new buyproduct();
            b1.Show();
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
