namespace CompleteLibrary_Project.View.Forms
{
    partial class ManageMemberForm
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
            nameLabel = new Label();
            idLabel = new Label();
            nameTB = new TextBox();
            idTB = new TextBox();
            groupBox1 = new GroupBox();
            lateFeeRadioButton = new RadioButton();
            historyRadioButton = new RadioButton();
            submitButton = new Button();
            memberHistoryRTB = new RichTextBox();
            memberHistoryLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(16, 44);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(45, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name: ";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(38, 75);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(23, 15);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id: ";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(67, 41);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(152, 23);
            nameTB.TabIndex = 2;
            // 
            // idTB
            // 
            idTB.Location = new Point(67, 72);
            idTB.Name = "idTB";
            idTB.Size = new Size(152, 23);
            idTB.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lateFeeRadioButton);
            groupBox1.Controls.Add(historyRadioButton);
            groupBox1.Location = new Point(61, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(158, 102);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // lateFeeRadioButton
            // 
            lateFeeRadioButton.AutoSize = true;
            lateFeeRadioButton.Location = new Point(15, 57);
            lateFeeRadioButton.Name = "lateFeeRadioButton";
            lateFeeRadioButton.Size = new Size(94, 19);
            lateFeeRadioButton.TabIndex = 1;
            lateFeeRadioButton.TabStop = true;
            lateFeeRadioButton.Text = "Give Late Fee";
            lateFeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // historyRadioButton
            // 
            historyRadioButton.AutoSize = true;
            historyRadioButton.Location = new Point(15, 32);
            historyRadioButton.Name = "historyRadioButton";
            historyRadioButton.Size = new Size(139, 19);
            historyRadioButton.TabIndex = 0;
            historyRadioButton.TabStop = true;
            historyRadioButton.Text = "View Member History";
            historyRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(105, 224);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 5;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // memberHistoryRTB
            // 
            memberHistoryRTB.Location = new Point(253, 44);
            memberHistoryRTB.Name = "memberHistoryTB";
            memberHistoryRTB.Size = new Size(247, 203);
            memberHistoryRTB.TabIndex = 6;
            memberHistoryRTB.Text = "";
            // 
            // memberHistoryLabel
            // 
            memberHistoryLabel.AutoSize = true;
            memberHistoryLabel.Location = new Point(331, 26);
            memberHistoryLabel.Name = "memberHistoryLabel";
            memberHistoryLabel.Size = new Size(93, 15);
            memberHistoryLabel.TabIndex = 7;
            memberHistoryLabel.Text = "Member History";
            // 
            // ManageMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 292);
            Controls.Add(memberHistoryLabel);
            Controls.Add(memberHistoryRTB);
            Controls.Add(submitButton);
            Controls.Add(groupBox1);
            Controls.Add(idTB);
            Controls.Add(nameTB);
            Controls.Add(idLabel);
            Controls.Add(nameLabel);
            Name = "ManageMemberForm";
            Text = "ManageMemberForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label idLabel;
        private TextBox nameTB;
        private TextBox idTB;
        private GroupBox groupBox1;
        private RadioButton lateFeeRadioButton;
        private RadioButton historyRadioButton;
        private Button submitButton;
        private RichTextBox memberHistoryRTB;
        private Label memberHistoryLabel;
    }
}