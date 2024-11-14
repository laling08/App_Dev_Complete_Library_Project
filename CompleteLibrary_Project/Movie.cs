using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project
{
    /// <summary>
    /// Model for Movie Class.
    /// </summary>
    public class Movie : Media
    {
        public string Director { get; set; }
        public int Duration { get; set; }

        public Movie(string title, string language, Genre genre, int publicationYear, int ageRestriction,
                     string director, int duration)
            : base(title, language, genre, publicationYear, ageRestriction)
        {
            Director = director;
            Duration = duration;
            MaxCheckoutLength = 7;
        }

        public override void Checkout() { }

        public override void ReturnItem(char returnedCondition) { }

        public override void RenewLoan() { }

        public override void GiveLateFee() { }
    }
}
