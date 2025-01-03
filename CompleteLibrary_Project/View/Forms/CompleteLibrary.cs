
using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;

namespace CompleteLibrary_Project
{

    public partial class CompleteLibrary : Form
    {
        ResourceManager rm = new ResourceManager("CompleteLibrary_Project.Resources.Resources", typeof(Program).Assembly);
        CultureInfo cultureInfo = new CultureInfo("en-CA");
        public CompleteLibrary()
        {
            InitializeComponent();
        }

        private void membersButton_Click(object sender, EventArgs e)
        {
            MembersSearchForm form = new MembersSearchForm(cultureInfo);
            form.Show();
        }

        private void librariansButton_Click(object sender, EventArgs e)
        {
            LibrariansForm form = new LibrariansForm(cultureInfo);
            form.Show();
        }

        private void languageButton_Click(object sender, EventArgs e)
        {
            if (cultureInfo.Name.Equals("en-CA"))
            {
                cultureInfo = new CultureInfo("fr-CA");
            } else
            {
                cultureInfo = new CultureInfo("en-CA");
            }

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            
            welcomeLB.Text = rm.GetString("welcome_message");
            librariansButton.Text = rm.GetString("librarians");
            membersButton.Text = rm.GetString("members");
            languageButton.Text = rm.GetString("language");
        }
    }
}
