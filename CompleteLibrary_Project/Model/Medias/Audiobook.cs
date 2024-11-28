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

        public Audiobook(int id, string title, string language, Genre genre, int publicationYear, int ageRestriction,
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

        public Audiobook()
        {
            // empty constructor required for deserialization
        }

        public override string? ToString()
        {
            string baseToString = base.ToString();

            return $"AUDIOBOOK\n{baseToString}ISBN:\t\t{ISBN}\nAuthor:\t\t{Author}\nPublisher:\t{Publisher}" +
                $"\nNarrator:\t\t{Narrator}\nEdition:\t\t{Edition}\nDuration:\t{Duration}\n";
        }

        public override string? ToStringFR()
        {
            string baseToString = base.ToStringFR();

            return $"LIVREAUDIO\n{baseToString}ISBN:\t\t{ISBN}\nAuteur(e):\t{Author}\nMaison d'édition:\t{Publisher}" +
                $"\nNarrateur(e):\t{Narrator}\nÉdition:\t\t{Edition}\nLongueur:\t{Duration}\n";
        }

        /// <summary>
        /// Returns the audiobook's information based on its language.
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
                Console.WriteLine($"Audiobook '{Title}' check out successfully.");
            }
            else
            {
                Console.WriteLine($"Audiobook '{Title}' is not availble for checkout.");
            }
        }

        /// <summary>
        /// Marks the audiobook as returned.
        /// </summary>
        public override void ReturnItem()
        {
            if (Status == "Checked Out")
            {
                Status = "Available";
                Console.WriteLine($"Audiobook '{Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine($"Audiobook '{Title}' is not checked out.");
            }
        }

        /// <summary>
        /// Renews the loan for the audiobook.
        /// </summary>
        public override void RenewLoan()
        {
            Console.WriteLine($"Loan for audiobook '{Title}' renewed successfully.");
        }

        /// <summary>
        /// Applies a late fee for the audiobook.
        /// </summary>
        public override void GiveLateFee()
        {
            Console.WriteLine($"Late fee applied for audiobook '{Title}'.");
        }
    }
}
