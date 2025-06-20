namespace DeppDetect_v1._1
{
    partial class Signature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signature));
            label1 = new Label();
            exit = new Label();
            label3 = new Label();
            label2 = new Label();
            uploadOriginal = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            uploadTest = new Button();
            pictureBox2 = new PictureBox();
            verifyBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(134, 24);
            label1.TabIndex = 1;
            label1.Text = "Deep Detect";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.Transparent;
            exit.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ButtonFace;
            exit.Location = new Point(866, 4);
            exit.Name = "exit";
            exit.Size = new Size(29, 34);
            exit.TabIndex = 2;
            exit.Text = "x";
            exit.Click += exit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(190, 341);
            label3.Name = "label3";
            label3.Size = new Size(171, 18);
            label3.TabIndex = 3;
            label3.Text = "Drop your Image here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(284, 121);
            label2.Name = "label2";
            label2.Size = new Size(332, 34);
            label2.TabIndex = 4;
            label2.Text = "Signature Detection";
            // 
            // uploadOriginal
            // 
            uploadOriginal.BackColor = Color.Navy;
            uploadOriginal.FlatAppearance.BorderSize = 0;
            uploadOriginal.FlatStyle = FlatStyle.Flat;
            uploadOriginal.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadOriginal.ForeColor = Color.White;
            uploadOriginal.Location = new Point(173, 395);
            uploadOriginal.Name = "uploadOriginal";
            uploadOriginal.Size = new Size(216, 44);
            uploadOriginal.TabIndex = 6;
            uploadOriginal.Text = "Upload";
            uploadOriginal.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(231, 260);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(173, 223);
            label4.Name = "label4";
            label4.Size = new Size(216, 25);
            label4.TabIndex = 3;
            label4.Text = "Original Signature";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(232, 170);
            label5.Name = "label5";
            label5.Size = new Size(436, 18);
            label5.TabIndex = 3;
            label5.Text = "upload a signature image to verify if it's genuine or forged";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft YaHei", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(220, 360);
            label6.Name = "label6";
            label6.Size = new Size(113, 19);
            label6.TabIndex = 3;
            label6.Text = "Support jpg, png";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(523, 341);
            label7.Name = "label7";
            label7.Size = new Size(171, 18);
            label7.TabIndex = 3;
            label7.Text = "Drop your Image here";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft YaHei", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.AppWorkspace;
            label8.Location = new Point(553, 360);
            label8.Name = "label8";
            label8.Size = new Size(113, 19);
            label8.TabIndex = 3;
            label8.Text = "Support jpg, png";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(506, 223);
            label9.Name = "label9";
            label9.Size = new Size(205, 25);
            label9.TabIndex = 3;
            label9.Text = "Signature to Test";
            // 
            // uploadTest
            // 
            uploadTest.BackColor = Color.Navy;
            uploadTest.FlatAppearance.BorderSize = 0;
            uploadTest.FlatStyle = FlatStyle.Flat;
            uploadTest.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadTest.ForeColor = Color.White;
            uploadTest.Location = new Point(506, 395);
            uploadTest.Name = "uploadTest";
            uploadTest.Size = new Size(216, 44);
            uploadTest.TabIndex = 6;
            uploadTest.Text = "Upload";
            uploadTest.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(564, 260);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // verifyBtn
            // 
            verifyBtn.BackColor = Color.Navy;
            verifyBtn.FlatAppearance.BorderSize = 0;
            verifyBtn.FlatStyle = FlatStyle.Flat;
            verifyBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verifyBtn.ForeColor = Color.White;
            verifyBtn.Location = new Point(342, 469);
            verifyBtn.Name = "verifyBtn";
            verifyBtn.Size = new Size(216, 44);
            verifyBtn.TabIndex = 6;
            verifyBtn.Text = "Verify";
            verifyBtn.UseVisualStyleBackColor = false;
            // 
            // Signature
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 580);
            Controls.Add(pictureBox2);
            Controls.Add(uploadTest);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(verifyBtn);
            Controls.Add(uploadOriginal);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signature";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signature";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label exit;
        private Label label3;
        private Label label2;
        private Button uploadOriginal;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button uploadTest;
        private PictureBox pictureBox2;
        private Button verifyBtn;
    }
}