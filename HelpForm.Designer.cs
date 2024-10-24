namespace Tic_Tac_Toe___Ivan_Suralta
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            returnButton = new Button();
            appLabel = new Label();
            labelHelp = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.Location = new Point(12, 12);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(107, 23);
            returnButton.TabIndex = 6;
            returnButton.Text = "Return to Menu";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // appLabel
            // 
            appLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appLabel.AutoSize = true;
            appLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            appLabel.Location = new Point(160, 36);
            appLabel.Name = "appLabel";
            appLabel.Size = new Size(102, 32);
            appLabel.TabIndex = 7;
            appLabel.Text = "Tutorial";
            appLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelHelp
            // 
            labelHelp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelHelp.Location = new Point(12, 234);
            labelHelp.Name = "labelHelp";
            labelHelp.Size = new Size(417, 53);
            labelHelp.TabIndex = 8;
            labelHelp.Text = "Step 1: Start the Game\r\n- The game is played on a 3x3 grid.\r\n- Two players take turns. one using X and the other using O.";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 296);
            label1.Name = "label1";
            label1.Size = new Size(417, 80);
            label1.TabIndex = 9;
            label1.Text = "Step 2: Take Turns\r\n- Players take turns placing their symbol (X or O) in one of the empty squares on the grid.\r\n- The goal is to align three of your symbols in a row, column, or diagonal.";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 376);
            label2.Name = "label2";
            label2.Size = new Size(417, 50);
            label2.TabIndex = 10;
            label2.Text = "Step 3: Winning the Game\r\n- The first player to get three of their symbols in a row (vertically, horizontally, or diagonally) wins the game.";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 441);
            label3.Name = "label3";
            label3.Size = new Size(417, 50);
            label3.TabIndex = 11;
            label3.Text = "Step 4: What if It's a Draw?\r\n- If all squares are filled and no one has three in a row, the game ends in a draw.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(147, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 500);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelHelp);
            Controls.Add(appLabel);
            Controls.Add(returnButton);
            Name = "HelpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnButton;
        private Label appLabel;
        private Label labelHelp;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}