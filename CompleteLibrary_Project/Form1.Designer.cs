namespace CompleteLibrary_Project
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
            welcomeLB = new Label();
            librariansButton = new Button();
            membersButton = new Button();
            languageButton = new Button();
            SuspendLayout();
            // 
            // welcomeLB
            // 
            welcomeLB.AutoSize = true;
            welcomeLB.Location = new Point(260, 120);
            welcomeLB.Margin = new Padding(3, 0, 350, 0);
            welcomeLB.Name = "welcomeLB";
            welcomeLB.Size = new Size(252, 25);
            welcomeLB.TabIndex = 0;
            welcomeLB.Text = "Welcome to Complete Library!";
            // 
            // librariansButton
            // 
            librariansButton.Location = new Point(199, 192);
            librariansButton.Name = "librariansButton";
            librariansButton.Size = new Size(173, 34);
            librariansButton.TabIndex = 1;
            librariansButton.Text = "Librarians";
            librariansButton.UseVisualStyleBackColor = true;
            librariansButton.Click += librariansButton_Click;
            // 
            // membersButton
            // 
            membersButton.Location = new Point(400, 192);
            membersButton.Name = "membersButton";
            membersButton.Size = new Size(180, 34);
            membersButton.TabIndex = 2;
            membersButton.Text = "Members";
            membersButton.UseVisualStyleBackColor = true;
            membersButton.Click += membersButton_Click;
            // 
            // languageButton
            // 
            languageButton.Location = new Point(676, 12);
            languageButton.Name = "languageButton";
            languageButton.Size = new Size(112, 34);
            languageButton.TabIndex = 3;
            languageButton.Text = "Français";
            languageButton.UseVisualStyleBackColor = true;
            languageButton.Click += languageButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(languageButton);
            Controls.Add(membersButton);
            Controls.Add(librariansButton);
            Controls.Add(welcomeLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLB;
        private Button librariansButton;
        private Button membersButton;
        private Button languageButton;
    }
}
