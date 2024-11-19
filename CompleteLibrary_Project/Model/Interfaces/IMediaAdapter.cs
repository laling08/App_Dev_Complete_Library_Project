using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompleteLibrary_Project.Model.Enums;

namespace CompleteLibrary_Project.Model.Interfaces
{
    /// <summary>
    /// Interface for all the media apdapters (Book, Audiobook, Magazine, Movie)
    /// </summary>
    public interface IMediaAdapter
    {
        string GetTitle();
        string GetLanguage();
        Genre GetGenre();
        int GetPublicationYear();
        int GetAgeRestriction();
        int GetMaxCheckoutLength();
        string GetMediaInfo();

    }

}
