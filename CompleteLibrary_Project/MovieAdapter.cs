using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project
{
    public class MovieAdapter : IMediaAdapter
    {
        private readonly Movie movie;

        public MovieAdapter(Movie movie)
        {
            this.movie = movie;
        }

        public string GetTitle()
        {
            return movie.Title;
        }

        public string GetLanguage()
        {
            return movie.Language;
        }

        public Genre GetGenre()
        {
            return movie.Genre;
        }

        public int GetPublicationYear()
        {
            return movie.PublicationYear;
        }

        public int GetAgeRestriction()
        {
            return movie.AgeRestriction;
        }

        public int GetMaxCheckoutLength()
        {
            return movie.MaxCheckoutLength;
        }

        public string GetMediaInfo()
        {
            return $"Movie Director: {movie.Director}, Duration: {movie.Duration} mins";
        }

        public string GetDirector()
        {
            return movie.Director;
        }

        public int GetDuration()
        {
            return movie.Duration;
        }
    }
}
