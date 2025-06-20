namespace DeppDetect_v1._1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            signature = new Button();
            video = new Button();
            audio = new Button();
            exit = new Label();
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
            label1.TabIndex = 0;
            label1.Text = "Deep Detect";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(115, 202);
            label2.Name = "label2";
            label2.Size = new Size(337, 28);
            label2.TabIndex = 0;
            label2.Text = "Welcome to Deep Detect!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(119, 242);
            label3.Name = "label3";
            label3.Size = new Size(376, 32);
            label3.TabIndex = 0;
            label3.Text = "Detect forgery with Confidence and the accuracy using\r\nAI-driven analysis for signatures and video and images";
            // 
            // signature
            // 
            signature.BackColor = Color.Navy;
            signature.FlatAppearance.BorderSize = 0;
            signature.FlatStyle = FlatStyle.Flat;
            signature.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signature.ForeColor = Color.White;
            signature.Location = new Point(130, 311);
            signature.Name = "signature";
            signature.Size = new Size(124, 95);
            signature.TabIndex = 1;
            signature.Text = "Detect\r\nSignature\r\n";
            signature.UseVisualStyleBackColor = false;
            signature.Click += signature_Click;
            // 
            // video
            // 
            video.BackColor = Color.Navy;
            video.FlatAppearance.BorderSize = 0;
            video.FlatStyle = FlatStyle.Flat;
            video.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            video.ForeColor = Color.White;
            video.Location = new Point(264, 311);
            video.Name = "video";
            video.Size = new Size(151, 42);
            video.TabIndex = 1;
            video.Text = "Fake Video";
            video.UseVisualStyleBackColor = false;
            video.Click += video_Click;
            // 
            // audio
            // 
            audio.BackColor = Color.Navy;
            audio.FlatAppearance.BorderSize = 0;
            audio.FlatStyle = FlatStyle.Flat;
            audio.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            audio.ForeColor = Color.White;
            audio.Location = new Point(264, 364);
            audio.Name = "audio";
            audio.Size = new Size(151, 42);
            audio.TabIndex = 1;
            audio.Text = "Fake Audio";
            audio.UseVisualStyleBackColor = false;
            audio.Click += audio_Click;
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
            exit.TabIndex = 0;
            exit.Text = "x";
            exit.Click += exit_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 580);
            Controls.Add(audio);
            Controls.Add(video);
            Controls.Add(signature);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button signature;
        private Button video;
        private Button audio;
        private Label exit;
    }
}