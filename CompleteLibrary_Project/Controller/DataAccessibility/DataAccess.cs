using CompleteLibrary_Project.Model.Medias;
using CompleteLibrary_Project.Model.Users;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Controller.DataAccessibility
{
    public class DataAccess
    {
        // allows for adjustment of file paths
        private static readonly string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        /// <summary>
        /// Appends a new book to the ones stored in the json file
        /// </summary>
        /// <typeparam name="Book"></typeparam>
        /// <param name="book">the new book to add to the json file</param>
        public static void SaveBookToFile(Book book)
        {
            string filePath = Path.Combine(basePath, "books.json");
            string jsonString = File.ReadAllText(filePath);

            // Remove the closing bracket in order to add another object
            jsonString = jsonString.TrimEnd(']', ' ', '\n', '\r');
            var bookJsonString = JsonSerializer.Serialize(book, new JsonSerializerOptions { WriteIndented = true });

            jsonString += ",\n" + bookJsonString + "\n]";

            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Appends a new movie to the ones stored in the json file
        /// </summary>
        /// <typeparam name="Movie"></typeparam>
        /// <param name="movie">the new movie to add to the json file</param>
        public static void SaveMovieToFile(Movie movie)
        {
            string filePath = Path.Combine(basePath, "movies.json");
            string jsonString = File.ReadAllText(filePath);

            // Remove the closing bracket in order to add another object
            jsonString = jsonString.TrimEnd(']', ' ', '\n', '\r');
            var bookJsonString = JsonSerializer.Serialize(movie, new JsonSerializerOptions { WriteIndented = true });

            jsonString += ",\n" + bookJsonString + "\n]";

            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Appends a new audiobook to the ones stored in the json file
        /// </summary>
        /// <typeparam name="Audiobook"></typeparam>
        /// <param name="audiobook">the new audiobook to add to the json file</param>
        public static void SaveAudiobookToFile(Audiobook audiobook)
        {
            string filePath = Path.Combine(basePath, "audiobooks.json");
            string jsonString = File.ReadAllText(filePath);

            // Remove the closing bracket in order to add another object
            jsonString = jsonString.TrimEnd(']', ' ', '\n', '\r');
            var bookJsonString = JsonSerializer.Serialize(audiobook, new JsonSerializerOptions { WriteIndented = true });

            jsonString += ",\n" + bookJsonString + "\n]";

            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Appends a new magazine to the ones stored in the json file
        /// </summary>
        /// <typeparam name="Magazine"></typeparam>
        /// <param name="magazine">the new magazine to add to the json file</param>
        public static void SaveMagazineToFile(Magazine magazine)
        {
            string filePath = Path.Combine(basePath, "magazines.json");
            string jsonString = File.ReadAllText(filePath);

            // Remove the closing bracket in order to add another object
            jsonString = jsonString.TrimEnd(']', ' ', '\n', '\r');
            var bookJsonString = JsonSerializer.Serialize(magazine, new JsonSerializerOptions { WriteIndented = true });

            jsonString += ",\n" + bookJsonString + "\n]";
            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Gets all the books stored in the json file
        /// </summary>
        /// <typeparam name="Book"></typeparam>
        /// <returns>book objects from the json file</returns>
        public static List<Book> LoadAllBooks()
        {
            string filePath = Path.Combine(basePath, "books.json");
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Book>>(jsonString);
        }

        /// <summary>
        /// Gets all the movies stored in the json file
        /// </summary>
        /// <typeparam name="Movie"></typeparam>
        /// <returns>movie objects from the json file</returns>
        public static List<Movie> LoadAllMovies()
        {
            string filePath = Path.Combine(basePath, "movies.json");
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Movie>>(jsonString);
        }

        /// <summary>
        /// Gets all the audiobooks stored in the json file
        /// </summary>
        /// <typeparam name="Audiobook"></typeparam>
        /// <returns>audiobook objects from the json file</returns>
        public static List<Audiobook> LoadAllAudiobooks()
        {
            string filePath = Path.Combine(basePath, "audiobooks.json");
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Audiobook>>(jsonString);
        }

        /// <summary>
        /// Gets all the magazines stored in the json file
        /// </summary>
        /// <typeparam name="Magazine"></typeparam>
        /// <returns>magazine objects from the json file</returns>
        public static List<Magazine> LoadAllMagazines()
        {
            string filePath = Path.Combine(basePath, "magazines.json");
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Magazine>>(jsonString);
        }

        /// <summary>
        /// Finds the book of the given id in the json file
        /// </summary>
        /// <typeparam name="Book"></typeparam>
        /// <param name="id">the id of the book to be found</param>
        /// <returns>a book object corresponding to the id</returns>
        public static Book LoadBook(int id)
        {
            List<Book> books = LoadAllBooks();

            return books?.FirstOrDefault(book => book.Id == id);
        }

        /// <summary>
        /// Finds the movie of the given id in the json file
        /// </summary>
        /// <typeparam name="Movie"></typeparam>
        /// <param name="id">the id of the movie to be found</param>
        /// <returns>a movie object from the json file with the corresponding id</returns>
        public static Movie LoadMovie(int id)
        {
            List<Movie> movies = LoadAllMovies();

            return movies?.FirstOrDefault(movie => movie.Id == id);
        }

        /// <summary>
        /// Finds the audiobook of the given id in the json file
        /// </summary>
        /// <typeparam name="Audiobook"></typeparam>
        /// <param name="id">the id of the audiobook to be found</param>
        /// <returns>an audiobook object from the json file with the corresponding id</returns>
        public static Audiobook LoadAudiobook(int id)
        {
            List<Audiobook> audiobooks = LoadAllAudiobooks();

            return audiobooks?.FirstOrDefault(audiobook => audiobook.Id == id);
        }

        /// <summary>
        /// Finds the magazine of the given id in the json file
        /// </summary>
        /// <typeparam name="Magazine"></typeparam>
        /// <param name="id">the id of the magazine to be found</param>
        /// <returns>a magazine object from the json file with the corresponding id</returns>
        public static Magazine LoadMagazine(int id)
        {
            List<Magazine> magazines = LoadAllMagazines();

            return magazines?.FirstOrDefault(magazine => magazine.Id == id);
        }

        /// <summary>
        /// Updates the loan status of a book
        /// </summary>
        /// <param name="bookId">the id of the book whose status has changed</param>
        /// <param name="status">the new status of the book</param>
        public static void UpdateBookStatus(int bookId, string status)
        {
            List<Book> books = LoadAllBooks();

            Book bookToUpdate = books.First(book => book.Id == bookId);
            bookToUpdate.Status = status;

            foreach (Book book in books)
            {
                SaveBookToFile(book);
            }
        }

        /// <summary>
        /// Updates the loan status of a movie
        /// </summary>
        /// <param name="movieId">the id of the movie whose status has changed</param>
        /// <param name="status"></param>
        public static void UpdateMovieStatus(int movieId, string status)
        {
            List<Movie> movies = LoadAllMovies();

            Movie movieToUpdate = movies.First(movie => movie.Id == movieId);
            movieToUpdate.Status = status;

            foreach (Movie movie in movies)
            {
                SaveMovieToFile(movie);
            }
        }

        /// <summary>
        /// Updates the loan status of an audiobook
        /// </summary>
        /// <param name="audiobookId">the id of the audiobook whose status has changed</param>
        /// <param name="status">the new status of the audiobook</param>
        public static void UpdateAudiobookStatus(int audiobookId, string status)
        {
            List<Audiobook> audiobooks = LoadAllAudiobooks();

            Audiobook audiobookToUpdate = audiobooks.First(audiobook => audiobook.Id == audiobookId);
            audiobookToUpdate.Status = status;

            foreach (Audiobook audiobook in audiobooks)
            {
                SaveAudiobookToFile(audiobook);
            }
        }

        /// <summary>
        /// Updates the loan status of a magazine
        /// </summary>
        /// <param name="magazineId">the id of the magazine whose status has changed</param>
        /// <param name="status">the new status of the magazine</param>
        public static void UpdateMagazineStatus(int magazineId, string status)
        {
            List<Magazine> magazines = LoadAllMagazines();

            Magazine magazineToUpdate = magazines.First(magazine => magazine.Id == magazineId);
            magazineToUpdate.Status = status;

            foreach (Magazine magazine in magazines)
            {
                SaveMagazineToFile(magazine);

            }
        }

        // User classes
        /// <summary>
        /// Appends a serialized user to the user json file
        /// </summary>
        /// <param name="user">the user to add to the file</param>
        public static void SaveUserToFile(User user)
        {
            string filePath = Path.Combine(basePath, "users.json");
            string jsonString = File.ReadAllText(filePath);

            // Remove the closing bracket in order to add another object
            jsonString = jsonString.TrimEnd(']', ' ', '\n', '\r');
            var bookJsonString = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });

            jsonString += ",\n" + bookJsonString + "\n]";

            File.WriteAllText(filePath, jsonString);
        }
        
        /// <summary>
        /// Saves an entire list of users, overwriting what already exists in the file
        /// </summary>
        /// <param name="users">List of users to serialize</param>
        public static void SaveUsersToFile(List<User> users)
        {
            string filePath = Path.Combine(basePath, "users.json");
            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = JsonSerializer.Serialize(users, options);
            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Appends a serialized loan to the loans file
        /// </summary>
        /// <param name="loan"></param>
        public static void SaveLoanToFile(Loan loan)
        {
            string filePath = Path.Combine(basePath, "loans.json");
            string jsonString = File.ReadAllText(filePath);

            // Remove the closing bracket in order to add another object
            jsonString = jsonString.TrimEnd(']', ' ', '\n', '\r');
            var bookJsonString = JsonSerializer.Serialize(loan, new JsonSerializerOptions { WriteIndented = true });

            jsonString += ",\n" + bookJsonString + "\n]";

            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Removes a loan from the loans file for once the item is returned
        /// </summary>
        /// <param name="userId">The loan can be identified using a combined 
        /// key of the user's id and the media's id</param>
        /// <param name="mediaId"></param>
        public static void RemoveLoanFromFile(int userId, int mediaId)
        {
            string filePath = Path.Combine(basePath, "loans.json");

            List<Loan> loans = LoadAllLoans();

            Loan loanToRemove = loans.FirstOrDefault(loan => loan.UserId == userId && loan.MediaId == mediaId);
            
            if (loanToRemove != null)
            {
                loans.Remove(loanToRemove);

                string updatedJsonString = JsonSerializer.Serialize(loans, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, updatedJsonString);
            }
        }


        /// <summary>
        /// Saves an entire list of loans, overwriting what already exists in the file
        /// </summary>
        /// <param name="loans">List of loans to serialize</param>
        public static void SaveLoansToFile(List<Loan> loans)
        {
            string filePath = Path.Combine(basePath, "loans.json");
            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = JsonSerializer.Serialize(loans, options);
            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Loads all the users stored in the users file
        /// </summary>
        /// <returns>a list of all users</returns>
        public static List<User> LoadAllUsers()
        {
            string filePath = Path.Combine(basePath, "users.json");
            var jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                Converters = { new UserConverter() },
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<List<User>>(jsonString, options);
        }

        /// <summary>
        /// Gets all the loans stored in the loans file
        /// </summary>
        /// <returns>a list of all loans</returns>
        public static List<Loan> LoadAllLoans()
        {
            string filePath = Path.Combine(basePath, "loans.json");
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Loan>>(jsonString);
        }

        public static User LoadUser(int id)
        {
            List<User> users = LoadAllUsers();

            return users?.FirstOrDefault(user => user.Id == id);
        }

        public static Loan LoadLoan(int userId, int mediaId)
        {
            List<Loan> loans = LoadAllLoans();

            return loans?.FirstOrDefault(loan => loan.MediaId == mediaId && loan.UserId == userId);
        }
    }
}