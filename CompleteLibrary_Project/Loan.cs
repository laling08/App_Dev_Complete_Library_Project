using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project
{
    /// <summary>
    /// Model for Loan Class.
    /// </summary>
    public class Loan
    {
        public Media MediaType { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public int MediaId { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }

        public Loan(Media mediaType, int userId)
        {
            MediaType = mediaType;
            Title = mediaType.Title;
            UserId = userId;
            MediaId = mediaType.GetHashCode();
            CheckoutDate = DateTime.Now;
            ExpectedReturnDate = CheckoutDate.AddDays(mediaType.MaxCheckoutLength);
        }
    }
}
