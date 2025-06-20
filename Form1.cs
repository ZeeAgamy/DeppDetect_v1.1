namespace DeppDetect_v1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_user.Text == " Enter your Username"
                || login_pass.Text == " Enter your Password")
            {
                MessageBox.Show("Please fill blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Home homeForm = new Home();
                homeForm.Show();
                this.Hide();
            }
        }

        private void login_user_Enter(object sender, EventArgs e)
        {
            if (login_user.Text == " Enter your Username")
            {
                login_user.Text = "";
                login_user.ForeColor = Color.Black;
            }
        }

        private void login_user_Leave(object sender, EventArgs e)
        {
            if (login_user.Text == "")
            {
                login_user.Text = " Enter your Username";
                login_user.ForeColor = Color.Silver;
            }
        }

        private void login_pass_Enter(object sender, EventArgs e)
        {
            if (login_pass.Text == " Enter your Password")
            {
                login_pass.Text = "";
                login_pass.ForeColor = Color.Black;
            }
        }

        private void login_pass_Leave(object sender, EventArgs e)
        {
            if (login_pass.Text == "")
            {
                login_pass.Text = " Enter your Password";
                login_pass.ForeColor = Color.Silver;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }
    }
}
