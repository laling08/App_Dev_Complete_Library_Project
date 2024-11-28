using CompleteLibrary_Project.Model.Interfaces;
using CompleteLibrary_Project.Model.Medias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Controller
{
    /// <summary>
    /// Controller for managing movie operations
    /// </summary>
    public class MovieController : IMediaController
    {
        /// <summary>
        /// Attempts to cast a media object to a movie.
        /// </summary>
        /// <param name="media">The media item to cast.</param>
        /// <returns>The movie instance, or null if the cast fails.</returns>
        private Movie? GetMovie(Media media)
        {
            return media as Movie;
        }

        public void Checkout(Media media)
        {
            var movie = GetMovie(media);
            if (movie != null)
            {
                movie.Checkout();
                Console.WriteLine($"Movie '{movie.Title}' checked out successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        public void ReturnItem(Media media)
        {
            var movie = GetMovie(media);
            if (movie != null)
            {
                movie.ReturnItem();
                Console.WriteLine($"Movie '{movie.Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        public void RenewLoan(Media media)
        {
            var movie = GetMovie(media);
            if (movie != null)
            {
                movie.RenewLoan();
                Console.WriteLine($"Loan for movie '{movie.Title}' renewed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        public void ApplyLateFee(Media media)
        {
            var movie = GetMovie(media);
            if (movie != null)
            {
                movie.GiveLateFee();
                Console.WriteLine($"Late fee applied for movie '{movie.Title}'.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        public string GetMediaInfo(Media media)
        {
            var movie = GetMovie(media);
            return movie != null ? movie.GetMediaInfo() : "Invalid media type.";
        }
    }
}
