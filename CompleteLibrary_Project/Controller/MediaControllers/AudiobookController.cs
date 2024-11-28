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
    /// Controller for managing audiobook operations.
    /// </summary>
    public class AudiobookController : IMediaController
    {
        /// <summary>
        /// Attempts to cast a medio object to an audiobook
        /// </summary>
        /// <param name="media">The media item to cast</param>
        /// <returns>The audiobook instance, or null if cast fails.</returns>
        private Audiobook? GetAudiobook(Media media)
        {
            return media as Audiobook;
        }

        /// <summary>
        /// Checks out the specified audiobook
        /// </summary>
        /// <param name="media">The audiobook to checkout.</param>
        public void Checkout(Media media)
        {
            var audiobook = GetAudiobook(media);
            if (audiobook != null)
            {
                audiobook.Checkout();
                Console.WriteLine($"Audiobook '{audiobook.Title}' checked out successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        /// <summary>
        /// Returns the specified audiobook
        /// </summary>
        /// <param name="media">The audiobook to return</param>
        public void ReturnItem(Media media)
        {
            var audiobook = GetAudiobook(media);
            if (audiobook != null)
            {
                audiobook.ReturnItem();
                Console.WriteLine($"Audiobook '{audiobook.Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        /// <summary>
        /// Renews the loan for the specified audiobook.
        /// </summary>
        /// <param name="media">The audiobook to renew.</param>
        public void RenewLoan(Media media)
        {
            var audiobook = GetAudiobook(media);
            if (audiobook != null)
            {
                audiobook.RenewLoan();
                Console.WriteLine($"Audiobook '{audiobook.Title}' renewed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        /// <summary>
        /// Applies a late fee to the specified audiobook.
        /// </summary>
        /// <param name="media">The audiobook to penalize.</param>
        public void ApplyLateFee(Media media)
        {
            var audiobook = GetAudiobook(media);
            if (audiobook != null)
            {
                audiobook.GiveLateFee();
                Console.WriteLine($"Late fee applied for audiobook '{audiobook.Title}'.");
            }
            else
            {
                Console.WriteLine("Invalid media type.");
            }
        }

        /// <summary>
        /// Gets information about the specifies audiobook.
        /// </summary>
        /// <param name="media">The audiobook to retrieve information for.</param>
        /// <returns>A string containing the audiobooks's information, or an error message.</returns>
        public string GetMediaInfo(Media media)
        {
            var audiobook = GetAudiobook(media);
            return audiobook != null ? audiobook.GetMediaInfo() : "Invalid media type.";
        }
    }

}
