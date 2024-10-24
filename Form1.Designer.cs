namespace Tic_Tac_Toe___Ivan_Suralta
{
    partial class HomeForm
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
            appLabel = new Label();
            startButton = new Button();
            HelpButton = new Button();
            AboutButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // appLabel
            // 
            appLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appLabel.AutoSize = true;
            appLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            appLabel.Location = new Point(145, 44);
            appLabel.Name = "appLabel";
            appLabel.Size = new Size(138, 32);
            appLabel.TabIndex = 0;
            appLabel.Text = "Tic Tac Toe";
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(119, 113);
            startButton.Name = "startButton";
            startButton.Size = new Size(191, 46);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // HelpButton
            // 
            HelpButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            HelpButton.Location = new Point(119, 183);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(191, 46);
            HelpButton.TabIndex = 3;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // AboutButton
            // 
            AboutButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AboutButton.Location = new Point(119, 250);
            AboutButton.Name = "AboutButton";
            AboutButton.Size = new Size(191, 46);
            AboutButton.TabIndex = 4;
            AboutButton.Text = "About";
            AboutButton.UseVisualStyleBackColor = true;
            AboutButton.Click += AboutButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.Location = new Point(119, 317);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(191, 46);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(ExitButton);
            Controls.Add(AboutButton);
            Controls.Add(HelpButton);
            Controls.Add(startButton);
            Controls.Add(appLabel);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe by Ivan Suralta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appLabel;
        private Button startButton;
        private Button HelpButton;
        private Button AboutButton;
        private Button ExitButton;
    }
}