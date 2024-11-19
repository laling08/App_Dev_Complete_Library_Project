﻿using System;
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
    /// Model for Media Class.
    /// </summary>
    public abstract class Media : ILoanable, IMediaAdapter
    {
        private static int count = 18;
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
        public int MaxCheckoutLength { get; set; }
        public string Status { get; set; } = "Available";

        public Media(string title, string language, Genre genre, int publicationYear, int ageRestriction)
        {
            Title = title;
            Language = language;
            Genre = genre;
            PublicationYear = publicationYear;
            AgeRestriction = ageRestriction;
            Id = count++;
        }

        public Media(int id, string title, string language, Genre genre, int publicationYear, int ageRestriction)
        {
            Id = id;
            Title = title;
            Language = language;
            Genre = genre;
            PublicationYear = publicationYear;
            AgeRestriction = ageRestriction;
            Status = "Available";
        }

        /// <summary>
        /// Calculates the date by which the borrowed media must be returned.
        /// </summary>
        /// <returns>The return date as <see cref="DateTime"/>.</returns>
        public DateTime CalculateReturnDate()
        {
            return DateTime.Now.AddDays(MaxCheckoutLength);
        }

        public abstract void Checkout();
        public abstract int GetAgeRestriction();
        public abstract Genre GetGenre();
        public abstract string GetLanguage();
        public abstract int GetMaxCheckoutLength();
        public abstract string GetMediaInfo();
        public abstract int GetPublicationYear();
        public abstract string GetTitle();
        public abstract void GiveLateFee();
        public abstract void RenewLoan();
        public abstract void ReturnItem();

        public override string? ToString()
        {
            return $"Title:\t\t{Title}\nLanguage:\t{Language}\nGenre:\t\t{Genre.ToString()}" +
                $"\nYear:\t\t{PublicationYear}\nStatus:\t\t{Status}\n";
        }

        public virtual string? ToStringFR()
        {
            return $"Titre:\t\t{Title}\nLangue:\t\t{Language}\nGenre:\t\t{Genre.ToString()}" +
                $"\nAnnée:\t\t{PublicationYear}\nStatut:\t\t{Status}\n";
        }
    }

}