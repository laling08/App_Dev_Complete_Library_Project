using CompleteLibrary_Project.Model.Medias;
using CompleteLibrary_Project.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Controller
{
    /// <summary>
    /// Controller for managing librarian operations.
    /// </summary>
    public class LibrarianController
    {
        private readonly Librarian _librarian;
        private readonly List<Media> _mediaCollection; // Simulating a library's media collection
        private readonly List<User> _members;         // Simulating a list of library members
        private readonly List<Loan> _loanRecords;    // Simulating loan records

        /// <summary>
        /// Initializes a new instance of the LibrarianController class.
        /// </summary>
        /// <param name="librarian">The librarian to manage.</param>
        /// <param name="mediaCollection">The library's media collection.</param>
        /// <param name="members">The list of library members.</param>
        /// <param name="loanRecords">The loan records of the library.</param>
        public LibrarianController(Librarian librarian, List<Media> mediaCollection, List<User> members, List<Loan> loanRecords)
        {
            _librarian = librarian;
            _mediaCollection = mediaCollection;
            _members = members;
            _loanRecords = loanRecords;
        }

        /// <summary>
        /// Views the history of a specific member.
        /// </summary>
        /// <param name="member">The member whose history is to be viewed.</param>
        public void ViewMemberHistory(User member)
        {
            if (member == null) throw new ArgumentNullException(nameof(member));

            var memberLoans = _loanRecords.Where(loan => loan.UserId == member.Id).ToList();
            if (!memberLoans.Any())
            {
                Console.WriteLine($"No loan history found for member {member.FName} {member.LName}.");
                return;
            }

            Console.WriteLine($"Loan history for member {member.FName} {member.LName}:");
            foreach (var loan in memberLoans)
            {
                Console.WriteLine($"- Title: {loan.Title}, Checkout Date: {loan.CheckoutDate}, Expected Return: {loan.ExpectedReturnDate}");
            }
        }

        /// <summary>
        /// Views the report for a specific media item.
        /// </summary>
        /// <param name="media">The media to generate a report for.</param>
        /// <returns>The loan report for the media.</returns>
        public void ViewReport(Media media)
        {
            if (media == null) throw new ArgumentNullException(nameof(media));

            var loan = _loanRecords.FirstOrDefault(l => l.MediaId == media.GetHashCode());
            if (loan == null)
            {
                Console.WriteLine($"No loan report found for media: {media.Title}.");
                return;
            }

            Console.WriteLine($"Loan report for media '{loan.Title}':");
            Console.WriteLine($"- Borrower ID: {loan.UserId}");
            Console.WriteLine($"- Checkout Date: {loan.CheckoutDate}");
            Console.WriteLine($"- Expected Return Date: {loan.ExpectedReturnDate}");
        }

        /// <summary>
        /// Adds a new media item to the library's collection.
        /// </summary>
        /// <param name="media">The media to add.</param>
        /// <returns>True if the media was successfully added; otherwise, false.</returns>
        public bool AddMedia(Media media)
        {
            if (media == null) throw new ArgumentNullException(nameof(media));

            _mediaCollection.Add(media);
            Console.WriteLine($"Media '{media.Title}' added successfully.");
            return true;
        }

        /// <summary>
        /// Modifies the details of an existing media item.
        /// </summary>
        /// <param name="media">The media whose details are to be modified.</param>
        /// <returns>True if the media details were successfully modified; otherwise, false.</returns>
        public bool ModifyMediaDetails(Media media)
        {
            if (media == null) throw new ArgumentNullException(nameof(media));

            var existingMedia = _mediaCollection.FirstOrDefault(m => m.Id == media.Id);
            if (existingMedia == null)
            {
                Console.WriteLine("Media not found in the library collection.");
                return false;
            }

            existingMedia.Title = media.Title;
            existingMedia.Language = media.Language;
            existingMedia.Genre = media.Genre;
            existingMedia.PublicationYear = media.PublicationYear;
            existingMedia.AgeRestriction = media.AgeRestriction;
            existingMedia.Status = media.Status;

            Console.WriteLine($"Media '{media.Title}' details updated successfully.");
            return true;
        }

        /// <summary>
        /// Removes a media item from the library's collection.
        /// </summary>
        /// <param name="media">The media to remove.</param>
        /// <returns>True if the media was successfully removed; otherwise, false.</returns>
        public bool RemoveMedia(Media media)
        {
            if (media == null) throw new ArgumentNullException(nameof(media));

            var removed = _mediaCollection.Remove(media);
            Console.WriteLine(removed
                ? $"Media '{media.Title}' removed successfully."
                : "Failed to remove media. It might not exist in the collection.");

            return removed;
        }

        /// <summary>
        /// Issues a media item to a member.
        /// </summary>
        /// <param name="media">The media to issue.</param>
        /// <param name="member">The member to issue the media to.</param>
        /// <returns>True if the media was successfully issued; otherwise, false.</returns>
        public bool IssueMedia(Media media, User member)
        {
            if (media == null) throw new ArgumentNullException(nameof(media));
            if (member == null) throw new ArgumentNullException(nameof(member));

            if (media.Status != "Available")
            {
                Console.WriteLine($"Media '{media.Title}' is currently unavailable.");
                return false;
            }

            var loan = new Loan(media, member.Id);
            _loanRecords.Add(loan);
            media.Status = "Checked Out";
            Console.WriteLine($"Media '{media.Title}' issued to member '{member.FName} {member.LName}'.");
            return true;
        }
    }
}
