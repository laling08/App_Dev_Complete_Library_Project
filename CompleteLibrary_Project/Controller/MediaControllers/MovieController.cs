using CompleteLibrary_Project.Model.Interfaces;
using CompleteLibrary_Project.Model.Medias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Controller.MediaControllers
{
    /// <summary>
    /// Controller for managing movie operations
    /// </summary>
    public class MovieController : IMediaController
    {
        /// <summary>
        /// Attempts to cast a media object to a <see cref="Movie"/>.
        /// </summary>
        /// <param name="media">The media item to cast.</param>
        /// <returns>The <see cref="Movie"/> instance, or <c>null</c> if the cast fails.</returns>
        private Movie? GetMovie(Media media)
        {
            return media as Movie;
        }

        /// <summary>
        /// Checks out a movie.
        /// </summary>
        /// <param name="media">The movie to check out.</param>
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

        /// <summary>
        /// Returns a movie.
        /// </summary>
        /// <param name="media">The movie to return.</param>
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

        /// <summary>
        /// Renews the loan of a movie.
        /// </summary>
        /// <param name="media">The movie to renew.</param>
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

        /// <summary>
        /// Applies a late fee to a movie.
        /// </summary>
        /// <param name="media">The movie to apply the late fee to.</param>
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

        /// <summary>
        /// Gets information about a movie.
        /// </summary>
        /// <param name="media">The movie to get information about.</param>
        /// <returns>A string containing the movie's information, or an error message if the media is invalid.</returns>
        public string GetMediaInfo(Media media)
        {
            var movie = GetMovie(media);
            return movie != null ? movie.GetMediaInfo() : "Invalid media type.";
        }
    }
}
