using CompleteLibrary_Project.Model.Interfaces;
using CompleteLibrary_Project.Model.Medias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Controller
{
    public class AudiobookController : IMediaController
    {
        public void Checkout(Media media)
        {
            if (media is Audiobook audiobook)
            {
                audiobook.Checkout();
                Console.WriteLine("Audiobook successfully checked out.");
            }
        }

        public void ReturnItem(Media media)
        {
            if (media is Audiobook audiobook)
            {
                audiobook.ReturnItem();
                Console.WriteLine("Audiobook successfully returned.");
            }
        }

        public void RenewLoan(Media media)
        {
            if (media is Audiobook audiobook)
            {
                audiobook.RenewLoan();
                Console.WriteLine("Audiobook loan renewed.");
            }
        }

        public void ApplyLateFee(Media media)
        {
            if (media is Audiobook audiobook)
            {
                audiobook.GiveLateFee();
                Console.WriteLine("Late fee applied to audiobook.");
            }
        }

        public string GetMediaInfo(Media media)
        {
            if (media is Audiobook audiobook)
            {
                // What is audiobook.GetMediaInfo()? Do we want audiobook.ToString()?
                // return audiobook.GetMediaInfo();
                return "Audiobook"; // please verify if this is correct
            }
            return "Invalid media type.";
        }
    }

}
