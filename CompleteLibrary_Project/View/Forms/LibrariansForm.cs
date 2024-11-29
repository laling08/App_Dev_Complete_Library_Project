using CompleteLibrary_Project.Controller.DataAccessibility;
using CompleteLibrary_Project.Model.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteLibrary_Project
{
    public partial class LibrariansForm : Form
    {
        ResourceManager rm = new ResourceManager("CompleteLibrary_Project.Resources.Resources", typeof(Program).Assembly);
        CultureInfo cultureInfo;
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
            ValidateForm();
        }

        private void memberRB_CheckedChanged(object sender, EventArgs e)
        {
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
                User member = new Member(fnameTB.Text, lnameTB.Text,
                    new DateTime(int.Parse(yearTB.Text), int.Parse(monthTB.Text), int.Parse(dayTB.Text)));
                DataAccess.SaveUserToFile(member);
                userErrorLabel.Text = string.Format(rm.GetString("member_add"), member.Id);
                userErrorLabel.Visible = true;
            }
            else
            {
                User librarian = new Librarian(fnameTB.Text, lnameTB.Text,
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
    }
}
