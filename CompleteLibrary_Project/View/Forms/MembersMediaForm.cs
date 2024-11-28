using CompleteLibrary_Project.Controller.DataAccessibility;
using CompleteLibrary_Project.Model.Exceptions;
using CompleteLibrary_Project.Model.Medias;
using CompleteLibrary_Project.Model.Users;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompleteLibrary_Project
{
    public partial class MembersMediaForm : Form
    {
        ResourceManager rm = new ResourceManager("CompleteLibrary_Project.Resources.Resources", typeof(Program).Assembly);
        CultureInfo cultureInfo;
        List<Media> queriedMedia;
        User member;
        Media item;
        public MembersMediaForm(CultureInfo culture, List<Media> media)
        {
            InitializeComponent();
            cultureInfo = culture;
            queriedMedia = media;
            SetText();
        }

        private void SetText()
        {
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            userIdLabel.Text = rm.GetString("enter_id");
            idErrorLabel.Text = rm.GetString("id_error");
            selectLabel.Text = rm.GetString("select_following");
            holdButton.Text = rm.GetString("hold");
            borrowButton.Text = rm.GetString("borrow");
            queriedMediaLV.Columns[0].Text = rm.GetString("title");
            queriedMediaLV.Columns[1].Text = rm.GetString("status");
            queriedMediaLV.Columns[2].Text = rm.GetString("language1");

            foreach (Media media in queriedMedia)
            {
                ListViewItem item = new ListViewItem(media.Title);
                item.SubItems.Add(media.Status);
                item.SubItems.Add(media.Language);
                item.SubItems.Add(media.Id + "");
                queriedMediaLV.Items.Add(item);
            }
        }

        private void userIdTB_TextChanged(object sender, EventArgs e)
        {
            string id = userIdTB.Text;
            bool validUserFound = false;

            if (!id.All(char.IsDigit))
            {
                idErrorLabel.Visible = true;
            }
            else
            {
                List<User> users = DataAccess.LoadAllUsers();
                foreach (User user in users)
                {
                    if (user.Id.ToString() == id.ToString())
                    {
                        member = user;
                        validUserFound = true;
                        break;
                    }
                }

                if (validUserFound)
                {
                    idErrorLabel.Visible = false;
                }
                else
                {
                    idErrorLabel.Visible = true;
                }
            }

            UpdateButtonStates(validUserFound);
        }

        private void queriedMediaLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool validUserFound = member != null;
            //item = (Media)queriedMediaLV.SelectedItems[0].Tag;
            int selectedIndex = queriedMediaLV.SelectedItems[0].Index;
            Media selectedMedia = queriedMedia[selectedIndex];
            item = selectedMedia;

            UpdateButtonStates(validUserFound);
        }

        private void UpdateButtonStates(bool validUserFound)
        {
            if (queriedMediaLV.SelectedItems.Count > 0 && validUserFound)
            {
                holdButton.Enabled = true;
                borrowButton.Enabled = true;
            }
            else
            {
                holdButton.Enabled = false;
                borrowButton.Enabled = false;
            }
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            List<User> users = DataAccess.LoadAllUsers();
            foreach (User user in users)
            {
                if (user.Id == member.Id)
                {
                    try
                    {
                        if (user.Checkout(item))
                        {
                            DataAccess.SaveUsersToFile(users);
                            completedLabel.Visible = true;
                            completedLabel.Text = string.Format(rm.GetString("successful_checkout"), item.Title, item.MaxCheckoutLength);
                        }
                        else
                        {
                            completedLabel.Visible = true;
                            completedLabel.Text = string.Format(rm.GetString("unsuccessful_checkout"), item.Title);
                        }
                    } catch (TooYoungException tye)
                    {
                        completedLabel.Visible = true;
                        completedLabel.Text = rm.GetString("too_young_exception");
                    }
                    
                }
            }

            Console.WriteLine(DataAccess.LoadAudiobook(9).Status);
        }

        private void holdButton_Click(object sender, EventArgs e)
        {
            List<User> users = DataAccess.LoadAllUsers();
            foreach (User user in users)
            {
                if (user.Id == member.Id)
                {
                    try
                    {
                        if (user.PlaceHold(item))
                        {
                            DataAccess.SaveUsersToFile(users);
                            completedLabel.Visible = true;
                            completedLabel.Text = string.Format(rm.GetString("successfule_hold"), item.Title);
                        }
                        else
                        {
                            completedLabel.Visible = true;
                            completedLabel.Text = string.Format(rm.GetString("unsuccessful_checkout"), item.Title);
                        }
                    } catch (TooYoungException tye)
                    {
                        completedLabel.Visible = true;
                        completedLabel.Text = rm.GetString("too_young_exception");
                    }
                }
            }
        }
    }
}
