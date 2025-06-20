namespace DeppDetect_v1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            login_user = new TextBox();
            login_pass = new TextBox();
            login_btn = new Button();
            exit = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // login_user
            // 
            login_user.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_user.ForeColor = SystemColors.ActiveBorder;
            login_user.Location = new Point(208, 226);
            login_user.Name = "login_user";
            login_user.Size = new Size(416, 38);
            login_user.TabIndex = 0;
            login_user.Text = " Enter your Username";
            login_user.Enter += login_user_Enter;
            login_user.Leave += login_user_Leave;
            // 
            // login_pass
            // 
            login_pass.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_pass.ForeColor = SystemColors.ActiveBorder;
            login_pass.Location = new Point(208, 279);
            login_pass.Name = "login_pass";
            login_pass.Size = new Size(416, 38);
            login_pass.TabIndex = 0;
            login_pass.Text = " Enter your Password";
            login_pass.Enter += login_pass_Enter;
            login_pass.Leave += login_pass_Leave;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Navy;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(208, 334);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(416, 51);
            login_btn.TabIndex = 1;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
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
            exit.TabIndex = 2;
            exit.Text = "x";
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(311, 389);
            label1.Name = "label1";
            label1.Size = new Size(210, 18);
            label1.TabIndex = 3;
            label1.Text = "Don't have an account? Signup";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(832, 549);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(login_btn);
            Controls.Add(login_pass);
            Controls.Add(login_user);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login_user;
        private TextBox login_pass;
        private Button login_btn;
        private Label exit;
        private Label label1;
    }
}
