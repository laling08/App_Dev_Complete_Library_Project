using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CompleteLibrary_Project.Model.Enums;



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
        private static int _count = 1;

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

        public bool ReturnMedia(Media media)
        {
            return true;
        }

        public bool PlaceHold(Media media)
        {
            return true;
        }

        public Media SearchByGenre(Genre genre)
        {
            return null;
        }

        public Media SearchByType(string type)
        {
            return null;
        }

        public Media SearchByTitle(string title)
        {
            return null;
        }

        public Media SearchByAuthor(string author)
        {
            return null;
        }

        public Media SearchByIdentifier(string identifier)
        {
            return null;
        }

        public bool PayFee(double amount)
        {
            return true;
        }

        public Loan ViewPersonalHistory()
        {
            return null;
        }
    }
}
