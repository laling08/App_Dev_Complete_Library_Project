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
    public partial class MembersForm : Form
    {
        ResourceManager rm = new ResourceManager("CompleteLibrary_Project.Resources.Resources", typeof(Program).Assembly);
        CultureInfo cultureInfo;
        public MembersForm(CultureInfo culture)
        {
            InitializeComponent();
            cultureInfo = culture;
            SetText();
        }

        private void searchBT_Click(object sender, EventArgs e)
        {
            List<Media> medias = new List<Media>();
            if (typeSearchTB.Text.Equals("book", StringComparison.InvariantCultureIgnoreCase) ||
                typeSearchTB.Text.Equals("livre", StringComparison.InvariantCultureIgnoreCase))
            {
                List<Book> books = DataAccess.LoadAllBooks();
                medias.AddRange(books);
            }
            else if (typeSearchTB.Text.Equals("movie", StringComparison.InvariantCultureIgnoreCase) ||
                typeSearchTB.Text.Equals("film", StringComparison.InvariantCultureIgnoreCase))
            {
                List<Movie> movies = DataAccess.LoadAllMovies();
                medias.AddRange(movies);
            }
            else if (typeSearchTB.Text.Equals("audiobook", StringComparison.InvariantCultureIgnoreCase) ||
                typeSearchTB.Text.Equals("audiolivre", StringComparison.InvariantCultureIgnoreCase))
            {
                List<Audiobook> audiobooks = DataAccess.LoadAllAudiobooks();
                medias.AddRange(audiobooks);
            }
            else if (typeSearchTB.Text.Equals("magazine", StringComparison.InvariantCultureIgnoreCase))
            {
                List<Magazine> magazines = DataAccess.LoadAllMagazines();
                medias.AddRange(magazines);
            }


            resultsListBox.Items.Clear();

            string query = titleSearchTB.Text.ToLower();
            List<Media> results = medias.Where(item => item.Title.ToLower().Contains(query)).ToList();

            foreach (Media result in results)
            {
                resultsListBox.Items.Add(result.ToString());
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
