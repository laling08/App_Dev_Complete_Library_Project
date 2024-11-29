namespace CompleteLibrary_Project
{
    partial class LibrarianAddMediaForm
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
            mediaTypeGB = new GroupBox();
            magazineRB = new RadioButton();
            audiobookRB = new RadioButton();
            movieRB = new RadioButton();
            bookRB = new RadioButton();
            titleLabel = new Label();
            languageLabel = new Label();
            publicationYearLabel = new Label();
            ageRestrictionLabel = new Label();
            genreCB = new ComboBox();
            titleTB = new TextBox();
            languageTB = new TextBox();
            publicationYearTB = new TextBox();
            ageRestrictionTB = new TextBox();
            isbnLabel = new Label();
            monthLabel = new Label();
            publisherLabel = new Label();
            illustratorLabel = new Label();
            editionLabel = new Label();
            isbnTB = new TextBox();
            monthTB = new TextBox();
            publisherTB = new TextBox();
            illustratorTB = new TextBox();
            editionTB = new TextBox();
            narratorLabel = new Label();
            durationLabel = new Label();
            directorLabel = new Label();
            narratorTB = new TextBox();
            durationTB = new TextBox();
            directoryTB = new TextBox();
            authorLabel = new Label();
            authorTB = new TextBox();
            submitButton = new Button();
            errorLabel = new Label();
            mediaTypeGB.SuspendLayout();
            SuspendLayout();
            // 
            // mediaTypeGB
            // 
            mediaTypeGB.Controls.Add(magazineRB);
            mediaTypeGB.Controls.Add(audiobookRB);
            mediaTypeGB.Controls.Add(movieRB);
            mediaTypeGB.Controls.Add(bookRB);
            mediaTypeGB.Location = new Point(12, 12);
            mediaTypeGB.Name = "mediaTypeGB";
            mediaTypeGB.Size = new Size(300, 118);
            mediaTypeGB.TabIndex = 0;
            mediaTypeGB.TabStop = false;
            mediaTypeGB.Text = "Select Media Type";
            // 
            // magazineRB
            // 
            magazineRB.AutoSize = true;
            magazineRB.Location = new Point(159, 65);
            magazineRB.Name = "magazineRB";
            magazineRB.Size = new Size(113, 29);
            magazineRB.TabIndex = 3;
            magazineRB.TabStop = true;
            magazineRB.Text = "Magazine";
            magazineRB.UseVisualStyleBackColor = true;
            magazineRB.CheckedChanged += magazineRB_CheckedChanged;
            // 
            // audiobookRB
            // 
            audiobookRB.AutoSize = true;
            audiobookRB.Location = new Point(159, 30);
            audiobookRB.Name = "audiobookRB";
            audiobookRB.Size = new Size(127, 29);
            audiobookRB.TabIndex = 2;
            audiobookRB.TabStop = true;
            audiobookRB.Text = "Audiobook";
            audiobookRB.UseVisualStyleBackColor = true;
            audiobookRB.CheckedChanged += audiobookRB_CheckedChanged;
            // 
            // movieRB
            // 
            movieRB.AutoSize = true;
            movieRB.Location = new Point(6, 65);
            movieRB.Name = "movieRB";
            movieRB.Size = new Size(86, 29);
            movieRB.TabIndex = 1;
            movieRB.TabStop = true;
            movieRB.Text = "Movie";
            movieRB.UseVisualStyleBackColor = true;
            movieRB.CheckedChanged += movieRB_CheckedChanged;
            // 
            // bookRB
            // 
            bookRB.AutoSize = true;
            bookRB.Location = new Point(6, 30);
            bookRB.Name = "bookRB";
            bookRB.Size = new Size(78, 29);
            bookRB.TabIndex = 0;
            bookRB.TabStop = true;
            bookRB.Text = "Book";
            bookRB.UseVisualStyleBackColor = true;
            bookRB.CheckedChanged += bookRB_CheckedChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(18, 153);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(44, 25);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Location = new Point(18, 204);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new Size(89, 25);
            languageLabel.TabIndex = 2;
            languageLabel.Text = "Language";
            // 
            // publicationYearLabel
            // 
            publicationYearLabel.AutoSize = true;
            publicationYearLabel.Location = new Point(18, 256);
            publicationYearLabel.Name = "publicationYearLabel";
            publicationYearLabel.Size = new Size(137, 25);
            publicationYearLabel.TabIndex = 3;
            publicationYearLabel.Text = "Publication year";
            // 
            // ageRestrictionLabel
            // 
            ageRestrictionLabel.AutoSize = true;
            ageRestrictionLabel.Location = new Point(18, 309);
            ageRestrictionLabel.Name = "ageRestrictionLabel";
            ageRestrictionLabel.Size = new Size(127, 25);
            ageRestrictionLabel.TabIndex = 4;
            ageRestrictionLabel.Text = "Age restriction";
            // 
            // genreCB
            // 
            genreCB.FormattingEnabled = true;
            genreCB.Location = new Point(18, 355);
            genreCB.Name = "genreCB";
            genreCB.Size = new Size(303, 33);
            genreCB.TabIndex = 5;
            genreCB.Text = "Genre";
            // 
            // titleTB
            // 
            titleTB.Location = new Point(171, 150);
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(150, 31);
            titleTB.TabIndex = 6;
            // 
            // languageTB
            // 
            languageTB.Location = new Point(171, 201);
            languageTB.Name = "languageTB";
            languageTB.Size = new Size(150, 31);
            languageTB.TabIndex = 7;
            // 
            // publicationYearTB
            // 
            publicationYearTB.Location = new Point(171, 253);
            publicationYearTB.Name = "publicationYearTB";
            publicationYearTB.Size = new Size(150, 31);
            publicationYearTB.TabIndex = 8;
            // 
            // ageRestrictionTB
            // 
            ageRestrictionTB.Location = new Point(171, 306);
            ageRestrictionTB.Name = "ageRestrictionTB";
            ageRestrictionTB.Size = new Size(150, 31);
            ageRestrictionTB.TabIndex = 9;
            // 
            // isbnLabel
            // 
            isbnLabel.AutoSize = true;
            isbnLabel.Enabled = false;
            isbnLabel.Location = new Point(362, 208);
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new Size(95, 25);
            isbnLabel.TabIndex = 10;
            isbnLabel.Text = "ISBN/ISSN";
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Enabled = false;
            monthLabel.Location = new Point(362, 259);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(157, 25);
            monthLabel.TabIndex = 11;
            monthLabel.Text = "Publication Month";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Enabled = false;
            publisherLabel.Location = new Point(362, 311);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(84, 25);
            publisherLabel.TabIndex = 12;
            publisherLabel.Text = "Publisher";
            // 
            // illustratorLabel
            // 
            illustratorLabel.AutoSize = true;
            illustratorLabel.Enabled = false;
            illustratorLabel.Location = new Point(362, 364);
            illustratorLabel.Name = "illustratorLabel";
            illustratorLabel.Size = new Size(87, 25);
            illustratorLabel.TabIndex = 13;
            illustratorLabel.Text = "Illustrator";
            // 
            // editionLabel
            // 
            editionLabel.AutoSize = true;
            editionLabel.Enabled = false;
            editionLabel.Location = new Point(362, 413);
            editionLabel.Name = "editionLabel";
            editionLabel.Size = new Size(67, 25);
            editionLabel.TabIndex = 14;
            editionLabel.Text = "Edition";
            // 
            // isbnTB
            // 
            isbnTB.Enabled = false;
            isbnTB.Location = new Point(536, 205);
            isbnTB.Name = "isbnTB";
            isbnTB.Size = new Size(150, 31);
            isbnTB.TabIndex = 15;
            // 
            // monthTB
            // 
            monthTB.Enabled = false;
            monthTB.Location = new Point(536, 256);
            monthTB.Name = "monthTB";
            monthTB.Size = new Size(150, 31);
            monthTB.TabIndex = 16;
            // 
            // publisherTB
            // 
            publisherTB.Enabled = false;
            publisherTB.Location = new Point(536, 308);
            publisherTB.Name = "publisherTB";
            publisherTB.Size = new Size(150, 31);
            publisherTB.TabIndex = 17;
            // 
            // illustratorTB
            // 
            illustratorTB.Enabled = false;
            illustratorTB.Location = new Point(536, 361);
            illustratorTB.Name = "illustratorTB";
            illustratorTB.Size = new Size(150, 31);
            illustratorTB.TabIndex = 18;
            // 
            // editionTB
            // 
            editionTB.Enabled = false;
            editionTB.Location = new Point(536, 410);
            editionTB.Name = "editionTB";
            editionTB.Size = new Size(150, 31);
            editionTB.TabIndex = 19;
            // 
            // narratorLabel
            // 
            narratorLabel.AutoSize = true;
            narratorLabel.Enabled = false;
            narratorLabel.Location = new Point(362, 156);
            narratorLabel.Name = "narratorLabel";
            narratorLabel.Size = new Size(78, 25);
            narratorLabel.TabIndex = 20;
            narratorLabel.Text = "Narrator";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Enabled = false;
            durationLabel.Location = new Point(362, 109);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(81, 25);
            durationLabel.TabIndex = 21;
            durationLabel.Text = "Duration";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Enabled = false;
            directorLabel.Location = new Point(362, 60);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new Size(75, 25);
            directorLabel.TabIndex = 22;
            directorLabel.Text = "Director";
            // 
            // narratorTB
            // 
            narratorTB.Enabled = false;
            narratorTB.Location = new Point(536, 153);
            narratorTB.Name = "narratorTB";
            narratorTB.Size = new Size(150, 31);
            narratorTB.TabIndex = 23;
            // 
            // durationTB
            // 
            durationTB.Enabled = false;
            durationTB.Location = new Point(536, 106);
            durationTB.Name = "durationTB";
            durationTB.Size = new Size(150, 31);
            durationTB.TabIndex = 24;
            // 
            // directoryTB
            // 
            directoryTB.Enabled = false;
            directoryTB.Location = new Point(536, 57);
            directoryTB.Name = "directoryTB";
            directoryTB.Size = new Size(150, 31);
            directoryTB.TabIndex = 25;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Enabled = false;
            authorLabel.Location = new Point(18, 411);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(67, 25);
            authorLabel.TabIndex = 26;
            authorLabel.Text = "Author";
            // 
            // authorTB
            // 
            authorTB.Enabled = false;
            authorTB.Location = new Point(171, 411);
            authorTB.Name = "authorTB";
            authorTB.Size = new Size(150, 31);
            authorTB.TabIndex = 27;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(643, 12);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(145, 34);
            submitButton.TabIndex = 28;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(362, 12);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(59, 25);
            errorLabel.TabIndex = 29;
            errorLabel.Text = "nameLabel";
            errorLabel.Visible = false;
            // 
            // LibrarianAddMediaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(errorLabel);
            Controls.Add(submitButton);
            Controls.Add(authorTB);
            Controls.Add(authorLabel);
            Controls.Add(directoryTB);
            Controls.Add(durationTB);
            Controls.Add(narratorTB);
            Controls.Add(directorLabel);
            Controls.Add(durationLabel);
            Controls.Add(narratorLabel);
            Controls.Add(editionTB);
            Controls.Add(illustratorTB);
            Controls.Add(publisherTB);
            Controls.Add(monthTB);
            Controls.Add(isbnTB);
            Controls.Add(editionLabel);
            Controls.Add(illustratorLabel);
            Controls.Add(publisherLabel);
            Controls.Add(monthLabel);
            Controls.Add(isbnLabel);
            Controls.Add(ageRestrictionTB);
            Controls.Add(publicationYearTB);
            Controls.Add(languageTB);
            Controls.Add(titleTB);
            Controls.Add(genreCB);
            Controls.Add(ageRestrictionLabel);
            Controls.Add(publicationYearLabel);
            Controls.Add(languageLabel);
            Controls.Add(titleLabel);
            Controls.Add(mediaTypeGB);
            Name = "LibrarianAddMediaForm";
            Text = "LibrarianAddMediaForm";
            mediaTypeGB.ResumeLayout(false);
            mediaTypeGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox mediaTypeGB;
        private RadioButton magazineRB;
        private RadioButton audiobookRB;
        private RadioButton movieRB;
        private RadioButton bookRB;
        private Label titleLabel;
        private Label languageLabel;
        private Label publicationYearLabel;
        private Label ageRestrictionLabel;
        private ComboBox genreCB;
        private TextBox titleTB;
        private TextBox languageTB;
        private TextBox publicationYearTB;
        private TextBox ageRestrictionTB;
        private Label isbnLabel;
        private Label monthLabel;
        private Label publisherLabel;
        private Label illustratorLabel;
        private Label editionLabel;
        private TextBox isbnTB;
        private TextBox monthTB;
        private TextBox publisherTB;
        private TextBox illustratorTB;
        private TextBox editionTB;
        private Label narratorLabel;
        private Label durationLabel;
        private Label directorLabel;
        private TextBox narratorTB;
        private TextBox durationTB;
        private TextBox directoryTB;
        private Label authorLabel;
        private TextBox authorTB;
        private Button submitButton;
        private Label errorLabel;
    }
}