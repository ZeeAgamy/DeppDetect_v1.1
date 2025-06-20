using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeppDetect_v1._1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_user_Enter(object sender, EventArgs e)
        {
            if (signup_user.Text == " Enter your Username")
            {
                signup_user.Text = "";
                signup_user.ForeColor = Color.Black;
            }
        }

        private void signup_user_Leave(object sender, EventArgs e)
        {
            if (signup_user.Text == "")
            {
                signup_user.Text = " Enter your Username";
                signup_user.ForeColor = Color.Silver;
            }
        }

        private void signup_pass_Enter(object sender, EventArgs e)
        {
            if (signup_pass.Text == " Enter your Password")
            {
                signup_pass.Text = "";
                signup_pass.ForeColor = Color.Black;
            }
        }

        private void signup_pass_Leave(object sender, EventArgs e)
        {
            if (signup_pass.Text == "")
            {
                signup_pass.Text = " Enter your Password";
                signup_pass.ForeColor = Color.Silver;
            }
        }

        private void signup_confpass_Enter(object sender, EventArgs e)
        {
            if (signup_confpass.Text == " Confirm Password")
            {
                signup_confpass.Text = "";
                signup_confpass.ForeColor = Color.Black;
            }
        }

        private void signup_confpass_Leave(object sender, EventArgs e)
        {
            if (signup_confpass.Text == "")
            {
                signup_confpass.Text = " Confirm Password";
                signup_confpass.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (signup_user.Text == " Enter your Username"
                || signup_pass.Text == " Enter your Password" 
                || signup_confpass.Text == " Confirm Password")
            {
                MessageBox.Show("Please fill blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
    }
}
