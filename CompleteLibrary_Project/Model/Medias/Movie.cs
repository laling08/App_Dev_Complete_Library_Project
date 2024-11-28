using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CompleteLibrary_Project.Model.Enums;

namespace CompleteLibrary_Project.Model.Medias
{
    /// <summary>
    /// Model for Movie Class.
    /// </summary>
    public class Movie : Media
    {
        [JsonPropertyName("director")]
        public string Director { get; set; }
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        public Movie(string title, string language, Genre genre, int publicationYear, int ageRestriction,
                     string director, int duration)
            : base(title, language, genre, publicationYear, ageRestriction)
        {
            Director = director;
            Duration = duration;
            MaxCheckoutLength = 7;
        }

        public Movie(int id, string title, string language, Genre genre, int publicationYear, int ageRestriction,
                     string director, int duration)
            : base(id, title, language, genre, publicationYear, ageRestriction)
        {
            Director = director;
            Duration = duration;
            MaxCheckoutLength = 7;
        }

        public Movie()
        {
            // empty constructor required for deserialization
        }


        public override string? ToString()
        {
            string baseToString = base.ToString();

            return $"MOVIE\n{baseToString}Director:\t\t{Director}\nDuration:\t{Duration}";
        }

        public override string? ToStringFR()
        {
            string baseToString = base.ToStringFR();

            return $"FILM\n{baseToString}Réalisateur(trice):\t{Director}\nLongeur:\t\t{Duration}\n";
        }

        /// <summary>
        /// Returns the magazines's information based on its language.
        /// </summary>
        /// <returns>The formatted details in English or French.</returns>
        public override string GetMediaInfo()
        {
            if (Language.ToLower() == "fr")
            {
                return ToStringFR();
            }
            else
            {
                return ToString();
            }
        }

        /// <summary>
        /// Marks the magazines as checked out.
        /// </summary>
        public override void Checkout()
        {
            if (Status == "Available")
            {
                Status = "Checked Out";
                Console.WriteLine($"Magazine '{Title}' check out successfully.");
            }
            else
            {
                Console.WriteLine($"Magazine '{Title}' is not availble for checkout.");
            }
        }

        /// <summary>
        /// Marks the Movie as returned.
        /// </summary>
        public override void ReturnItem()
        {
            if (Status == "Checked Out")
            {
                Status = "Available";
                Console.WriteLine($"Movie '{Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine($"Movie '{Title}' is not checked out.");
            }
        }

        /// <summary>
        /// Renews the loan for the Movie.
        /// </summary>
        public override void RenewLoan()
        {
            Console.WriteLine($"Loan for Movie '{Title}' renewed successfully.");
        }

        /// <summary>
        /// Applies a late fee for the Movie.
        /// </summary>
        public override void GiveLateFee()
        {
            Console.WriteLine($"Late fee applied for Movie '{Title}'.");
        }
    }
}
