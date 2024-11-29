using CompleteLibrary_Project.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteLibrary_Project
{
    public partial class LibrarianAddMediaForm : Form
    {
        ResourceManager rm = new ResourceManager("CompleteLibrary_Project.Resources.Resources", typeof(Program).Assembly);
        CultureInfo cultureInfo;

        public LibrarianAddMediaForm(CultureInfo culture)
        {
            InitializeComponent();
            cultureInfo = culture;
            SetText();
        }

        private void SetText()
        {
            mediaTypeGB.Text = rm.GetString("media_selection");
            bookRB.Text = rm.GetString("book");
            movieRB.Text = rm.GetString("movie");
            audiobookRB.Text = rm.GetString("audiobook");
            magazineRB.Text = rm.GetString("magazine");
            submitButton.Text = rm.GetString("submit");

            titleLabel.Text = rm.GetString("title");
            languageLabel.Text = rm.GetString("language1");
            publicationYearLabel.Text = rm.GetString("publication_year");
            ageRestrictionLabel.Text = rm.GetString("age_restriction");
            genreCB.Text = "Genre";
            genreCB.DataSource = Enum.GetValues(typeof(Genre));
            authorLabel.Text = rm.GetString("author");
            directorLabel.Text = rm.GetString("director");
            durationLabel.Text = rm.GetString("duration");
            narratorLabel.Text = rm.GetString("narrator");
            isbnLabel.Text = "ISBN/ISSN";
            monthLabel.Text = rm.GetString("publication_month");
            publisherLabel.Text = rm.GetString("publisher");
            illustratorLabel.Text = rm.GetString("illustrator");
            editionLabel.Text = rm.GetString("edition");


        }

        private void bookRB_CheckedChanged(object sender, EventArgs e)
        {
            authorLabel.Enabled = true;
            isbnLabel.Enabled = true;
            publisherLabel.Enabled = true;
            illustratorLabel.Enabled = true;
            editionLabel.Enabled = true;

            directorLabel.Enabled = false;
            durationLabel.Enabled = false;
            narratorLabel.Enabled = false;
            monthLabel.Enabled = false;
        }

        private void movieRB_CheckedChanged(object sender, EventArgs e)
        {
            durationLabel.Enabled = true;
            narratorLabel.Enabled = true;

            authorLabel.Enabled = false;
            isbnLabel.Enabled = false;
            publisherLabel.Enabled = false;
            illustratorLabel.Enabled = false;
            editionLabel.Enabled = false;
            directorLabel.Enabled = false;
            monthLabel.Enabled = false;
        }

        private void audiobookRB_CheckedChanged(object sender, EventArgs e)
        {
            authorLabel.Enabled = true;
            isbnLabel.Enabled = true;
            publisherLabel.Enabled = true;
            editionLabel.Enabled = true;
            durationLabel.Enabled = true;
            narratorLabel.Enabled = true;

            directorLabel.Enabled = false;
            monthLabel.Enabled = false;
            illustratorLabel.Enabled = false;
        }

        private void magazineRB_CheckedChanged(object sender, EventArgs e)
        {
            isbnLabel.Enabled = true;
            publisherLabel.Enabled = true;
            monthLabel.Enabled = true;

            editionLabel.Enabled = false;
            durationLabel.Enabled = false;
            narratorLabel.Enabled = false;
            authorLabel.Enabled = false;
            directorLabel.Enabled = false;
            illustratorLabel.Enabled = false;
        }
    }
}
