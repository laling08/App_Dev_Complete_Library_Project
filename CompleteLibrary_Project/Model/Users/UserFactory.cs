using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Model.Users
{
    /// <summary>
    /// An abstract factory class that defines the contract for creating <see cref="User"/> objects.
    /// This class is intended to be extended by specific factories to create different types of users.
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// Abstract method for creating a <see cref="User"/> object.
        /// </summary>
        /// <param name="user">The type of user to create (e.g., "Member", "Librarian").</param>
        /// <param name="fname">The first name of the user.</param>
        /// <param name="lname">The last name of the user.</param>
        /// <param name="dob">The date of birth of the user.</param>
        /// <returns>A <see cref="User"/> object of the specified type, or null if the user type is not recognized.</returns>
        public abstract User getUser(string user, string fname, string lname, DateTime dob);
    }

    /// <summary>
    /// A concrete implementation of the <see cref="AbstractFactory"/> class that creates <see cref="Member"/> 
    /// or <see cref="Librarian"/> objects based on the input parameters.
    /// </summary>
    public class UserFactory : AbstractFactory
    {

        /// <summary>
        /// Creates a <see cref="User"/> object based on the specified user type.
        /// </summary>
        /// <param name="user">The type of user to create. It can be either "Member" or "Librarian".</param>
        /// <param name="fname">The first name of the user.</param>
        /// <param name="lname">The last name of the user.</param>
        /// <param name="dob">The date of birth of the user.</param>
        /// <returns>A <see cref="User"/> object of the specified type, or null if the user type is not recognized.</returns>
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
