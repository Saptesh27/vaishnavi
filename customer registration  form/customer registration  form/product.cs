using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace customer_registration__form
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        private void product_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
            label13.Text = textBox5.Text;
            label14.Text = textBox6.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\vaishnavi\\balaji.accdb");
            OleDbCommand cmd = new OleDbCommand("insert into cust2(pname,pbrand,prate,pquality,pmdate,pexdate) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("data store successfully");

        }
    }
}
