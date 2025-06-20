namespace DeppDetect_v1._1
{
    partial class Audio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Audio));
            label3 = new Label();
            pictureBox2 = new PictureBox();
            uploadOriginal = new Button();
            verifyBtn = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label2 = new Label();
            exit = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(368, 305);
            label3.Name = "label3";
            label3.Size = new Size(166, 18);
            label3.TabIndex = 24;
            label3.Text = "Drop your Audio here";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(417, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // uploadOriginal
            // 
            uploadOriginal.BackColor = Color.Navy;
            uploadOriginal.FlatAppearance.BorderSize = 0;
            uploadOriginal.FlatStyle = FlatStyle.Flat;
            uploadOriginal.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadOriginal.ForeColor = Color.White;
            uploadOriginal.Location = new Point(372, 368);
            uploadOriginal.Name = "uploadOriginal";
            uploadOriginal.Size = new Size(159, 44);
            uploadOriginal.TabIndex = 22;
            uploadOriginal.Text = "Upload";
            uploadOriginal.UseVisualStyleBackColor = false;
            // 
            // verifyBtn
            // 
            verifyBtn.BackColor = Color.Navy;
            verifyBtn.FlatAppearance.BorderSize = 0;
            verifyBtn.FlatStyle = FlatStyle.Flat;
            verifyBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verifyBtn.ForeColor = Color.White;
            verifyBtn.Location = new Point(342, 489);
            verifyBtn.Name = "verifyBtn";
            verifyBtn.Size = new Size(216, 44);
            verifyBtn.TabIndex = 20;
            verifyBtn.Text = "Verify";
            verifyBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(153, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 281);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(207, 163);
            label5.Name = "label5";
            label5.Size = new Size(486, 18);
            label5.TabIndex = 18;
            label5.Text = "upload the Audio to verify if it's genuine or edited (Made with AI)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(314, 123);
            label2.Name = "label2";
            label2.Size = new Size(275, 35);
            label2.TabIndex = 19;
            label2.Text = "Audio Detection";
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
            exit.TabIndex = 17;
            exit.Text = "x";
            exit.Click += exit_Click;
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
            label1.TabIndex = 16;
            label1.Text = "Deep Detect";
            // 
            // Audio
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
            Name = "Audio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audio";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox2;
        private Button uploadOriginal;
        private Button verifyBtn;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label2;
        private Label exit;
        private Label label1;
    }
}