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
    /// Model for Movie Class.
    /// </summary>
    public class Movie : Media
    {
        [JsonPropertyName("director")]
        public string Director { get; set; }
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        public Movie(string title, string language, Genre genre, int publicationYear, int ageRestriction,
                     string director, int duration)
            : base(title, language, genre, publicationYear, ageRestriction)
        {
            Director = director;
            Duration = duration;
            MaxCheckoutLength = 7;
        }

        public override void Checkout() { }

        public override void ReturnItem() { }

        public override void RenewLoan() { }

        public override void GiveLateFee() { }

        public override string? ToString()
        {
            string baseToString = base.ToString();

            return $"MOVIE\n{baseToString}Director:\t\t{Director}\nDuration:\t{Duration}";
        }

        public override string? ToStringFR()
        {
            string baseToString = base.ToStringFR();

            return $"FILM\n{baseToString}Réalisateur(trice):\t{Director}\nLongeur:\t\t{Duration}";
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
