using CompleteLibrary_Project.Controller.DataAccessibility;
using CompleteLibrary_Project.Model.Enums;
using CompleteLibrary_Project.Model.Medias;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            authorTB.Enabled = true;
            isbnTB.Enabled = true;
            publisherTB.Enabled = true;
            illustratorTB.Enabled = true;
            editionTB.Enabled = true;

            directorLabel.Enabled = false;
            durationLabel.Enabled = false;
            narratorLabel.Enabled = false;
            monthLabel.Enabled = false;
            directorTB.Enabled = false;
            durationTB.Enabled = false;
            narratorTB.Enabled = false;
            monthTB.Enabled = false;

            // Does not check if illustrator is blank because it is often left blank
            if (!(string.IsNullOrWhiteSpace(titleTB.Text) && string.IsNullOrWhiteSpace(languageTB.Text) &&
                string.IsNullOrWhiteSpace(publicationYearTB.Text) && string.IsNullOrWhiteSpace(ageRestrictionTB.Text) &&
                string.IsNullOrWhiteSpace(authorTB.Text) && string.IsNullOrWhiteSpace(isbnTB.Text) &&
                string.IsNullOrWhiteSpace(publisherTB.Text) && string.IsNullOrWhiteSpace(editionTB.Text)))
            {
                submitButton.Enabled = true;
            }
        }

        private void movieRB_CheckedChanged(object sender, EventArgs e)
        {
            durationLabel.Enabled = true;
            directorLabel.Enabled = true;
            durationTB.Enabled = true;
            directorTB.Enabled = true;

            authorLabel.Enabled = false;
            isbnLabel.Enabled = false;
            publisherLabel.Enabled = false;
            illustratorLabel.Enabled = false;
            editionLabel.Enabled = false;
            narratorLabel.Enabled = false;
            monthLabel.Enabled = false;
            authorTB.Enabled = false;
            isbnTB.Enabled = false;
            publisherTB.Enabled = false;
            illustratorTB.Enabled = false;
            editionTB.Enabled = false;
            narratorTB.Enabled = false;
            monthTB.Enabled = false;
        }

        private void audiobookRB_CheckedChanged(object sender, EventArgs e)
        {
            authorLabel.Enabled = true;
            isbnLabel.Enabled = true;
            publisherLabel.Enabled = true;
            editionLabel.Enabled = true;
            durationLabel.Enabled = true;
            narratorLabel.Enabled = true;
            authorTB.Enabled = true;
            isbnTB.Enabled = true;
            publisherTB.Enabled = true;
            editionTB.Enabled = true;
            durationTB.Enabled = true;
            narratorTB.Enabled = true;

            directorLabel.Enabled = false;
            monthLabel.Enabled = false;
            illustratorLabel.Enabled = false;
            directorTB.Enabled = false;
            monthTB.Enabled = false;
            illustratorTB.Enabled = false;
        }

        private void magazineRB_CheckedChanged(object sender, EventArgs e)
        {
            isbnLabel.Enabled = true;
            publisherLabel.Enabled = true;
            monthLabel.Enabled = true;
            isbnTB.Enabled = true;
            publisherTB.Enabled = true;
            monthTB.Enabled = true;

            editionLabel.Enabled = false;
            durationLabel.Enabled = false;
            narratorLabel.Enabled = false;
            authorLabel.Enabled = false;
            directorLabel.Enabled = false;
            illustratorLabel.Enabled = false;
            editionTB.Enabled = false;
            durationTB.Enabled = false;
            narratorTB.Enabled = false;
            authorTB.Enabled = false;
            directorTB.Enabled = false;
            illustratorTB.Enabled = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (bookRB.Checked)
            {
                AddBook();
            }
            else if (movieRB.Checked)
            {
                AddMovie();
            }
            else if (audiobookRB.Checked)
            {
                AddAudiobook();
            }
            else if (magazineRB.Checked)
            {
                AddMagazine();
            }
        }

        private void AddMovie()
        {
            string title = titleTB.Text;
            string language = languageTB.Text;
            int year;
            int ageRestriction;
            Genre genre;
            string director = directorTB.Text;
            int duration;

            if (genreCB == null)
            {
                genre = Genre.OTHER;
            } else
            {
                genre = (Genre) genreCB.SelectedItem;
            }

            try
            {
                year = int.Parse(publicationYearTB.Text);
                ageRestriction = int.Parse(ageRestrictionTB.Text);
                duration = int.Parse(durationTB.Text);

                Movie movie = new Movie(title, language, genre, year, ageRestriction, director, duration);
                DataAccess.SaveMovieToFile(movie);
                errorLabel.Text = string.Format(rm.GetString("media_insert"), movie.Id);
                errorLabel.Visible = true;
            }
            catch (FormatException fe)
            {
                errorLabel.Text = rm.GetString("int_error");
                errorLabel.Visible = true;
            }
        }

        private void AddBook()
        {
            string title = titleTB.Text;
            string language = languageTB.Text;
            int year;
            int ageRestriction;
            Genre genre;
            string author = authorTB.Text;
            string publisher = publisherTB.Text;
            string isbn = isbnTB.Text;
            string illustrator = illustratorTB.Text;
            int edition;

            if (genreCB == null)
            {
                genre = Genre.OTHER;
            }
            else
            {
                genre = (Genre)genreCB.SelectedItem;
            }

            try
            {
                year = int.Parse(publicationYearTB.Text);
                ageRestriction = int.Parse(ageRestrictionTB.Text);
                edition = int.Parse(editionTB.Text);

                Book book = new Book(title, language, genre, year, ageRestriction, isbn, author, publisher, illustrator, edition);
                DataAccess.SaveBookToFile(book);
                errorLabel.Text = string.Format(rm.GetString("media_insert"), book.Id);
                errorLabel.Visible = true;
            }
            catch (FormatException fe)
            {
                errorLabel.Text = rm.GetString("int_error");
                errorLabel.Visible = true;
            }
        }

        private void AddAudiobook()
        {
            string title = titleTB.Text;
            string language = languageTB.Text;
            int year;
            int ageRestriction;
            Genre genre;
            string author = authorTB.Text;
            string publisher = publisherTB.Text;
            string isbn = isbnTB.Text;
            string narrator = narratorTB.Text;
            int duration;
            int edition;

            if (genreCB == null)
            {
                genre = Genre.OTHER;
            }
            else
            {
                genre = (Genre)genreCB.SelectedItem;
            }

            try
            {
                year = int.Parse(publicationYearTB.Text);
                ageRestriction = int.Parse(ageRestrictionTB.Text);
                edition = int.Parse(editionTB.Text);
                duration = int.Parse(durationTB.Text);

                Audiobook audiobook = new Audiobook(title, language, genre, year, ageRestriction, isbn, author, publisher, narrator, edition, duration);
                DataAccess.SaveAudiobookToFile(audiobook);
                errorLabel.Text = string.Format(rm.GetString("media_insert"), audiobook.Id);
                errorLabel.Visible = true;
            }
            catch (FormatException fe)
            {
                errorLabel.Text = rm.GetString("int_error");
                errorLabel.Visible = true;
            }
        }

        private void AddMagazine()
        {
            string title = titleTB.Text;
            string language = languageTB.Text;
            int year;
            int ageRestriction;
            Genre genre;
            string issn = isbnTB.Text;
            string publicationMonth = monthTB.Text;
            string publisher = publisherTB.Text;

            if (genreCB == null)
            {
                genre = Genre.OTHER;
            }
            else
            {
                genre = (Genre)genreCB.SelectedItem;
            }

            try
            {
                year = int.Parse(publicationYearTB.Text);
                ageRestriction = int.Parse(ageRestrictionTB.Text);

                Magazine magazine = new Magazine(title, language, genre, year, ageRestriction, issn, publisher, publicationMonth);
                DataAccess.SaveMagazineToFile(magazine);
                errorLabel.Text = string.Format(rm.GetString("media_insert"), magazine.Id);
                errorLabel.Visible = true;
            }
            catch (FormatException fe)
            {
                errorLabel.Text = rm.GetString("int_error");
                errorLabel.Visible = true;
            }
        }
    }
}
