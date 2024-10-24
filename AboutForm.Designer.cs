namespace Tic_Tac_Toe___Ivan_Suralta
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            returnButton = new Button();
            appLabel = new Label();
            GitHubLink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(220, 168);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 1;
            label1.Text = "Ivan G. Suralta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(220, 216);
            label2.Name = "label2";
            label2.Size = new Size(189, 21);
            label2.TabIndex = 2;
            label2.Text = "BS Computer Engineering";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(294, 252);
            label3.Name = "label3";
            label3.Size = new Size(36, 21);
            label3.TabIndex = 3;
            label3.Text = "4-G";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(226, 282);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 4;
            label4.Text = "Do what you want.";
            // 
            // returnButton
            // 
            returnButton.Location = new Point(12, 12);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(107, 23);
            returnButton.TabIndex = 5;
            returnButton.Text = "Return to Menu";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // appLabel
            // 
            appLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appLabel.AutoSize = true;
            appLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            appLabel.Location = new Point(146, 73);
            appLabel.Name = "appLabel";
            appLabel.Size = new Size(128, 32);
            appLabel.TabIndex = 6;
            appLabel.Text = "About Me";
            appLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // GitHubLink
            // 
            GitHubLink.AutoSize = true;
            GitHubLink.Location = new Point(192, 374);
            GitHubLink.Name = "GitHubLink";
            GitHubLink.Size = new Size(45, 15);
            GitHubLink.TabIndex = 7;
            GitHubLink.TabStop = true;
            GitHubLink.Text = "GitHub";
            GitHubLink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(GitHubLink);
            Controls.Add(appLabel);
            Controls.Add(returnButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button returnButton;
        private Label appLabel;
        private LinkLabel GitHubLink;
    }
}