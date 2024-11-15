using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project
{
    public abstract class User
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Id { get; private set; }
        public DateTime Dob { get; set; }
        private static int _count = 1;

        private Media[] _currentCheckouts;
        private Media[] _currentHolds;

        protected User(string fname, string lname)
        {
            FName = fname;
            LName = lname;
            Id = _count++;
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
