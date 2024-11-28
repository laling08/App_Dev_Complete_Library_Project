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
    public partial class MembersMediaForm : Form
    {
        ResourceManager rm = new ResourceManager("CompleteLibrary_Project.Resources.Resources", typeof(Program).Assembly);
        CultureInfo cultureInfo;
        public MembersMediaForm(CultureInfo culture)
        {
            InitializeComponent();
            cultureInfo = culture;
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

        }
    }
}
