using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project
{
    public class AudiobookAdapter : IMediaAdapter 
    {

        private readonly Audiobook audiobook;

        public AudiobookAdapter(Audiobook audiobook)
        {
            this.audiobook = audiobook;
        }

        public string GetTitle()
        {
            return audiobook.Title;
        }

        public string GetLanguage()
        {
            return audiobook.Language;
        }

        public Genre GetGenre()
        {
            return audiobook.Genre;
        }

        public int GetPublicationYear()
        {
            return audiobook.PublicationYear;
        }

        public int GetAgeRestriction()
        {
            return audiobook.AgeRestriction;
        }

        public int GetMaxCheckoutLength()
        {
            return audiobook.MaxCheckoutLength;
        }

        public string GetMediaInfo()
        {
            return $"Audiobook ISBN: {audiobook.ISBN}, Narrator: {audiobook.Narrator}, Duration: {audiobook.Duration} mins";
        }

        public string GetISBN()
        {
            return audiobook.ISBN;
        }

        public string GetAuthor()
        {
            return audiobook.Author;
        }

        public string GetPublisher()
        {
            return audiobook.Publisher;
        }

        public string GetNarrator()
        {
            return audiobook.Narrator;
        }

        public int GetEdition()
        {
            return audiobook.Edition;
        }

        public int GetDuration()
        {
            return audiobook.Duration;
        }
    }
}
