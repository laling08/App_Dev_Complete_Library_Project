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
    /// Controller for managing magazine operations.
    /// </summary>
    public class MagazineController : IMediaController
    {
        /// <summary>
        /// Attempts to cast a media object to a <see cref="Magazine"/>.
        /// </summary>
        /// <param name="media">The media item to cast.</param>
        /// <returns>The <see cref="Magazine"/> instance, or <c>null</c> if the cast fails.</returns>
        private Magazine? GetMagazine(Media media)
        {
            return media as Magazine;
        }

        /// <summary>
        /// Checks out a magazine.
        /// </summary>
        /// <param name="media">The magazine to check out.</param>
        public void Checkout(Media media)
        {
            var magazine = GetMagazine(media);
            if (magazine != null)
            {
                magazine.Checkout();
                Console.WriteLine($"Magazine '{magazine.Title}' checked out successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        /// <summary>
        /// Returns a magazine.
        /// </summary>
        /// <param name="media">The magazine to return.</param>
        public void ReturnItem(Media media)
        {
            var magazine = GetMagazine(media);
            if (magazine != null)
            {
                magazine.ReturnItem();
                Console.WriteLine($"Magazine '{magazine.Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        /// <summary>
        /// Renews the loan of a magazine.
        /// </summary>
        /// <param name="media">The magazine to renew.</param>
        public void RenewLoan(Media media)
        {
            var magazine = GetMagazine(media);
            if (magazine != null)
            {
                magazine.RenewLoan();
                Console.WriteLine($"Loan for magazine '{magazine.Title}' renewed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        /// <summary>
        /// Applies a late fee to a magazine.
        /// </summary>
        /// <param name="media">The magazine to apply the late fee to.</param>
        public void ApplyLateFee(Media media)
        {
            var magazine = GetMagazine(media);
            if (magazine != null)
            {
                magazine.GiveLateFee();
                Console.WriteLine($"Late fee applied for magazine '{magazine.Title}'.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        /// <summary>
        /// Gets information about a magazine.
        /// </summary>
        /// <param name="media">The magazine to get information about.</param>
        /// <returns>A string containing the magazine's information, or an error message if the media is invalid.</returns>
        public string GetMediaInfo(Media media)
        {
            var magazine = GetMagazine(media);
            return magazine != null ? magazine.GetMediaInfo() : "Invalid media type.";
        }
    }
}