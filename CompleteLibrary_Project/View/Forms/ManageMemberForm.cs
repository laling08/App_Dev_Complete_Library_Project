using CompleteLibrary_Project.Controller.DataAccessibility;
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

namespace CompleteLibrary_Project.View.Forms
{
    public partial class ManageMemberForm : Form
    {
        ResourceManager rm;
        CultureInfo cultureInfo;
        public ManageMemberForm(CultureInfo culture)
        {
            InitializeComponent();
            rm = new ResourceManager("CompleteLibrary_Project.Resources.Resources", typeof(Program).Assembly);
            cultureInfo = culture;
            SetText();
        }

        private void SetText()
        {
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            nameLabel.Text = rm.GetString("name");
            idLabel.Text = rm.GetString("member_id");
            lateFeeRadioButton.Text = rm.GetString("give_late_fee");
            historyRadioButton.Text = rm.GetString("view_member_history");
            submitButton.Text = rm.GetString("submit");
            memberHistoryLabel.Text = rm.GetString("member_history");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string memberName = nameTB.Text;
            int memberId;

            if (int.TryParse(idTB.Text, out memberId))
            {
                if (lateFeeRadioButton.Checked)
                {
                    ApplyLateFee(memberId);
                }
                else if (historyRadioButton.Checked)
                {
                    DisplayMemberHistory(memberId);
                }
            }
            else
            {
                MessageBox.Show(rm.GetString("invalid_id"), rm.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyLateFee(int memberId)
        {
            List<User> users = DataAccess.LoadAllUsers();
            User member = users.FirstOrDefault(u => u.Id == memberId);

            if (member is Member m)
            {
                m.GiveLateFee();
                MessageBox.Show(rm.GetString("late_fee_applied"), rm.GetString("success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(rm.GetString("member_not_found"), rm.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMemberHistory(int memberId)
        {
            List<Loan> loans = DataAccess.LoadAllLoans();
            var memberLoans = loans.Where(loan => loan.UserId == memberId).ToList();

            if (memberLoans.Any())
            {
                StringBuilder historyBuilder = new StringBuilder();
                foreach (var loan in memberLoans)
                {
                    historyBuilder.AppendLine($"{rm.GetString("media_title")}: {loan.MediaTitle}");
                    historyBuilder.AppendLine($"{rm.GetString("loan_date")}: {loan.LoanDate.ToShortDateString()}");
                    historyBuilder.AppendLine($"{rm.GetString("return_date")}: {(loan.ReturnDate.HasValue ? loan.ReturnDate.Value.ToShortDateString() : rm.GetString("not_returned"))}");
                    historyBuilder.AppendLine("----------------------------");
                }

                memberHistoryRTB.Text = historyBuilder.ToString();
            }
            else
            {
                memberHistoryRTB.Text = rm.GetString("no_history_found");
            }
        }
    }
}
