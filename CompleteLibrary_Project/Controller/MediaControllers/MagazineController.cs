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
    /// Controller for managing magazine operations
    /// </summary>
    public class MagazineController : IMediaController
    {
        /// <summary>
        /// Attempts to cast a media object to a magazine.
        /// </summary>
        /// <param name="media">The media item to cast.</param>
        /// <returns>The magazine instance, or null if the cast fails.</returns>
        private Magazine? GetMagazine(Media media)
        {
            return media as Magazine;
        }

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

        public string GetMediaInfo(Media media)
        {
            var magazine = GetMagazine(media);
            return magazine != null ? magazine.GetMediaInfo() : "Invalid media type.";
        }
    }
}
