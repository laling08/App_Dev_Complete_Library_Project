using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Model.Users
{
    internal class Member : User
    {
        public Member(string fname, string lname, DateTime dob) : base(fname, lname, dob) { }

        public Member(int id, string fname, string lname, DateTime dob, List<int> checkouts, Dictionary<int, DateTime> holds) : base(id, fname, lname, dob, checkouts, holds) { }
        public Member() { }
    }
}
