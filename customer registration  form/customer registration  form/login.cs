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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "vaishnavi" && textBox2.Text == "2707")
            {
                Home f1 = new Home ();
                f1.Show();
            }
            else
            {
                MessageBox.Show("incorrect user or pass");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
