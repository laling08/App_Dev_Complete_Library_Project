using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project
{
    /// <summary>
    /// Model for Media Class.
    /// </summary>
    public abstract class Media : ILoanable
    {

        private static int count = 1;
        public int Id { get; set; }
        public List<Loan> History { get; set; } = new List<Loan>();
        public string Title { get; set; }
        public string Language { get; set; }
        public Genre Genre { get; set; }
        public int PublicationYear { get; set; }
        public int AgeRestriction { get; set; }
        public int MaxCheckoutLength { get; set; }
        public string Status { get; set; } = "Available";

        public Media(string title, string language, Genre genre, int publicationYear, int ageRestriction)
        {
            Title = title;
            Language = language;
            Genre = genre;
            PublicationYear = publicationYear;
            AgeRestriction = ageRestriction;
            Id = count++;
        }

        public Media(int id, string title, string language, Genre genre, int publicationYear, int ageRestriction)
        {
            Id = id;
            Title = title;
            Language = language;
            Genre = genre;
            PublicationYear = publicationYear;
            AgeRestriction = ageRestriction;
            Status = "Available";
        }

        /// <summary>
        /// Calculates the date by which the borrowed media must be returned.
        /// </summary>
        /// <returns>The return date as <see cref="DateTime"/>.</returns>
        public DateTime CalculateReturnDate()
        {
            return DateTime.Now.AddDays(MaxCheckoutLength);
        }

        public abstract void Checkout();
        public abstract void ReturnItem(char returnedCondition);
        public abstract void RenewLoan();
        public abstract void GiveLateFee();
    }

}
