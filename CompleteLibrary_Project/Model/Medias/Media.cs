using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CompleteLibrary_Project.Model.Enums;
using CompleteLibrary_Project.Model.Interfaces;

namespace CompleteLibrary_Project.Model.Medias
{
    /// <summary>
    /// Represents a media item in the library system.
    /// This class is the base for specific media types like books, magazines, etc.
    /// </summary
    public abstract class Media : ILoanable
    {
        private static int count = 20;
        [JsonPropertyName("id")]
        public int Id { get; set; }
        public List<Loan> History { get; set; } = new List<Loan>();
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("language")]
        public string Language { get; set; }
        [JsonPropertyName("genre")]
        public Genre Genre { get; set; }
        [JsonPropertyName("publication_year")]
        public int PublicationYear { get; set; }
        [JsonPropertyName("age_restriction")]
        public int AgeRestriction { get; set; }
        [JsonPropertyName("max_checkout_length")]
        public int MaxCheckoutLength { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; } = "Available";

        /// <summary>
        /// Initializes a new instance of the <see cref="Media"/> class.
        /// </summary>
        /// <param name="title">The title of the media.</param>
        /// <param name="language">The language of the media.</param>
        /// <param name="genre">The genre of the media.</param>
        /// <param name="publicationYear">The publication year of the media.</param>
        /// <param name="ageRestriction">The age restriction for the media.</param>
        public Media(string title, string language, Genre genre, int publicationYear, int ageRestriction)
        {
            Title = title;
            Language = language;
            Genre = genre;
            PublicationYear = publicationYear;
            AgeRestriction = ageRestriction;
            Id = count++;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Media"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the media.</param>
        /// <param name="title">The title of the media.</param>
        /// <param name="language">The language of the media.</param>
        /// <param name="genre">The genre of the media.</param>
        /// <param name="publicationYear">The publication year of the media.</param>
        /// <param name="ageRestriction">The age restriction for the media.</param>
        /// <param name="status">The current status of the media.</param>
        /// <param name="maxCheckoutLength">The maximum checkout length in days for the media.</param>
        public Media(int id, string title, string language, Genre genre, int publicationYear, int ageRestriction, string status, int maxCheckoutLength)
        {
            Id = id;
            Title = title;
            Language = language;
            Genre = genre;
            PublicationYear = publicationYear;
            AgeRestriction = ageRestriction;
            Status = status;
            MaxCheckoutLength = maxCheckoutLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Media"/> class.
        /// This constructor is required for deserialization.
        /// </summary>
        public Media() { }

        /// <summary>
        /// Calculates the return date for the borrowed media based on its checkout length.
        /// </summary>
        /// <returns>The return date as a <see cref="DateTime"/> object.</returns>
        public DateTime CalculateReturnDate()
        {
            return DateTime.Now.AddDays(MaxCheckoutLength);
        }

        /// <summary>
        /// Returns a string representation of the media's details in English.
        /// </summary>
        /// <returns>A string containing the media's title, language, genre, year, and status.</returns>
        public override string ToString()
        {
            return $"Title:\t\t{Title}\nLanguage:\t{Language}\nGenre:\t\t{Genre.ToString()}" +
                $"\nYear:\t\t{PublicationYear}\nStatus:\t\t{Status}\n";
        }

        /// <summary>
        /// Returns a string representation of the media's details in French.
        /// </summary>
        /// <returns>A string containing the media's title, language, genre, year, and status in French.</returns>
        public virtual string ToStringFR()
        {
            return $"Titre:\t\t{Title}\nLangue:\t\t{Language}\nGenre:\t\t{Genre.ToString()}" +
                $"\nAnnée:\t\t{PublicationYear}\nStatut:\t\t{Status}\n";
        }

        /// <summary>
        /// Gets the media's information formatted based on the language.
        /// </summary>
        /// <returns>A string with the media details in English or French.</returns>
        public abstract string GetMediaInfo();

        /// <summary>
        /// Checks out the media, marking it as no longer available.
        /// </summary>
        public abstract void Checkout();

        /// <summary>
        /// Returns the media, marking it as available again.
        /// </summary>
        public abstract void ReturnItem();

        /// <summary>
        /// Renews the loan for the media.
        /// </summary>
        public abstract void RenewLoan();

        /// <summary>
        /// Applies a late fee for the media.
        /// </summary>
        public abstract void GiveLateFee();
    }

}
