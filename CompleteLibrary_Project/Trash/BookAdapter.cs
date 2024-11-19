using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompleteLibrary_Project.Model.Enums;
using CompleteLibrary_Project.Model.Interfaces;
using CompleteLibrary_Project.Model.Medias;

namespace CompleteLibrary_Project.Trash
{
    public class BookAdapter : IMediaAdapter
    {
        private readonly Book book;

        public BookAdapter(Book book)
        {
            this.book = book;
        }

        public string GetTitle()
        {
            return book.Title;
        }

        public string GetLanguage()
        {
            return book.Language;
        }

        public Genre GetGenre()
        {
            return book.Genre;
        }

        public int GetPublicationYear()
        {
            return book.PublicationYear;
        }

        public int GetAgeRestriction()
        {
            return book.AgeRestriction;
        }

        public int GetMaxCheckoutLength()
        {
            return book.MaxCheckoutLength;
        }

        public string GetMediaInfo()
        {
            return $"Book ISBN: {book.ISBN}, Author: {book.Author}, Publisher: {book.Publisher}";
        }

        public string GetISBN()
        {
            return book.ISBN;
        }

        public string GetAuthor()
        {
            return book.Author;
        }

        public string GetPublisher()
        {
            return book.Publisher;
        }

        public string GetIllustrator()
        {
            return book.Illustrator;
        }

        public int GetEdition()
        {
            return book.Edition;
        }
    }
}
