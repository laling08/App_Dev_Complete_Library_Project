namespace CompleteLibrary_Project
{
    partial class LibrariansForm
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
            addNewUserGB = new GroupBox();
            librarianRB = new RadioButton();
            memberRB = new RadioButton();
            addUserButton = new Button();
            returnItemButton = new Button();
            addMediaButton = new Button();
            fnameLabel = new Label();
            lnameLabel = new Label();
            dobLabel = new Label();
            fnameTB = new TextBox();
            lnameTB = new TextBox();
            yearTB = new TextBox();
            userSubmitButton = new Button();
            dayTB = new TextBox();
            monthTB = new TextBox();
            returnItemLabel = new Label();
            userIdLabel = new Label();
            mediaIdLabel = new Label();
            userIdTB = new TextBox();
            mediaIdTB = new TextBox();
            returnSubmitButton = new Button();
            userErrorLabel = new Label();
            returnErrorLabel = new Label();
            manageMemberButton = new Button();
            addNewUserGB.SuspendLayout();
            SuspendLayout();
            // 
            // addNewUserGB
            // 
            addNewUserGB.Controls.Add(librarianRB);
            addNewUserGB.Controls.Add(memberRB);
            addNewUserGB.Location = new Point(15, 54);
            addNewUserGB.Margin = new Padding(2);
            addNewUserGB.Name = "addNewUserGB";
            addNewUserGB.Padding = new Padding(2);
            addNewUserGB.Size = new Size(239, 68);
            addNewUserGB.TabIndex = 2;
            addNewUserGB.TabStop = false;
            addNewUserGB.Text = "Add New User";
            addNewUserGB.Visible = false;
            // 
            // librarianRB
            // 
            librarianRB.AutoSize = true;
            librarianRB.Location = new Point(4, 40);
            librarianRB.Margin = new Padding(2);
            librarianRB.Name = "librarianRB";
            librarianRB.Size = new Size(71, 19);
            librarianRB.TabIndex = 1;
            librarianRB.TabStop = true;
            librarianRB.Text = "Librarian";
            librarianRB.UseVisualStyleBackColor = true;
            librarianRB.Visible = false;
            librarianRB.CheckedChanged += librarianRB_CheckedChanged;
            // 
            // memberRB
            // 
            memberRB.AutoSize = true;
            memberRB.Location = new Point(4, 19);
            memberRB.Margin = new Padding(2);
            memberRB.Name = "memberRB";
            memberRB.Size = new Size(70, 19);
            memberRB.TabIndex = 0;
            memberRB.TabStop = true;
            memberRB.Text = "Member";
            memberRB.UseVisualStyleBackColor = true;
            memberRB.Visible = false;
            memberRB.CheckedChanged += memberRB_CheckedChanged;
            // 
            // addUserButton
            // 
            addUserButton.Location = new Point(19, 19);
            addUserButton.Margin = new Padding(2);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(112, 28);
            addUserButton.TabIndex = 4;
            addUserButton.Text = "Add New User";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // returnItemButton
            // 
            returnItemButton.Location = new Point(293, 19);
            returnItemButton.Margin = new Padding(2);
            returnItemButton.Name = "returnItemButton";
            returnItemButton.Size = new Size(126, 28);
            returnItemButton.TabIndex = 6;
            returnItemButton.Text = "Return Item";
            returnItemButton.UseVisualStyleBackColor = true;
            returnItemButton.Click += returnItemButton_Click;
            // 
            // addMediaButton
            // 
            addMediaButton.Location = new Point(147, 19);
            addMediaButton.Margin = new Padding(2);
            addMediaButton.Name = "addMediaButton";
            addMediaButton.Size = new Size(125, 28);
            addMediaButton.TabIndex = 7;
            addMediaButton.Text = "Add New Media";
            addMediaButton.UseVisualStyleBackColor = true;
            addMediaButton.Click += addMediaButton_Click;
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new Point(15, 143);
            fnameLabel.Margin = new Padding(2, 0, 2, 0);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(86, 15);
            fnameLabel.TabIndex = 8;
            fnameLabel.Text = "Given name(s):";
            fnameLabel.Visible = false;
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new Point(15, 169);
            lnameLabel.Margin = new Padding(2, 0, 2, 0);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(91, 15);
            lnameLabel.TabIndex = 9;
            lnameLabel.Text = "Family name(s):";
            lnameLabel.Visible = false;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(15, 195);
            dobLabel.Margin = new Padding(2, 0, 2, 0);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(115, 15);
            dobLabel.TabIndex = 10;
            dobLabel.Text = "DOB (yyyy/mm/dd):";
            dobLabel.Visible = false;
            // 
            // fnameTB
            // 
            fnameTB.Location = new Point(134, 143);
            fnameTB.Margin = new Padding(2);
            fnameTB.Name = "fnameTB";
            fnameTB.PlaceholderText = "John";
            fnameTB.Size = new Size(121, 23);
            fnameTB.TabIndex = 11;
            fnameTB.Visible = false;
            fnameTB.TextChanged += TextBox_TextChanged;
            // 
            // lnameTB
            // 
            lnameTB.Location = new Point(134, 167);
            lnameTB.Margin = new Padding(2);
            lnameTB.Name = "lnameTB";
            lnameTB.PlaceholderText = "Smith";
            lnameTB.Size = new Size(121, 23);
            lnameTB.TabIndex = 12;
            lnameTB.Visible = false;
            lnameTB.TextChanged += TextBox_TextChanged;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(134, 197);
            yearTB.Margin = new Padding(2);
            yearTB.Name = "yearTB";
            yearTB.PlaceholderText = "1990";
            yearTB.Size = new Size(47, 23);
            yearTB.TabIndex = 13;
            yearTB.Visible = false;
            yearTB.TextChanged += TextBox_TextChanged;
            // 
            // userSubmitButton
            // 
            userSubmitButton.Enabled = false;
            userSubmitButton.Location = new Point(171, 226);
            userSubmitButton.Margin = new Padding(2);
            userSubmitButton.Name = "userSubmitButton";
            userSubmitButton.Size = new Size(83, 20);
            userSubmitButton.TabIndex = 14;
            userSubmitButton.Text = "Submit";
            userSubmitButton.UseVisualStyleBackColor = true;
            userSubmitButton.Visible = false;
            userSubmitButton.Click += userSubmitButton_Click;
            // 
            // dayTB
            // 
            dayTB.Location = new Point(221, 197);
            dayTB.Margin = new Padding(2);
            dayTB.Name = "dayTB";
            dayTB.PlaceholderText = "31";
            dayTB.Size = new Size(34, 23);
            dayTB.TabIndex = 21;
            dayTB.Visible = false;
            dayTB.TextChanged += TextBox_TextChanged;
            // 
            // monthTB
            // 
            monthTB.Location = new Point(185, 197);
            monthTB.Margin = new Padding(2);
            monthTB.Name = "monthTB";
            monthTB.PlaceholderText = "01";
            monthTB.Size = new Size(33, 23);
            monthTB.TabIndex = 22;
            monthTB.Visible = false;
            monthTB.TextChanged += TextBox_TextChanged;
            // 
            // returnItemLabel
            // 
            returnItemLabel.AutoSize = true;
            returnItemLabel.Location = new Point(325, 54);
            returnItemLabel.Margin = new Padding(2, 0, 2, 0);
            returnItemLabel.Name = "returnItemLabel";
            returnItemLabel.Size = new Size(69, 15);
            returnItemLabel.TabIndex = 23;
            returnItemLabel.Text = "Return Item";
            returnItemLabel.Visible = false;
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new Point(325, 88);
            userIdLabel.Margin = new Padding(2, 0, 2, 0);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new Size(47, 15);
            userIdLabel.TabIndex = 24;
            userIdLabel.Text = "User ID:";
            userIdLabel.Visible = false;
            // 
            // mediaIdLabel
            // 
            mediaIdLabel.AutoSize = true;
            mediaIdLabel.Location = new Point(325, 115);
            mediaIdLabel.Margin = new Padding(2, 0, 2, 0);
            mediaIdLabel.Name = "mediaIdLabel";
            mediaIdLabel.Size = new Size(57, 15);
            mediaIdLabel.TabIndex = 25;
            mediaIdLabel.Text = "Media ID:";
            mediaIdLabel.Visible = false;
            // 
            // userIdTB
            // 
            userIdTB.Location = new Point(420, 86);
            userIdTB.Margin = new Padding(2);
            userIdTB.Name = "userIdTB";
            userIdTB.PlaceholderText = "10";
            userIdTB.Size = new Size(106, 23);
            userIdTB.TabIndex = 27;
            userIdTB.Visible = false;
            userIdTB.TextChanged += TB_TextChanged;
            // 
            // mediaIdTB
            // 
            mediaIdTB.Location = new Point(420, 113);
            mediaIdTB.Margin = new Padding(2);
            mediaIdTB.Name = "mediaIdTB";
            mediaIdTB.PlaceholderText = "15";
            mediaIdTB.Size = new Size(106, 23);
            mediaIdTB.TabIndex = 28;
            mediaIdTB.Visible = false;
            mediaIdTB.TextChanged += TB_TextChanged;
            // 
            // returnSubmitButton
            // 
            returnSubmitButton.Enabled = false;
            returnSubmitButton.Location = new Point(447, 143);
            returnSubmitButton.Margin = new Padding(2);
            returnSubmitButton.Name = "returnSubmitButton";
            returnSubmitButton.Size = new Size(78, 20);
            returnSubmitButton.TabIndex = 29;
            returnSubmitButton.Text = "Submit";
            returnSubmitButton.UseVisualStyleBackColor = true;
            returnSubmitButton.Visible = false;
            returnSubmitButton.Click += returnSubmitButton_Click;
            // 
            // userErrorLabel
            // 
            userErrorLabel.AutoSize = true;
            userErrorLabel.Location = new Point(15, 229);
            userErrorLabel.Margin = new Padding(2, 0, 2, 0);
            userErrorLabel.Name = "userErrorLabel";
            userErrorLabel.Size = new Size(38, 15);
            userErrorLabel.TabIndex = 30;
            userErrorLabel.Text = "nameLabel";
            userErrorLabel.Visible = false;
            // 
            // returnErrorLabel
            // 
            returnErrorLabel.AutoSize = true;
            returnErrorLabel.Location = new Point(325, 167);
            returnErrorLabel.Margin = new Padding(2, 0, 2, 0);
            returnErrorLabel.Name = "returnErrorLabel";
            returnErrorLabel.Size = new Size(38, 15);
            returnErrorLabel.TabIndex = 31;
            returnErrorLabel.Text = "idLabel";
            returnErrorLabel.Visible = false;
            // 
            // manageMemberButton
            // 
            manageMemberButton.Location = new Point(431, 19);
            manageMemberButton.Name = "manageMemberButton";
            manageMemberButton.Size = new Size(117, 28);
            manageMemberButton.TabIndex = 32;
            manageMemberButton.Text = "Manage a Member";
            manageMemberButton.UseVisualStyleBackColor = true;
            manageMemberButton.Click += manageMemberButton_Click;
            // 
            // LibrariansForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(manageMemberButton);
            Controls.Add(returnErrorLabel);
            Controls.Add(userErrorLabel);
            Controls.Add(returnSubmitButton);
            Controls.Add(mediaIdTB);
            Controls.Add(userIdTB);
            Controls.Add(mediaIdLabel);
            Controls.Add(userIdLabel);
            Controls.Add(returnItemLabel);
            Controls.Add(monthTB);
            Controls.Add(dayTB);
            Controls.Add(userSubmitButton);
            Controls.Add(yearTB);
            Controls.Add(lnameTB);
            Controls.Add(fnameTB);
            Controls.Add(dobLabel);
            Controls.Add(lnameLabel);
            Controls.Add(fnameLabel);
            Controls.Add(addMediaButton);
            Controls.Add(returnItemButton);
            Controls.Add(addUserButton);
            Controls.Add(addNewUserGB);
            Margin = new Padding(2);
            Name = "LibrariansForm";
            Text = "LibrariansForm";
            addNewUserGB.ResumeLayout(false);
            addNewUserGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox addNewUserGB;
        private RadioButton librarianRB;
        private RadioButton memberRB;
        private Button addUserButton;
        private Button returnItemButton;
        private Button addMediaButton;
        private Label fnameLabel;
        private Label lnameLabel;
        private Label dobLabel;
        private TextBox fnameTB;
        private TextBox lnameTB;
        private TextBox yearTB;
        private Button userSubmitButton;
        private TextBox dayTB;
        private TextBox monthTB;
        private Label returnItemLabel;
        private Label userIdLabel;
        private Label mediaIdLabel;
        private TextBox userIdTB;
        private TextBox mediaIdTB;
        private Button returnSubmitButton;
        private Label userErrorLabel;
        private Label returnErrorLabel;
        private Button manageMemberButton;
    }
}