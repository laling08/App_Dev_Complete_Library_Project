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

        public override void Checkout() { }

        public override void ReturnItem() { }

        public override void RenewLoan() { }

        public override void GiveLateFee() { }

        public override int GetAgeRestriction()
        {
            throw new NotImplementedException();
        }

        public override Genre GetGenre()
        {
            throw new NotImplementedException();
        }

        public override string GetLanguage()
        {
            throw new NotImplementedException();
        }

        public override int GetMaxCheckoutLength()
        {
            throw new NotImplementedException();
        }

        public override string GetMediaInfo()
        {
            throw new NotImplementedException();
        }

        public override int GetPublicationYear()
        {
            throw new NotImplementedException();
        }

        public override string GetTitle()
        {
            throw new NotImplementedException();
        }
    }
}
