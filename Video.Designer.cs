namespace DeppDetect_v1._1
{
    partial class Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
            verifyBtn = new Button();
            label5 = new Label();
            label2 = new Label();
            exit = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            uploadOriginal = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // verifyBtn
            // 
            verifyBtn.BackColor = Color.Navy;
            verifyBtn.FlatAppearance.BorderSize = 0;
            verifyBtn.FlatStyle = FlatStyle.Flat;
            verifyBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verifyBtn.ForeColor = Color.White;
            verifyBtn.Location = new Point(342, 490);
            verifyBtn.Name = "verifyBtn";
            verifyBtn.Size = new Size(216, 44);
            verifyBtn.TabIndex = 11;
            verifyBtn.Text = "Verify";
            verifyBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(207, 164);
            label5.Name = "label5";
            label5.Size = new Size(486, 18);
            label5.TabIndex = 9;
            label5.Text = "upload the Video to verify if it's genuine or edited (Made with AI)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(314, 124);
            label2.Name = "label2";
            label2.Size = new Size(272, 35);
            label2.TabIndex = 10;
            label2.Text = "Video Detection";
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
            exit.TabIndex = 8;
            exit.Text = "x";
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
            label1.TabIndex = 7;
            label1.Text = "Deep Detect";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(153, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 281);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // uploadOriginal
            // 
            uploadOriginal.BackColor = Color.Navy;
            uploadOriginal.FlatAppearance.BorderSize = 0;
            uploadOriginal.FlatStyle = FlatStyle.Flat;
            uploadOriginal.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadOriginal.ForeColor = Color.White;
            uploadOriginal.Location = new Point(372, 369);
            uploadOriginal.Name = "uploadOriginal";
            uploadOriginal.Size = new Size(159, 44);
            uploadOriginal.TabIndex = 13;
            uploadOriginal.Text = "Upload";
            uploadOriginal.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(417, 224);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(367, 306);
            label3.Name = "label3";
            label3.Size = new Size(166, 18);
            label3.TabIndex = 15;
            label3.Text = "Drop your Video here";
            // 
            // Video
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 580);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(uploadOriginal);
            Controls.Add(verifyBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Video";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Video";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button verifyBtn;
        private Label label5;
        private Label label2;
        private Label exit;
        private Label label1;
        private PictureBox pictureBox1;
        private Button uploadOriginal;
        private PictureBox pictureBox2;
        private Label label3;
    }
}