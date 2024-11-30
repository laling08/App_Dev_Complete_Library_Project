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
    /// Model for Magazine Class.
    /// </summary>
    public class Magazine : Media
    {
        [JsonPropertyName("issn")]
        public string ISSN { get; set; }
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }
        [JsonPropertyName("publication_month")]
        public string PublicationMonth { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Magazine"/> class with specific values.
        /// </summary>
        /// <param name="title">The title of the magazine.</param>
        /// <param name="language">The language of the magazine.</param>
        /// <param name="genre">The genre of the magazine.</param>
        /// <param name="publicationYear">The publication year of the magazine.</param>
        /// <param name="ageRestriction">The age restriction for the magazine.</param>
        /// <param name="issn">The ISSN of the magazine.</param>
        /// <param name="publisher">The publisher of the magazine.</param>
        /// <param name="publicationMonth">The publication month of the magazine.</param>
        public Magazine(string title, string language, Genre genre, int publicationYear, int ageRestriction,
                        string issn, string publisher, string publicationMonth)
            : base(title, language, genre, publicationYear, ageRestriction)
        {
            ISSN = issn;
            Publisher = publisher;
            PublicationMonth = publicationMonth;
            MaxCheckoutLength = 7;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Magazine"/> class with specific values and status.
        /// </summary>
        /// <param name="id">The ID of the magazine.</param>
        /// <param name="title">The title of the magazine.</param>
        /// <param name="language">The language of the magazine.</param>
        /// <param name="genre">The genre of the magazine.</param>
        /// <param name="publicationYear">The publication year of the magazine.</param>
        /// <param name="ageRestriction">The age restriction for the magazine.</param>
        /// <param name="issn">The ISSN of the magazine.</param>
        /// <param name="publisher">The publisher of the magazine.</param>
        /// <param name="publicationMonth">The publication month of the magazine.</param>
        /// <param name="status">The status of the magazine (e.g., Available, Checked Out).</param>
        /// <param name="maxCheckoutLength">The maximum checkout length of the magazine.</param>
        public Magazine(int id, string title, string language, Genre genre, int publicationYear, int ageRestriction,
                        string issn, string publisher, string publicationMonth, string status, int maxCheckoutLength = 7)
            : base(id, title, language, genre, publicationYear, ageRestriction, status, maxCheckoutLength)
        {
            ISSN = issn;
            Publisher = publisher;
            PublicationMonth = publicationMonth;
            MaxCheckoutLength = maxCheckoutLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Magazine"/> class (required for deserialization).
        /// </summary>
        public Magazine()
        {
            // Empty constructor required for deserialization
        }

        /// <summary>
        /// Returns a string representation of the magazine's information in English.
        /// </summary>
        /// <returns>A formatted string containing the magazine's details.</returns>
        public override string? ToString()
        {
            return $"MAGAZINE\n{base.ToString()}ISSN:\t\t{ISSN}\nPublisher:\t{Publisher}\nMonth:\t\t{PublicationMonth}";
        }

        /// <summary>
        /// Returns a string representation of the magazine's information in French.
        /// </summary>
        /// <returns>A formatted string containing the magazine's details in French.</returns>
        public override string? ToStringFR()
        {
            return $"MAGAZINE\n{base.ToString()}ISSN:\t\t{ISSN}\nMaison d'édition:\t{Publisher}\nMois:\t\t{PublicationMonth}\n";
        }

        /// <summary>
        /// Returns the magazine's information based on its language (either in English or French).
        /// </summary>
        /// <returns>The formatted details in either English or French based on the language of the magazine.</returns>
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
        /// Marks the magazine as checked out, changing its status to "Checked Out".
        /// </summary>
        public override void Checkout()
        {
            if (Status == "Available")
            {
                Status = "Checked Out";
                Console.WriteLine($"Magazine '{Title}' checked out successfully.");
            }
            else
            {
                Console.WriteLine($"Magazine '{Title}' is not available for checkout.");
            }
        }

        /// <summary>
        /// Marks the magazine as returned, changing its status to "Available".
        /// </summary>
        public override void ReturnItem()
        {
            if (Status == "Checked Out")
            {
                Status = "Available";
                Console.WriteLine($"Magazine '{Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine($"Magazine '{Title}' is not checked out.");
            }
        }

        /// <summary>
        /// Renews the loan for the magazine.
        /// </summary>
        public override void RenewLoan()
        {
            Console.WriteLine($"Loan for Magazine '{Title}' renewed successfully.");
        }

        /// <summary>
        /// Applies a late fee for the magazine if it is returned late.
        /// </summary>
        public override void GiveLateFee()
        {
            Console.WriteLine($"Late fee applied for Magazine '{Title}'.");
        }
    }
}
