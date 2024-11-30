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

        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class.
        /// </summary>
        /// <param name="title">The title of the movie.</param>
        /// <param name="language">The language of the movie.</param>
        /// <param name="genre">The genre of the movie.</param>
        /// <param name="publicationYear">The publication year of the movie.</param>
        /// <param name="ageRestriction">The age restriction of the movie.</param>
        /// <param name="director">The director of the movie.</param>
        /// <param name="duration">The duration of the movie in minutes.</param>
        public Movie(string title, string language, Genre genre, int publicationYear, int ageRestriction,
                     string director, int duration)
            : base(title, language, genre, publicationYear, ageRestriction)
        {
            Director = director;
            Duration = duration;
            MaxCheckoutLength = 7;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class with an existing media ID.
        /// </summary>
        /// <param name="id">The unique identifier for the movie.</param>
        /// <param name="title">The title of the movie.</param>
        /// <param name="language">The language of the movie.</param>
        /// <param name="genre">The genre of the movie.</param>
        /// <param name="publicationYear">The publication year of the movie.</param>
        /// <param name="ageRestriction">The age restriction of the movie.</param>
        /// <param name="director">The director of the movie.</param>
        /// <param name="duration">The duration of the movie in minutes.</param>
        public Movie(int id, string title, string language, Genre genre, int publicationYear, int ageRestriction,
                     string director, int duration, string status, int maxCheckoutLength = 7)
            : base(id, title, language, genre, publicationYear, ageRestriction, status, maxCheckoutLength)
        {
            Director = director;
            Duration = duration;
            MaxCheckoutLength = maxCheckoutLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class. Required for deserialization.
        /// </summary>
        public Movie()
        {
            // Empty constructor for deserialization purposes
        }

        /// <summary>
        /// Returns a string representation of the movie's details in English.
        /// </summary>
        /// <returns>A string containing the movie's title, language, genre, year, director, and duration.</returns>
        public override string ToString()
        {
            string baseToString = base.ToString();

            return $"MOVIE\n{baseToString}Director:\t\t{Director}\nDuration:\t{Duration}";
        }

        /// <summary>
        /// Returns a string representation of the movie's details in French.
        /// </summary>
        /// <returns>A string containing the movie's title, language, genre, year, director, and duration in French.</returns>
        public override string ToStringFR()
        {
            string baseToString = base.ToStringFR();

            return $"FILM\n{baseToString}Réalisateur(trice):\t{Director}\nLongueur:\t\t{Duration}\n";
        }

        /// <summary>
        /// Returns the movie's information formatted based on its language.
        /// </summary>
        /// <returns>A string with the movie details in English or French, depending on the language.</returns>
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
        /// Marks the movie as checked out, updating its status.
        /// </summary>
        public override void Checkout()
        {
            if (Status == "Available")
            {
                Status = "Checked Out";
                Console.WriteLine($"Movie '{Title}' checked out successfully.");
            }
            else
            {
                Console.WriteLine($"Movie '{Title}' is not available for checkout.");
            }
        }

        /// <summary>
        /// Marks the movie as returned, updating its status to available.
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
        /// Renews the loan for the movie, extending the checkout period.
        /// </summary>
        public override void RenewLoan()
        {
            Console.WriteLine($"Loan for movie '{Title}' renewed successfully.");
        }

        /// <summary>
        /// Applies a late fee for the movie if it is returned late.
        /// </summary>
        public override void GiveLateFee()
        {
            Console.WriteLine($"Late fee applied for movie '{Title}'.");
        }
    }
}
