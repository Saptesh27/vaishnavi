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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a;
            if (radioButton1.Checked == true)
            {
                a = radioButton1.Text;
            }
            else
            {
                a = radioButton2.Text;
            }
            label8.Text = textBox1.Text;
            label9.Text = textBox2.Text;
            label10.Text = a;
            label11.Text = comboBox1.SelectedItem.ToString();
            label12.Text = textBox3.Text;
            label13.Text = textBox4.Text;

        }

        private void button2_Click(object sender, EventArgs e)

        {
            String a;
            if(radioButton1.Checked==true)
            {
                a=radioButton1.Text;
            }
            else
            {
                a=radioButton2.Text;
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\vaishnavi\\balaji.accdb");
            OleDbCommand cmd = new OleDbCommand("insert into cust(cname,cadress,gender,ccity,username,cpassword) values('" + textBox1.Text + "','" + textBox2.Text + "','" + a + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("data stored successfully");
        }

        
    }
}
