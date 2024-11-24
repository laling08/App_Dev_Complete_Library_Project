using CompleteLibrary_Project.Model.Medias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Model.Interfaces
{
    public interface IMediaController
    {
        void Checkout(Media media);
        void ReturnItem(Media media);
        void RenewLoan(Media media);
        void ApplyLateFee(Media media);
        string GetMediaInfo(Media media);
    }
}
