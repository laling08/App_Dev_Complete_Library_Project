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
using CompleteLibrary_Project.Controller.DataAccessibility;
using CompleteLibrary_Project.Model.Medias;

namespace CompleteLibrary_Project
{
    public partial class MembersForm : Form
    {
        ResourceManager rm = new ResourceManager("CompleteLibrary_Project.Resources.Resources", typeof(Program).Assembly);
        CultureInfo cultureInfo;
        public MembersForm(CultureInfo culture)
        {
            InitializeComponent();
            cultureInfo = culture;
            SetText();
            typeSearchCB.Items.AddRange(new object[] { rm.GetString("book"), rm.GetString("audiobook"), rm.GetString("movie"), rm.GetString("magazine") });
            titleSearchTB.PlaceholderText = rm.GetString("title");
        }

        private void searchBT_Click(object sender, EventArgs e)
        {
            List<Media> medias = new List<Media>();
            if (typeSearchCB.Text.Equals("Book") || typeSearchCB.Text.Equals("Livre"))
            {
                List<Book> books = DataAccess.LoadAllBooks();
                medias.AddRange(books);
            }
            else if (typeSearchCB.Text.Equals("Movie") || typeSearchCB.Text.Equals("Film"))
            {
                List<Movie> movies = DataAccess.LoadAllMovies();
                medias.AddRange(movies);
            }
            else if (typeSearchCB.Text.Equals("Audiobook") || typeSearchCB.Text.Equals("Livre audio"))
            {
                List<Audiobook> audiobooks = DataAccess.LoadAllAudiobooks();
                medias.AddRange(audiobooks);
            }
            else if (typeSearchCB.Text.Equals("Magazine"))
            {
                List<Magazine> magazines = DataAccess.LoadAllMagazines();
                medias.AddRange(magazines);
            }
            else
            {
                List<Book> books = DataAccess.LoadAllBooks();
                medias.AddRange(books);
            }


            resultsRTB.Clear();

            string query = titleSearchTB.Text.ToLower();
            List<Media> results = medias.Where(item => item.Title.ToLower().Contains(query)).ToList();

            foreach (Media result in results)
            {
                if (cultureInfo.Name.Equals("fr-CA"))
                {
                    resultsRTB.Text += result.ToStringFR();
                }
                else
                {
                    resultsRTB.Text += result.ToString();
                }
            }
        }

        private void SetText()
        {
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            label1.Text = rm.GetString("search_message");
            searchBT.Text = rm.GetString("search");
        }
    }
}
