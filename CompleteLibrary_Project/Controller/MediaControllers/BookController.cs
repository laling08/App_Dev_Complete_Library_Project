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
    /// Controller for managing book operations.
    /// </summary>
    public class BookController : IMediaController
    {
        /// <summary>
        /// Attempts to cast a media object to a book.
        /// </summary>
        /// <param name="media">The media item to cast.</param>
        /// <returns>The book instance, or null if the cast fails.</returns>
        private Book? GetBook(Media media)
        {
            return media as Book;
        }

        /// <summary>
        /// Checks out a book if the provided media is of type <see cref="Book"/>.
        /// </summary>
        /// <param name="media">The media item to check out.</param>
        public void Checkout(Media media)
        {
            var book = GetBook(media);
            if (book != null)
            {
                book.Checkout();
                Console.WriteLine($"Book '{book.Title}' checked out successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        /// <summary>
        /// Returns a book if the provided media is of type <see cref="Book"/>.
        /// </summary>
        /// <param name="media">The media item to return.</param>
        public void ReturnItem(Media media)
        {
            var book = GetBook(media);
            if (book != null)
            {
                book.ReturnItem();
                Console.WriteLine($"Book '{book.Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        /// <summary>
        /// Renews the loan for a book if the provided media is of type <see cref="Book"/>.
        /// </summary>
        /// <param name="media">The media item to renew.</param>
        public void RenewLoan(Media media)
        {
            var book = GetBook(media);
            if (book != null)
            {
                book.RenewLoan();
                Console.WriteLine($"Loan for book '{book.Title}' renewed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }


        /// <summary>
        /// Applies a late fee to a book if the provided media is of type <see cref="Book"/>.
        /// </summary>
        /// <param name="media">The media item to apply the late fee to.</param>
        public void ApplyLateFee(Media media)
        {
            var book = GetBook(media);
            if (book != null)
            {
                book.GiveLateFee();
                Console.WriteLine($"Late fee applied for book '{book.Title}'.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        /// <summary>
        /// Retrieves detailed information about a book if the provided media is of type <see cref="Book"/>.
        /// </summary>
        /// <param name="media">The media item to retrieve information for.</param>
        /// <returns>A string containing detailed information about the book, or an error message if the media type is invalid.</returns>
        public string GetMediaInfo(Media media)
        {
            var book = GetBook(media);
            return book != null ? book.GetMediaInfo() : "Invalid media type.";
        }
    }
}
