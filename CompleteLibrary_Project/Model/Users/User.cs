using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CompleteLibrary_Project.Controller.DataAccessibility;
using CompleteLibrary_Project.Model.Enums;
using CompleteLibrary_Project.Model.Exceptions;




// So when we are organizing the classes in folders we just need to add the names space and the name of the folder.
using CompleteLibrary_Project.Model.Medias;

namespace CompleteLibrary_Project.Model.Users
{
    public abstract class User
    {
        [JsonPropertyName("firstName")]
        public string FName { get; set; }
        [JsonPropertyName("lastName")]
        public string LName { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("dateOfBirth")]
        public DateTime Dob { get; set; }
        private static int _count = 15;

        //private Media[] _currentCheckouts;
        //private Media[] _currentHolds;
        [JsonPropertyName("current_checkouts")]
        public List<int> CurrentCheckouts { get; set; }
        [JsonPropertyName("current_holds")]
        public Dictionary<int, DateTime> CurrentHolds { get; set; }

        public User(string fname, string lname, DateTime dob)
        {
            FName = fname;
            LName = lname;
            Dob = dob;
            Id = _count++;
            CurrentCheckouts = new List<int>();
            CurrentHolds = new Dictionary<int, DateTime>();
        }

        [JsonConstructorAttribute]
        public User(int id, string fname, string lname, DateTime dob, List<int> checkouts, Dictionary<int, DateTime> holds)
        {
            Id = id;
            FName = fname;
            LName = lname;
            Dob = dob;
            CurrentCheckouts = checkouts;
            CurrentHolds = holds;
        }

        public User()
        {

        }

        /// <summary>
        /// When a user returns an item, it removes it from the user's CurrentCheckouts,
        /// updates the item's status, and removes the loan from the loan file
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        public bool ReturnMedia(Media media)
        {
            CurrentCheckouts.Remove(media.Id);
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

            DataAccess.RemoveLoanFromFile(this.Id, media.Id);

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
        /// Places a hold on a book by adding it to a user's CurrentHolds
        /// and changing its status
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        /// <exception cref="TooYoungException"></exception>
        public bool PlaceHold(Media media)
        {
            List<User> users = DataAccess.LoadAllUsers();

            if (((DateTime.Now - Dob).TotalDays / 365.25) < media.AgeRestriction)
            {
                throw new TooYoungException("Sorry! You are too young to check out this item.");
            }
            else if (!media.Status.Equals("Available"))
            {
                CurrentHolds.Add(media.Id, DateTime.Now);
                
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
            else if (((DateTime.Now - Dob).TotalDays / 365.25) < media.AgeRestriction)
            {
                throw new TooYoungException("Sorry! You are too young to check out this item.");
            }

            CurrentCheckouts.Add(media.Id);
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

            Loan loan = new Loan(media, this.Id);
            DataAccess.SaveLoanToFile(loan);

            return true;
        }
    }
}
