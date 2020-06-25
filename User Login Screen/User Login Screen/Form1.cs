using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Login_Screen
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
        String user = "Ford";
        String pass = "123456";
        int hak = 3;
        private void button1_Click(object sender, EventArgs e)
        {
if(textBox1.Text=="" || textBox2.Text == "")
            {
                hak--;
                MessageBox.Show("No Empty !  "+hak);
            }
else if(textBox1.Text==user && textBox2.Text == pass)
            {
                Form2 form2 = new Form2();
                form2.Show();

            }
else if(textBox1.Text!=user || textBox2.Text != pass)
            {
                MessageBox.Show("Invalid username or password"+hak);
                hak--;
            }
            if (hak == 0)
            {
                Application.Exit();
            }
        }
    }
}
