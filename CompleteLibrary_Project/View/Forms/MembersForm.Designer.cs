using System.Windows.Forms;

namespace CompleteLibrary_Project
{
    partial class MembersForm
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
            label1 = new Label();
            titleSearchTB = new TextBox();
            searchBT = new Button();
            resultsRTB = new RichTextBox();
            typeSearchCB = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(555, 25);
            label1.TabIndex = 0;
            label1.Text = "Search for a book, movie, audiobook, or magazine within the library!";
            // 
            // titleSearchTB
            // 
            titleSearchTB.Location = new Point(12, 40);
            titleSearchTB.Name = "titleSearchTB";
            titleSearchTB.Size = new Size(251, 31);
            titleSearchTB.TabIndex = 7;
            // 
            // searchBT
            // 
            searchBT.Location = new Point(457, 40);
            searchBT.Name = "searchBT";
            searchBT.Size = new Size(112, 34);
            searchBT.TabIndex = 2;
            searchBT.Text = "Search";
            searchBT.UseVisualStyleBackColor = true;
            searchBT.Click += searchBT_Click;
            // 
            // resultsRTB
            // 
            resultsRTB.Location = new Point(50, 108);
            resultsRTB.Name = "resultsRTB";
            resultsRTB.Size = new Size(709, 307);
            resultsRTB.TabIndex = 5;
            resultsRTB.Text = "";
            // 
            // typeSearchCB
            // 
            typeSearchCB.FormattingEnabled = true;
            typeSearchCB.Location = new Point(269, 40);
            typeSearchCB.Name = "typeSearchCB";
            typeSearchCB.Size = new Size(182, 33);
            typeSearchCB.TabIndex = 6;
            typeSearchCB.Text = "Type";
            // 
            // MembersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(typeSearchCB);
            Controls.Add(searchBT);
            Controls.Add(titleSearchTB);
            Controls.Add(label1);
            Controls.Add(resultsRTB);
            Name = "MembersForm";
            Text = "MembersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleSearchTB;
        private Button searchBT;
        private RichTextBox resultsRTB;
        private ComboBox typeSearchCB;
    }
}