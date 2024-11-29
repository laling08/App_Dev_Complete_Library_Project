using CompleteLibrary_Project.Controller.DataAccessibility;
using CompleteLibrary_Project.Model.Exceptions;
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

        /// <summary>
        /// Initializes a new instance of the UserController class.
        /// </summary>
        /// <param name="user">The user to manage.</param>
        /// <param name="mediaCollection">The library's media collection.</param>
        /// <param name="loanRecords">The loan records of the library.</param>
        public UserController(User user)
        {
            _user = user;
        }

        /// <summary>
        /// Allows a user to return a media item.
        /// </summary>
        /// <param name="media">The media to return.</param>
        /// <returns>True if the media was successfully returned; otherwise, false.</returns>
        public bool ReturnMedia(Media media)
        {
            _user.CurrentCheckouts.Remove(media.Id);
            List<User> users = DataAccess.LoadAllUsers();

            if (media.Status.Equals("Checkout Out"))
            {
                switch (media.GetType().Name)
                {
                    case "CompleteLibrary_Project.Model.Medias.Book":
                        DataAccess.UpdateBookStatus(media.Id, "Available");
                        break;
                    case "CompleteLibrary_Project.Model.Medias.Movie":
                        DataAccess.UpdateMovieStatus(media.Id, "Available");
                        break;
                    case "CompleteLibrary_Project.Model.Medias.Audiobook":
                        DataAccess.UpdateAudiobookStatus(media.Id, "Available");
                        break;
                    case "CompleteLibrary_Project.Model.Medias.Magazine":
                        DataAccess.UpdateMagazineStatus(media.Id, "Available");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                // check how many people have reserved this item
                int holdCount = 0;
                foreach (User user in users)
                {
                    if (user.CurrentHolds.ContainsKey(media.Id))
                    {
                        holdCount++;
                    }
                }

                // If the items remains on hold in addition to being checked out,
                // set the media's status to "Checked Out and Reserved"
                if (holdCount > 1)
                {
                    switch (media.GetType().Name)
                    {
                        case "CompleteLibrary_Project.Model.Medias.Book":
                            DataAccess.UpdateBookStatus(media.Id, "Checked Out and Reserved");
                            break;
                        case "CompleteLibrary_Project.Model.Medias.Movie":
                            DataAccess.UpdateMovieStatus(media.Id, "Checked Out and Reserved");
                            break;
                        case "CompleteLibrary_Project.Model.Medias.Audiobook":
                            DataAccess.UpdateAudiobookStatus(media.Id, "Checked Out and Reserved");
                            break;
                        case "CompleteLibrary_Project.Model.Medias.Magazine":
                            DataAccess.UpdateMagazineStatus(media.Id, "Checked Out and Reserved");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (media.GetType().Name)
                    {
                        case "CompleteLibrary_Project.Model.Medias.Book":
                            DataAccess.UpdateBookStatus(media.Id, "Reserved");
                            break;
                        case "CompleteLibrary_Project.Model.Medias.Movie":
                            DataAccess.UpdateMovieStatus(media.Id, "Reserved");
                            break;
                        case "CompleteLibrary_Project.Model.Medias.Audiobook":
                            DataAccess.UpdateAudiobookStatus(media.Id, "Reserved");
                            break;
                        case "CompleteLibrary_Project.Model.Medias.Magazine":
                            DataAccess.UpdateMagazineStatus(media.Id, "Reserved");
                            break;
                        default:
                            break;
                    }
                }
            }

            DataAccess.RemoveLoanFromFile(_user.Id, media.Id);

            return true;
        }

        /// <summary>
        /// Helper class used in order to find the person who reserved a
        /// piece of media first, so that they get first dibbs at checking
        /// it out
        /// </summary>
        /// <param name="users">the list of users with information on their holds</param>
        /// <param name="mediaId">the id of the media to find holds</param>
        /// <returns></returns>
        private static User FindFirstReserver(List<User> users, int mediaId)
        {
            User first = null;
            DateTime earliestDate = DateTime.MaxValue;

            foreach (User user in users)
            {
                if (user.CurrentHolds.ContainsKey(mediaId))
                {
                    if (earliestDate > user.CurrentHolds[mediaId])
                    {
                        earliestDate = user.CurrentHolds[mediaId];
                        first = user;
                    }
                }
            }

            return first;
        }

        /// <summary>
        /// Allows a user to place a hold on a media item.
        /// </summary>
        /// <param name="media">The media to place on hold.</param>
        /// <returns>True if the hold was successfully placed; otherwise, false.</returns>
        public bool PlaceHold(Media media)
        {
            List<User> users = DataAccess.LoadAllUsers();

            if (((DateTime.Now - _user.Dob).TotalDays / 365.25) < media.AgeRestriction)
            {
                throw new TooYoungException("Sorry! You are too young to check out this item.");
            }
            else if (!media.Status.Equals("Available"))
            {
                try
                {
                    _user.CurrentHolds.Add(media.Id, DateTime.Now);
                } catch (ArgumentException ex)
                {
                    // the user already has this item on hold
                    return false;
                }

                // update status depending on media type
                switch (media.GetType().Name)
                {
                    case "CompleteLibrary_Project.Model.Medias.Book":
                        DataAccess.UpdateBookStatus(media.Id, "Checked Out and Reserved");
                        break;
                    case "CompleteLibrary_Project.Model.Medias.Movie":
                        DataAccess.UpdateMovieStatus(media.Id, "Checked Out and Reserved");
                        break;
                    case "CompleteLibrary_Project.Model.Medias.Audiobook":
                        DataAccess.UpdateAudiobookStatus(media.Id, "Checked Out and Reserved");
                        break;
                    case "CompleteLibrary_Project.Model.Medias.Magazine":
                        DataAccess.UpdateMagazineStatus(media.Id, "Checked Out and Reserved");
                        break;
                    default:
                        break;
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Checkouts an item for a user by adding it to their CurrentCheckouts,
        /// changing the item's status, and adding a loan to the loan file
        /// </summary>
        /// <param name="media">item they are checking out</param>
        /// <returns>whether the checkout was successful</returns>
        /// <exception cref="TooYoungException">A user cannot checkout out some items if they are too young</exception>
        public bool Checkout(Media media)
        {
            if (!media.Status.Equals("Available"))
            {
                return false;
            }
            else if (((DateTime.Now - _user.Dob).TotalDays / 365.25) < media.AgeRestriction)
            {
                throw new TooYoungException("Sorry! You are too young to check out this item.");
            }

            _user.CurrentCheckouts.Add(media.Id);
            switch (media.GetType().Name)
            {
                case "CompleteLibrary_Project.Model.Medias.Book":
                    DataAccess.UpdateBookStatus(media.Id, "Checked Out");
                    break;
                case "CompleteLibrary_Project.Model.Medias.Movie":
                    DataAccess.UpdateMovieStatus(media.Id, "Checked Out");
                    break;
                case "CompleteLibrary_Project.Model.Medias.Audiobook":
                    DataAccess.UpdateAudiobookStatus(media.Id, "Checked Out");
                    break;
                case "CompleteLibrary_Project.Model.Medias.Magazine":
                    DataAccess.UpdateMagazineStatus(media.Id, "Checked Out");
                    break;
                default:
                    break;
            }

            Loan loan = new Loan(media,_user.Id);
            DataAccess.SaveLoanToFile(loan);

            return true;
        }
    }
}
