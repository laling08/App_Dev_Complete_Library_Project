namespace CompleteLibrary_Project
{
    partial class MembersMediaForm
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
            queriedMediaLV = new ListView();
            titleColumn = new ColumnHeader();
            statusColumn = new ColumnHeader();
            languageColumn = new ColumnHeader();
            idColumn = new ColumnHeader();
            selectLabel = new Label();
            userIdLabel = new Label();
            userIdTB = new TextBox();
            idErrorLabel = new Label();
            borrowButton = new Button();
            holdButton = new Button();
            completedLabel = new Label();
            SuspendLayout();
            // 
            // queriedMediaLV
            // 
            queriedMediaLV.Columns.AddRange(new ColumnHeader[] { titleColumn, statusColumn, languageColumn, idColumn });
            queriedMediaLV.Location = new Point(60, 139);
            queriedMediaLV.MultiSelect = false;
            queriedMediaLV.Name = "queriedMediaLV";
            queriedMediaLV.Size = new Size(672, 220);
            queriedMediaLV.TabIndex = 0;
            queriedMediaLV.UseCompatibleStateImageBehavior = false;
            queriedMediaLV.View = View.Details;
            queriedMediaLV.SelectedIndexChanged += queriedMediaLV_SelectedIndexChanged;
            // 
            // titleColumn
            // 
            titleColumn.Text = "Title";
            titleColumn.Width = 336;
            // 
            // statusColumn
            // 
            statusColumn.Text = "Status";
            statusColumn.Width = 112;
            // 
            // languageColumn
            // 
            languageColumn.Text = "Language";
            languageColumn.Width = 112;
            // 
            // idColumn
            // 
            idColumn.Text = "ID";
            idColumn.Width = 112;
            // 
            // selectLabel
            // 
            selectLabel.AutoSize = true;
            selectLabel.Location = new Point(60, 94);
            selectLabel.Name = "selectLabel";
            selectLabel.Size = new Size(236, 25);
            selectLabel.TabIndex = 1;
            selectLabel.Text = "Select one of the following...";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new Point(60, 45);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new Size(149, 25);
            userIdLabel.TabIndex = 2;
            userIdLabel.Text = "Enter ID Number:";
            // 
            // userIdTB
            // 
            userIdTB.Location = new Point(350, 42);
            userIdTB.Name = "userIdTB";
            userIdTB.Size = new Size(150, 31);
            userIdTB.TabIndex = 3;
            userIdTB.TextChanged += userIdTB_TextChanged;
            // 
            // idErrorLabel
            // 
            idErrorLabel.AutoSize = true;
            idErrorLabel.Location = new Point(506, 48);
            idErrorLabel.Name = "idErrorLabel";
            idErrorLabel.Size = new Size(163, 25);
            idErrorLabel.TabIndex = 4;
            idErrorLabel.Text = "This is an invalid ID";
            idErrorLabel.Visible = false;
            // 
            // borrowButton
            // 
            borrowButton.Enabled = false;
            borrowButton.Location = new Point(620, 404);
            borrowButton.Name = "borrowButton";
            borrowButton.Size = new Size(112, 34);
            borrowButton.TabIndex = 5;
            borrowButton.Text = "Borrow";
            borrowButton.UseVisualStyleBackColor = true;
            borrowButton.Click += borrowButton_Click;
            // 
            // holdButton
            // 
            holdButton.Enabled = false;
            holdButton.Location = new Point(407, 404);
            holdButton.Name = "holdButton";
            holdButton.Size = new Size(178, 34);
            holdButton.TabIndex = 6;
            holdButton.Text = "Place Hold";
            holdButton.UseVisualStyleBackColor = true;
            holdButton.Click += holdButton_Click;
            // 
            // completedLabel
            // 
            completedLabel.AutoSize = true;
            completedLabel.Location = new Point(60, 362);
            completedLabel.Name = "completedLabel";
            completedLabel.Size = new Size(59, 25);
            completedLabel.TabIndex = 7;
            completedLabel.Text = "nameLabel";
            completedLabel.Visible = false;
            // 
            // MembersMediaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(completedLabel);
            Controls.Add(holdButton);
            Controls.Add(borrowButton);
            Controls.Add(idErrorLabel);
            Controls.Add(userIdTB);
            Controls.Add(userIdLabel);
            Controls.Add(selectLabel);
            Controls.Add(queriedMediaLV);
            Name = "MembersMediaForm";
            Text = "MembersMediaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView queriedMediaLV;
        private Label selectLabel;
        private Label userIdLabel;
        private TextBox userIdTB;
        private Label idErrorLabel;
        private Button borrowButton;
        private Button holdButton;
        private ColumnHeader titleColumn;
        private ColumnHeader statusColumn;
        private ColumnHeader languageColumn;
        private ColumnHeader idColumn;
        private Label completedLabel;
    }
}