using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Model.Users
{
    public abstract class AbstractFactory
    {
        public abstract User getUser(string user, string fname, string lname, DateTime dob);
    }
    public class UserFactory : AbstractFactory
    {
        public override User getUser(string user, string fname, string lname, DateTime dob)
        {
            if (user == "Member")
            {
                return new Member(fname, lname, dob);
            }
            else if (user == "Librarian")
            {
                return new Librarian(fname, lname, dob);
            }
            else
            {
                return null;
            }
        }
    }
}
