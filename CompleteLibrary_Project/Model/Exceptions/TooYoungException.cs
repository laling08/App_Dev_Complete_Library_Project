using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Model.Exceptions
{
    /// <summary>
    /// Represents an exception that is thrown when a user attempts to borrow a book that is not age-appropiate.
    /// </summary>
    public class TooYoungException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TooYoungException"/> class with a default error message.
        /// </summary>
        public TooYoungException() : base("You are borrowing a book that is not appropriate for your age.") { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TooYoungException"/> class with a specified error message.
        /// </summary>
        public TooYoungException(string message) : base(message) { }

    }
}
