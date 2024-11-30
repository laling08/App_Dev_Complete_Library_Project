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


        /// <summary>
        /// Initializes a new instance of the <see cref="Loan"/> class for a media item.
        /// </summary>
        /// <param name="mediaType">The media item being borrowed.</param>
        /// <param name="userId">The ID of the user borrowing the media.</param>
        public Loan(Media mediaType, int userId)
        {
            MediaType = mediaType.GetType().ToString();
            Title = mediaType.Title;
            UserId = userId;
            MediaId = mediaType.Id;
            CheckoutDate = DateTime.Now;
            ExpectedReturnDate = CheckoutDate.AddDays(mediaType.MaxCheckoutLength);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Loan"/> class with specific values.
        /// </summary>
        /// <param name="mediaType">The type of media being borrowed.</param>
        /// <param name="title">The title of the media being borrowed.</param>
        /// <param name="userId">The ID of the user borrowing the media.</param>
        /// <param name="mediaId">The ID of the media item being borrowed.</param>
        /// <param name="checkoutDate">The date the media was checked out.</param>
        /// <param name="expectedReturnDate">The expected return date for the media.</param>
        public Loan(string mediaType, string title, int userId, int mediaId, DateTime checkoutDate, DateTime expectedReturnDate)
        {
            MediaType = mediaType;
            Title = title;
            UserId = userId;
            MediaId = mediaId;
            CheckoutDate = checkoutDate;
            ExpectedReturnDate = expectedReturnDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Loan"/> class (required for deserialization).
        /// </summary>
        public Loan()
        {
            // Empty constructor required for deserialization
        }
    }
}
