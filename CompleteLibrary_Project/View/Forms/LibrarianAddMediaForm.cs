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
        }
    }
}
