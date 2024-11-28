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
    /// Model for Book Class.
    /// </summary>
    public class Book : Media
    {
        [JsonPropertyName("isbn")]
        public string ISBN { get; set; }
        [JsonPropertyName("author")]
        public string Author { get; set; }
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }
        [JsonPropertyName("illustrator")]
        public string Illustrator { get; set; }
        [JsonPropertyName("edition")]
        public int Edition { get; set; }

        public Book(string title, string language, Genre genre, int publicationYear, int ageRestriction,
                    string isbn, string author, string publisher, string illustrator, int edition)
            : base(title, language, genre, publicationYear, ageRestriction)
        {
            ISBN = isbn;
            Author = author;
            Publisher = publisher;
            Illustrator = illustrator;
            Edition = edition;
            MaxCheckoutLength = 21;
        }

        public Book(int id, string title, string language, Genre genre, int publicationYear, int ageRestriction,
                    string isbn, string author, string publisher, string illustrator, int edition)
            : base(title, language, genre, publicationYear, ageRestriction)
        {
            ISBN = isbn;
            Author = author;
            Publisher = publisher;
            Illustrator = illustrator;
            Edition = edition;
            MaxCheckoutLength = 21;
        }

        public Book()
        {
            // empty constructor required for deserialization
        }


        public override string? ToString()
        {
            string baseToString = base.ToString();

            return $"BOOK\n{baseToString}ISBN:\t\t{ISBN}\nAuthor:\t\t{Author}\nPublisher:\t{Publisher}" +
                $"\nIllustrator:\t{Illustrator}\nEdition:\t\t{Edition}\n";
        }

        public override string? ToStringFR()
        {
            string baseToString = base.ToStringFR();

            return $"LIVRE\n{baseToString}ISBN:\t\t{ISBN}\nAuteur(e):\t{Author}\nMaison d'édition:\t{Publisher}" +
                $"\nIllustrateur/trice:\t{Illustrator}\nÉdition:\t\t{Edition}\n";
        }

        /// <summary>
        /// Returns the books's information based on its language.
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
        /// Marks the audiobook as checked out.
        /// </summary>
        public override void Checkout()
        {
            if (Status == "Available")
            {
                Status = "Checked Out";
                Console.WriteLine($"Book '{Title}' check out successfully.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' is not availble for checkout.");
            }
        }

        /// <summary>
        /// Marks the Book as returned.
        /// </summary>
        public override void ReturnItem()
        {
            if (Status == "Checked Out")
            {
                Status = "Available";
                Console.WriteLine($"Book '{Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' is not checked out.");
            }
        }

        /// <summary>
        /// Renews the loan for the Book.
        /// </summary>
        public override void RenewLoan()
        {
            Console.WriteLine($"Loan for Book '{Title}' renewed successfully.");
        }

        /// <summary>
        /// Applies a late fee for the Book.
        /// </summary>
        public override void GiveLateFee()
        {
            Console.WriteLine($"Late fee applied for Book '{Title}'.");
        }
    }
}
