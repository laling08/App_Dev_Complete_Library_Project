using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompleteLibrary_Project.Model.Enums;



// So when we are organizing the classes in folders we just need to add the names space and the name of the folder.
using CompleteLibrary_Project.Model.Medias;

namespace CompleteLibrary_Project.Model.Users
{
    public abstract class User
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Id { get; private set; }
        public DateTime Dob { get; set; }
        private static int _count = 1;

        //private Book[] _books;
        private Media[] _currentCheckouts;
        private Media[] _currentHolds;

        public User(string fname, string lname, DateTime dob)
        {
            FName = fname;
            LName = lname;
            Dob = dob;
            Id = _count++;
        }

        public User(int id, string fname, string lname, DateTime dob)
        {
            Id = id;
            FName = fname;
            LName = lname;
            Dob = dob;
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
