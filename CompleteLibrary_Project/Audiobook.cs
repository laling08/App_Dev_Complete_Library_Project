using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CompleteLibrary_Project
{
    /// <summary>
    /// Model for AudioBook Class.
    /// </summary>
    public class Audiobook : Media
    {
        [JsonPropertyName("isbn")]
        public string ISBN { get; set; }
        [JsonPropertyName("author")]
        public string Author { get; set; }
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }
        [JsonPropertyName("narrator")]
        public string Narrator { get; set; }
        [JsonPropertyName("edition")]
        public int Edition { get; set; }
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        public Audiobook(string title, string language, Genre genre, int publicationYear, int ageRestriction,
                         string isbn, string author, string publisher, string narrator, int edition, int duration)
            : base(title, language, genre, publicationYear, ageRestriction)
        {
            ISBN = isbn;
            Author = author;
            Publisher = publisher;
            Narrator = narrator;
            Edition = edition;
            Duration = duration;
            MaxCheckoutLength = 14;
        }

        public override void Checkout() { }

        public override void ReturnItem() { }

        public override void RenewLoan() { }

        public override void GiveLateFee() { }

        public override string? ToString()
        {
            string baseToString = base.ToString();

            return $"AUDIOBOOK\n{baseToString}ISBN:\t\t{ISBN}\nAuthor:\t\t{Author}\nPublisher:\t{Publisher}" +
                $"\nNarrator:\t\t{Narrator}\nEdition:\t\t{Edition}\nDuration:\t{Duration}";
        }

        public override string? ToStringFR()
        {
            string baseToString = base.ToStringFR();

            return $"LIVREAUDIO\n{baseToString}ISBN:\t\t{ISBN}\nAuteur(e):\t\t{Author}\nMaison d'édition:\t{Publisher}" +
                $"\nNarrateur(e):\t{Narrator}\nÉdition:\t\t{Edition}\nLongueur:\t\t{Duration}";
        }
    }
}
