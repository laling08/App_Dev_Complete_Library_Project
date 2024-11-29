using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Model.Medias
{
    /// <summary>
    /// Model for Loan Class.
    /// </summary>
    public class Loan
    {
        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("user_id")]
        public int UserId { get; set; }
        [JsonPropertyName("media_id")]
        public int MediaId { get; set; }
        [JsonPropertyName("checkout_date")]
        public DateTime CheckoutDate { get; set; }
        [JsonPropertyName("expected_return_date")]
        public DateTime ExpectedReturnDate { get; set; }
        

        public Loan(Media mediaType, int userId)
        {
            MediaType = mediaType.GetType().ToString();
            Title = mediaType.Title;
            UserId = userId;
            MediaId = mediaType.GetHashCode();
            CheckoutDate = DateTime.Now;
            ExpectedReturnDate = CheckoutDate.AddDays(mediaType.MaxCheckoutLength);
        }

        public Loan(string mediaType, string title, int userId, int mediaId, DateTime checkoutDate, DateTime expectedReturnDate)
        {
            MediaType = mediaType;
            Title = title;
            UserId = userId;
            MediaId = mediaId;
            CheckoutDate = checkoutDate;
            ExpectedReturnDate = expectedReturnDate;
        }

        public Loan()
        {
            // empty constructor required for deserialization
        }
    }
}
