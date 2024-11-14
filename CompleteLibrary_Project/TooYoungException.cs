using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project
{
    public class TooYoungException : Exception
    {
        public TooYoungException() : base("You are borrowing a book that is not appropriate for your age.") {}

        public TooYoungException(string message) : base(message) {}
        
    }
}
