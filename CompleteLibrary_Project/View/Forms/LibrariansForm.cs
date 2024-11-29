using CompleteLibrary_Project.Controller.DataAccessibility;
using CompleteLibrary_Project.Model.Medias;
using CompleteLibrary_Project.Model.Users;
using System.Globalization;
using System.Resources;

namespace CompleteLibrary_Project
{
    public partial class LibrariansForm : Form
    {
        ResourceManager rm = new ResourceManager("CompleteLibrary_Project.Resources.Resources", typeof(Program).Assembly);
        CultureInfo cultureInfo;
        UserFactory userFactory = new UserFactory();
        public LibrariansForm(CultureInfo culture)
        {
            InitializeComponent();
            cultureInfo = culture;
            SetText();
        }

        private void SetText()
        {
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            addUserButton.Text = rm.GetString("add_user");
            addMediaButton.Text = rm.GetString("add_media");
            returnItemButton.Text = rm.GetString("return_item");

            addNewUserGB.Text = rm.GetString("add_user");
            memberRB.Text = rm.GetString("member");
            librarianRB.Text = rm.GetString("librarian");
            fnameLabel.Text = rm.GetString("fname");
            lnameLabel.Text = rm.GetString("lname");
            dobLabel.Text = rm.GetString("dob");
            userSubmitButton.Text = rm.GetString("submit");

            returnItemLabel.Text = rm.GetString("return_item");
            userIdLabel.Text = rm.GetString("user_id");
            mediaIdLabel.Text = rm.GetString("media_id");
            returnSubmitButton.Text = rm.GetString("submit");
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            addNewUserGB.Visible = true;
            memberRB.Visible = true;
            librarianRB.Visible = true;
            fnameLabel.Visible = true;
            lnameLabel.Visible = true;
            dobLabel.Visible = true;
            userSubmitButton.Visible = true;
            fnameTB.Visible = true;
            lnameTB.Visible = true;
            yearTB.Visible = true;
            monthTB.Visible = true;
            dayTB.Visible = true;


        }

        private void returnItemButton_Click(object sender, EventArgs e)
        {
            returnItemLabel.Visible = true;
            userIdLabel.Visible = true;
            mediaIdLabel.Visible = true;
            returnSubmitButton.Visible = true;
            userIdTB.Visible = true;
            mediaIdTB.Visible = true;
        }

        private void addMediaButton_Click(object sender, EventArgs e)
        {
            LibrarianAddMediaForm form = new LibrarianAddMediaForm(cultureInfo);
            form.Show();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            userErrorLabel.Visible = false;
            ValidateForm();
        }

        private void memberRB_CheckedChanged(object sender, EventArgs e)
        {
            userErrorLabel.Visible = false;
            ValidateForm();
        }

        private void ValidateForm()
        {
            if (!(string.IsNullOrWhiteSpace(fnameTB.Text) && string.IsNullOrWhiteSpace(lnameTB.Text) &&
                string.IsNullOrWhiteSpace(yearTB.Text) && string.IsNullOrWhiteSpace(monthTB.Text) &&
                string.IsNullOrWhiteSpace(dayTB.Text)))
            {
                if (!IsDateValid())
                {
                    userErrorLabel.Visible = true;
                    userErrorLabel.Text = rm.GetString("date_error");
                }
                else
                {
                    userSubmitButton.Enabled = true;
                }
            }
        }

        private bool IsDateValid()
        {
            if (string.IsNullOrWhiteSpace(yearTB.Text) ||
                string.IsNullOrWhiteSpace(monthTB.Text) ||
                string.IsNullOrWhiteSpace(dayTB.Text))
            {
                return true; // Skip validation if any field is empty
            }

            try
            {
                int year = int.Parse(yearTB.Text);
                int month = int.Parse(monthTB.Text);
                int day = int.Parse(dayTB.Text);

                DateTime date = new DateTime(year, month, day);
                return true; // Date is valid
            }
            catch (FormatException e)
            {
                return false; // Date is invalid
            }
            catch (ArgumentOutOfRangeException)
            {
                return false; // Date is invalid
            }
        }

        private void userSubmitButton_Click(object sender, EventArgs e)
        {
            if (memberRB.Checked)
            {
                User member = userFactory.getUser("Member", fnameTB.Text, lnameTB.Text,
                    new DateTime(int.Parse(yearTB.Text), int.Parse(monthTB.Text), int.Parse(dayTB.Text)));

                DataAccess.SaveUserToFile(member);
                userErrorLabel.Text = string.Format(rm.GetString("member_add"), member.Id);
                userErrorLabel.Visible = true;
            }
            else
            {
                User librarian = userFactory.getUser("Librarian", fnameTB.Text, lnameTB.Text,
                    new DateTime(int.Parse(yearTB.Text), int.Parse(monthTB.Text), int.Parse(dayTB.Text)));
                DataAccess.SaveUserToFile(librarian);
                userErrorLabel.Text = string.Format(rm.GetString("librarian_add"), librarian.Id);
                userErrorLabel.Visible = true;
            }
        }

        private void librarianRB_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void TB_TextChanged(object sender, EventArgs e)
        {
            returnErrorLabel.Visible = false;

            if (!(string.IsNullOrWhiteSpace(userIdTB.Text) && string.IsNullOrWhiteSpace(mediaIdTB.Text)))
            {
                try
                {
                    List<Loan> loans = DataAccess.LoadAllLoans();

                    bool loanExists = loans.Any(loan => loan.UserId == int.Parse(userIdTB.Text) && loan.MediaId == int.Parse(mediaIdTB.Text));

                    if (loanExists)
                    {
                        returnSubmitButton.Enabled = true;
                    }
                    else
                    {
                        returnErrorLabel.Visible = true;
                        returnErrorLabel.Text = rm.GetString("invalid_loan");
                    }
                }
                catch (FormatException fe)
                {
                    returnErrorLabel.Visible = true;
                    returnErrorLabel.Text = rm.GetString("invalid_loan");
                }
            }
        }

        private void returnSubmitButton_Click(object sender, EventArgs e)
        {
            int mediaId = int.Parse(mediaIdTB.Text);
            List<User> users = DataAccess.LoadAllUsers();
            User user = users.FirstOrDefault(u => u.Id == int.Parse(userIdTB.Text));

            List<Loan> loans = DataAccess.LoadAllLoans();
            Loan loan = loans.FirstOrDefault(l => l.MediaId == mediaId);

            switch (loan.MediaType)
            {
                case "CompleteLibrary_Project.Model.Medias.Book":
                    user.ReturnMedia(DataAccess.LoadBook(mediaId));
                    returnErrorLabel.Text = rm.GetString("return");
                    break;
                case "CompleteLibrary_Project.Model.Medias.Movie":
                    user.ReturnMedia(DataAccess.LoadMovie(mediaId));
                    returnErrorLabel.Text = rm.GetString("return");
                    break;
                case "CompleteLibrary_Project.Model.Medias.Audiobook":
                    user.ReturnMedia(DataAccess.LoadAudiobook(mediaId));
                    returnErrorLabel.Text = rm.GetString("return");
                    break;
                case "CompleteLibrary_Project.Model.Medias.Magazine":
                    user.ReturnMedia(DataAccess.LoadMagazine(mediaId));
                    returnErrorLabel.Text = rm.GetString("return");
                    break;
                default:
                    returnErrorLabel.Text = rm.GetString("invalid_loan");
                    break;
            }

            DataAccess.SaveUsersToFile(users);
            returnErrorLabel.Visible = true;
        }
    }
}
