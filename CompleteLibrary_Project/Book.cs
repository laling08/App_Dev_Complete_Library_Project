using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CompleteLibrary_Project
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

        public override void Checkout() { }

        public override void ReturnItem() { }

        public override void RenewLoan() { }

        public override void GiveLateFee() { }

        public override string? ToString()
        {
            string baseToString = base.ToString();

            return $"BOOK\n{baseToString}ISBN:\t\t{ISBN}\nAuthor:\t\t{Author}\nPublisher:\t{Publisher}" +
                $"\nIllustrator:\t{Illustrator}\nEdition:\t\t{Edition}";
        }

        public override string? ToStringFR()
        {
            string baseToString = base.ToStringFR();

            return $"LIVRE\n{baseToString}ISBN:\t\t{ISBN}\nAuteur(e):\t\t{Author}\nMaison d'édition:\t{Publisher}" +
                $"\nIllustrateur/trice:\t{Illustrator}\nÉdition:\t\t{Edition}";
        }
    }
}
