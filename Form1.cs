using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username, password;

            username = txtuser.Text;
            password = txtpass.Text;
            count = count + 1;

            if (count > 3)
            {
                MessageBox.Show("You have MORE THAN 3 attempted Logins. Please contact your SYSTEM ADMINISTRATOR.");
                Application.Exit();
            }

            if (username == "username" && password == "password") 
            {
                label4.Text = "Log in successful";

            }
            else
            {
                label4.Text = "Invalid Username and password";

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}
