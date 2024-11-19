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

        public override void Checkout() { }

        public override void ReturnItem() { }

        public override void RenewLoan() { }

        public override void GiveLateFee() { }

        public override string? ToString()
        {
            return $"MAGAZINE\n{base.ToString()}ISSN:\t\t{ISSN}\nPublisher:\t{Publisher}\nYear:\t\t{PublicationYear}";
        }

        public override string? ToStringFR()
        {
            return $"MAGAZINE\n{base.ToString()}ISSN:\t\t{ISSN}\nMaison d'édition:\t{Publisher}\nAnnée:\t\t{PublicationYear}"; ;
        }

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
