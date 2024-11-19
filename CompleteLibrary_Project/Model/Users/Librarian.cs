﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// added media folder and its classes
using CompleteLibrary_Project.Model.Medias;

namespace CompleteLibrary_Project.Model.Users
{
    public class Librarian : User
    {
        public Librarian(string fname, string lname) : base(fname, lname) { }

        public Media ViewMemberHistory(User member)
        {
            return null;
        }

        public Loan ViewReport(Media media)
        {
            return null;
        }

        public bool AddMedia(Media media)
        {
            return true;
        }

        public bool ModifyMediaDetails(Media media)
        {
            return true;
        }

        public bool RemoveMedia(Media media)
        {
            return true;
        }

        public bool IssueMedia(Media media)
        {
            return true;
        }
    }
}