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

        public Magazine(string title, string language, Genre genre, int publicationYear, int ageRestriction,
                        string issn, string publisher, string publicationMonth)
            : base(title, language, genre, publicationYear, ageRestriction)
        {
            ISSN = issn;
            Publisher = publisher;
            PublicationMonth = publicationMonth;
            MaxCheckoutLength = 7;
        }

        public Magazine(int id, string title, string language, Genre genre, int publicationYear, int ageRestriction,
                        string issn, string publisher, string publicationMonth, string status)
            : base(id, title, language, genre, publicationYear, ageRestriction, status)
        {
            ISSN = issn;
            Publisher = publisher;
            PublicationMonth = publicationMonth;
            MaxCheckoutLength = 7;
        }

        public Magazine()
        {
            // empty constructor required for deserialization
        }


        public override string? ToString()
        {
            return $"MAGAZINE\n{base.ToString()}ISSN:\t\t{ISSN}\nPublisher:\t{Publisher}\nYear:\t\t{PublicationYear}";
        }

        public override string? ToStringFR()
        {
            return $"MAGAZINE\n{base.ToString()}ISSN:\t\t{ISSN}\nMaison d'édition:\t{Publisher}\nAnnée:\t\t{PublicationYear}\n"; ;
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
        /// Marks the Magazine as returned.
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
        /// Renews the loan for the Magazine.
        /// </summary>
        public override void RenewLoan()
        {
            Console.WriteLine($"Loan for Magazine '{Title}' renewed successfully.");
        }

        /// <summary>
        /// Applies a late fee for the Magazine.
        /// </summary>
        public override void GiveLateFee()
        {
            Console.WriteLine($"Late fee applied for Magazine '{Title}'.");
        }
    }
}
