using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Model.Users
{
    /// <summary>
    /// Represents a library member in the library system. Inherits from the <see cref="User"/> class.
    /// A member can check out and hold media items, but does not have administrative permissions.
    /// </summary>
    public class Member : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class with the specified first name, last name, and date of birth.
        /// </summary>
        /// <param name="fname">The first name of the library member.</param>
        /// <param name="lname">The last name of the library member.</param>
        /// <param name="dob">The date of birth of the library member.</param>
        public Member(string fname, string lname, DateTime dob) : base(fname, lname, dob) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class with the specified ID, first name, last name, date of birth,
        /// checkout history, and hold history.
        /// </summary>
        /// <param name="id">The unique identifier for the library member.</param>
        /// <param name="fname">The first name of the library member.</param>
        /// <param name="lname">The last name of the library member.</param>
        /// <param name="dob">The date of birth of the library member.</param>
        /// <param name="checkouts">The list of media IDs the member has checked out.</param>
        /// <param name="holds">The dictionary of media IDs the member has on hold, along with the hold dates.</param>
        public Member(int id, string fname, string lname, DateTime dob, List<int> checkouts, Dictionary<int, DateTime> holds)
            : base(id, fname, lname, dob, checkouts, holds) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class. Required for deserialization.
        /// </summary>
        public Member() { }
    }
}
