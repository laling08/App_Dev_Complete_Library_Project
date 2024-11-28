using CompleteLibrary_Project.Model.Medias;
using CompleteLibrary_Project.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Controller.UserControllers
{
    /// <summary>
    /// Controller for managing user-related operations.
    /// </summary>
    public class UserController
    {
        private readonly User _user;
        private readonly List<Media> _mediaCollection;
        private readonly List<Loan> _loanRecords;

        /// <summary>
        /// Initializes a new instance of the UserController class.
        /// </summary>
        /// <param name="user">The user to manage.</param>
        /// <param name="mediaCollection">The library's media collection.</param>
        /// <param name="loanRecords">The loan records of the library.</param>
        public UserController(User user, List<Media> mediaCollection, List<Loan> loanRecords)
        {
            _user = user;
            _mediaCollection = mediaCollection;
            _loanRecords = loanRecords;
        }

        /// <summary>
        /// Allows a user to return a media item.
        /// </summary>
        /// <param name="media">The media to return.</param>
        /// <returns>True if the media was successfully returned; otherwise, false.</returns>
        public bool ReturnMedia(Media media)
        {
            if (media == null) throw new ArgumentNullException(nameof(media));

            if (!_user.CurrentCheckouts.Contains(media.Id))
            {
                Console.WriteLine($"Media '{media.Title}' is not currently checked out by the user.");
                return false;
            }

            _user.CurrentCheckouts.Remove(media.Id);
            media.Status = "Available";

            var loan = _loanRecords.FirstOrDefault(l => l.MediaId == media.Id && l.UserId == _user.Id);
            if (loan != null)
            {
                _loanRecords.Remove(loan);
            }

            Console.WriteLine($"Media '{media.Title}' returned successfully.");
            return true;
        }

        /// <summary>
        /// Allows a user to place a hold on a media item.
        /// </summary>
        /// <param name="media">The media to place on hold.</param>
        /// <returns>True if the hold was successfully placed; otherwise, false.</returns>
        public bool PlaceHold(Media media)
        {
            if (media == null) throw new ArgumentNullException(nameof(media));

            if (media.Status == "Available")
            {
                Console.WriteLine($"Media '{media.Title}' is available. No need to place a hold.");
                return false;
            }

            if (_user.CurrentHolds.ContainsKey(media.Id))
            {
                Console.WriteLine($"Media '{media.Title}' is already on hold by the user.");
                return false;
            }

            _user.CurrentHolds.Add(media.Id, DateTime.Now);
            Console.WriteLine($"Hold placed successfully for media '{media.Title}'.");
            return true;
        }

        /// <summary>
        /// Searches the media collection by a unique identifier.
        /// </summary>
        /// <param name="identifier">The unique identifier of the media.</param>
        /// <returns>The media item if found; otherwise, null.</returns>
        public Media SearchByIdentifier(string identifier)
        {
            if (string.IsNullOrWhiteSpace(identifier))
            {
                throw new ArgumentException("Identifier cannot be null or empty.", nameof(identifier));
            }

            var media = _mediaCollection.FirstOrDefault(m => m.GetHashCode().ToString() == identifier || m.Title == identifier);
            if (media != null)
            {
                Console.WriteLine($"Media found: {media.Title}");
            }
            else
            {
                Console.WriteLine($"No media found with identifier: {identifier}");
            }
            return media;
        }

        /// <summary>
        /// Allows a user to pay their fees.
        /// </summary>
        /// <param name="amount">The fee amount to pay.</param>
        /// <returns>True if the fee was successfully paid; otherwise, false.</returns>
        public bool PayFee(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount. Payment must be greater than zero.");
                return false;
            }

            Console.WriteLine($"Fee of ${amount} paid successfully by user '{_user.FName} {_user.LName}'.");
            return true;
        }

        /// <summary>
        /// Views the user's personal loan history.
        /// </summary>
        public void ViewPersonalHistory()
        {
            var personalLoans = _loanRecords.Where(l => l.UserId == _user.Id).ToList();
            if (!personalLoans.Any())
            {
                Console.WriteLine("No loan history found for the user.");
                return;
            }

            Console.WriteLine($"Loan history for {_user.FName} {_user.LName}:");
            foreach (var loan in personalLoans)
            {
                Console.WriteLine($"- Media Title: {loan.Title}, Checkout Date: {loan.CheckoutDate}, Expected Return: {loan.ExpectedReturnDate}");
            }
        }
    }
}
