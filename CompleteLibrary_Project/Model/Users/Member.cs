﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Model.Users
{
    internal class Member : User
    {
        public Member(string fname, string lname, DateTime dob) : base(fname, lname, dob) { }

        public Member(int id, string fname, string lname, DateTime dob) : base(id, fname, lname, dob) { }
        public Member() { }
    }
}
