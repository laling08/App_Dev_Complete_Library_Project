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
            addNewUserGB.SuspendLayout();
            SuspendLayout();
            // 
            // addNewUserGB
            // 
            addNewUserGB.Controls.Add(librarianRB);
            addNewUserGB.Controls.Add(memberRB);
            addNewUserGB.Location = new Point(21, 90);
            addNewUserGB.Name = "addNewUserGB";
            addNewUserGB.Size = new Size(342, 114);
            addNewUserGB.TabIndex = 2;
            addNewUserGB.TabStop = false;
            addNewUserGB.Text = "Add New User";
            addNewUserGB.Visible = false;
            // 
            // librarianRB
            // 
            librarianRB.AutoSize = true;
            librarianRB.Location = new Point(6, 67);
            librarianRB.Name = "librarianRB";
            librarianRB.Size = new Size(104, 29);
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
            memberRB.Location = new Point(6, 32);
            memberRB.Name = "memberRB";
            memberRB.Size = new Size(104, 29);
            memberRB.TabIndex = 0;
            memberRB.TabStop = true;
            memberRB.Text = "Member";
            memberRB.UseVisualStyleBackColor = true;
            memberRB.Visible = false;
            memberRB.CheckedChanged += memberRB_CheckedChanged;
            // 
            // addUserButton
            // 
            addUserButton.Location = new Point(85, 31);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(160, 34);
            addUserButton.TabIndex = 4;
            addUserButton.Text = "Add New User";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // returnItemButton
            // 
            returnItemButton.Location = new Point(554, 31);
            returnItemButton.Name = "returnItemButton";
            returnItemButton.Size = new Size(180, 34);
            returnItemButton.TabIndex = 6;
            returnItemButton.Text = "Return Item";
            returnItemButton.UseVisualStyleBackColor = true;
            returnItemButton.Click += returnItemButton_Click;
            // 
            // addMediaButton
            // 
            addMediaButton.Location = new Point(316, 31);
            addMediaButton.Name = "addMediaButton";
            addMediaButton.Size = new Size(179, 34);
            addMediaButton.TabIndex = 7;
            addMediaButton.Text = "Add New Media";
            addMediaButton.UseVisualStyleBackColor = true;
            addMediaButton.Click += addMediaButton_Click;
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new Point(21, 238);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(127, 25);
            fnameLabel.TabIndex = 8;
            fnameLabel.Text = "Given name(s):";
            fnameLabel.Visible = false;
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new Point(21, 282);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(133, 25);
            lnameLabel.TabIndex = 9;
            lnameLabel.Text = "Family name(s):";
            lnameLabel.Visible = false;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(21, 325);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(172, 25);
            dobLabel.TabIndex = 10;
            dobLabel.Text = "DOB (yyyy/mm/dd):";
            dobLabel.Visible = false;
            // 
            // fnameTB
            // 
            fnameTB.Location = new Point(192, 238);
            fnameTB.Name = "fnameTB";
            fnameTB.PlaceholderText = "John";
            fnameTB.Size = new Size(171, 31);
            fnameTB.TabIndex = 11;
            fnameTB.Visible = false;
            fnameTB.TextChanged += TextBox_TextChanged;
            // 
            // lnameTB
            // 
            lnameTB.Location = new Point(192, 279);
            lnameTB.Name = "lnameTB";
            lnameTB.PlaceholderText = "Smith";
            lnameTB.Size = new Size(171, 31);
            lnameTB.TabIndex = 12;
            lnameTB.Visible = false;
            lnameTB.TextChanged += TextBox_TextChanged;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(192, 328);
            yearTB.Name = "yearTB";
            yearTB.PlaceholderText = "1990";
            yearTB.Size = new Size(66, 31);
            yearTB.TabIndex = 13;
            yearTB.Visible = false;
            yearTB.TextChanged += TextBox_TextChanged;
            // 
            // userSubmitButton
            // 
            userSubmitButton.Enabled = false;
            userSubmitButton.Location = new Point(244, 376);
            userSubmitButton.Name = "userSubmitButton";
            userSubmitButton.Size = new Size(119, 34);
            userSubmitButton.TabIndex = 14;
            userSubmitButton.Text = "Submit";
            userSubmitButton.UseVisualStyleBackColor = true;
            userSubmitButton.Visible = false;
            userSubmitButton.Click += userSubmitButton_Click;
            // 
            // dayTB
            // 
            dayTB.Location = new Point(316, 328);
            dayTB.Name = "dayTB";
            dayTB.PlaceholderText = "31";
            dayTB.Size = new Size(47, 31);
            dayTB.TabIndex = 21;
            dayTB.Visible = false;
            dayTB.TextChanged += TextBox_TextChanged;
            // 
            // monthTB
            // 
            monthTB.Location = new Point(264, 328);
            monthTB.Name = "monthTB";
            monthTB.PlaceholderText = "01";
            monthTB.Size = new Size(46, 31);
            monthTB.TabIndex = 22;
            monthTB.Visible = false;
            monthTB.TextChanged += TextBox_TextChanged;
            // 
            // returnItemLabel
            // 
            returnItemLabel.AutoSize = true;
            returnItemLabel.Location = new Point(464, 90);
            returnItemLabel.Name = "returnItemLabel";
            returnItemLabel.Size = new Size(104, 25);
            returnItemLabel.TabIndex = 23;
            returnItemLabel.Text = "Return Item";
            returnItemLabel.Visible = false;
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new Point(464, 147);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new Size(74, 25);
            userIdLabel.TabIndex = 24;
            userIdLabel.Text = "User ID:";
            userIdLabel.Visible = false;
            // 
            // mediaIdLabel
            // 
            mediaIdLabel.AutoSize = true;
            mediaIdLabel.Location = new Point(464, 192);
            mediaIdLabel.Name = "mediaIdLabel";
            mediaIdLabel.Size = new Size(88, 25);
            mediaIdLabel.TabIndex = 25;
            mediaIdLabel.Text = "Media ID:";
            mediaIdLabel.Visible = false;
            // 
            // userIdTB
            // 
            userIdTB.Location = new Point(600, 144);
            userIdTB.Name = "userIdTB";
            userIdTB.PlaceholderText = "10";
            userIdTB.Size = new Size(150, 31);
            userIdTB.TabIndex = 27;
            userIdTB.Visible = false;
            userIdTB.TextChanged += TB_TextChanged;
            // 
            // mediaIdTB
            // 
            mediaIdTB.Location = new Point(600, 189);
            mediaIdTB.Name = "mediaIdTB";
            mediaIdTB.PlaceholderText = "15";
            mediaIdTB.Size = new Size(150, 31);
            mediaIdTB.TabIndex = 28;
            mediaIdTB.Visible = false;
            mediaIdTB.TextChanged += TB_TextChanged;
            // 
            // returnSubmitButton
            // 
            returnSubmitButton.Enabled = false;
            returnSubmitButton.Location = new Point(638, 238);
            returnSubmitButton.Name = "returnSubmitButton";
            returnSubmitButton.Size = new Size(112, 34);
            returnSubmitButton.TabIndex = 29;
            returnSubmitButton.Text = "Submit";
            returnSubmitButton.UseVisualStyleBackColor = true;
            returnSubmitButton.Visible = false;
            returnSubmitButton.Click += returnSubmitButton_Click;
            // 
            // userErrorLabel
            // 
            userErrorLabel.AutoSize = true;
            userErrorLabel.Location = new Point(21, 381);
            userErrorLabel.Name = "userErrorLabel";
            userErrorLabel.Size = new Size(59, 25);
            userErrorLabel.TabIndex = 30;
            userErrorLabel.Text = "label1";
            userErrorLabel.Visible = false;
            // 
            // returnErrorLabel
            // 
            returnErrorLabel.AutoSize = true;
            returnErrorLabel.Location = new Point(464, 279);
            returnErrorLabel.Name = "returnErrorLabel";
            returnErrorLabel.Size = new Size(59, 25);
            returnErrorLabel.TabIndex = 31;
            returnErrorLabel.Text = "label2";
            returnErrorLabel.Visible = false;
            // 
            // LibrariansForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}