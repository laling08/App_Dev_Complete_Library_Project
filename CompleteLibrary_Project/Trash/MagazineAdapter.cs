using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompleteLibrary_Project.Model.Enums;
using CompleteLibrary_Project.Model.Interfaces;
using CompleteLibrary_Project.Model.Medias;

namespace CompleteLibrary_Project.Trash
{
    public class MagazineAdapter : IMediaAdapter
    {
        private readonly Magazine magazine;

        public MagazineAdapter(Magazine magazine)
        {
            this.magazine = magazine;
        }

        public string GetTitle()
        {
            return magazine.Title;
        }

        public string GetLanguage()
        {
            return magazine.Language;
        }

        public Genre GetGenre()
        {
            return magazine.Genre;
        }

        public int GetPublicationYear()
        {
            return magazine.PublicationYear;
        }

        public int GetAgeRestriction()
        {
            return magazine.AgeRestriction;
        }

        public int GetMaxCheckoutLength()
        {
            return magazine.MaxCheckoutLength;
        }

        public string GetMediaInfo()
        {
            return $"Magazine ISSN: {magazine.ISSN}, Publisher: {magazine.Publisher}";
        }

        public string GetISSN()
        {
            return magazine.ISSN;
        }

        public string GetPublisher()
        {
            return magazine.Publisher;
        }

        public string GetPublicationMonth()
        {
            return magazine.PublicationMonth;
        }
    }
}
