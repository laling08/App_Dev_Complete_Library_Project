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
        public void Checkout(Media media);
        public void ReturnItem(Media media);
        public void RenewLoan(Media media);
        public void ApplyLateFee(Media media);
        public string GetMediaInfo(Media media);
    }
}
