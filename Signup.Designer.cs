namespace DeppDetect_v1._1
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            signup_user = new TextBox();
            signup_pass = new TextBox();
            signup_confpass = new TextBox();
            button1 = new Button();
            label1 = new Label();
            exit = new Label();
            SuspendLayout();
            // 
            // signup_user
            // 
            signup_user.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_user.ForeColor = SystemColors.ActiveBorder;
            signup_user.Location = new Point(208, 230);
            signup_user.Name = "signup_user";
            signup_user.Size = new Size(416, 38);
            signup_user.TabIndex = 0;
            signup_user.Text = " Enter your Username";
            signup_user.Enter += signup_user_Enter;
            signup_user.Leave += signup_user_Leave;
            // 
            // signup_pass
            // 
            signup_pass.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_pass.ForeColor = SystemColors.ActiveBorder;
            signup_pass.Location = new Point(208, 282);
            signup_pass.Name = "signup_pass";
            signup_pass.Size = new Size(416, 38);
            signup_pass.TabIndex = 0;
            signup_pass.Text = " Enter your Password";
            signup_pass.Enter += signup_pass_Enter;
            signup_pass.Leave += signup_pass_Leave;
            // 
            // signup_confpass
            // 
            signup_confpass.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_confpass.ForeColor = SystemColors.ActiveBorder;
            signup_confpass.Location = new Point(208, 334);
            signup_confpass.Name = "signup_confpass";
            signup_confpass.Size = new Size(416, 38);
            signup_confpass.TabIndex = 0;
            signup_confpass.Text = " Confirm Password";
            signup_confpass.Enter += signup_confpass_Enter;
            signup_confpass.Leave += signup_confpass_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(208, 386);
            button1.Name = "button1";
            button1.Size = new Size(416, 50);
            button1.TabIndex = 1;
            button1.Text = "Signup";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(304, 440);
            label1.Name = "label1";
            label1.Size = new Size(224, 18);
            label1.TabIndex = 2;
            label1.Text = "Already have an account? Signup";
            label1.Click += label1_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.Transparent;
            exit.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ButtonHighlight;
            exit.Location = new Point(795, 3);
            exit.Name = "exit";
            exit.Size = new Size(29, 34);
            exit.TabIndex = 3;
            exit.Text = "x";
            exit.Click += exit_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(832, 549);
            Controls.Add(exit);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(signup_confpass);
            Controls.Add(signup_pass);
            Controls.Add(signup_user);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signup";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox signup_user;
        private TextBox signup_pass;
        private TextBox signup_confpass;
        private Button button1;
        private Label label1;
        private Label exit;
    }
}