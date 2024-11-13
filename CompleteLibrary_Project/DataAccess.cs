using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CompleteLibrary_Project
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
        public static void SaveBookToFile<Book>(Book book)
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
        public static void SaveMovieToFile<Movie>(Movie movie)
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
        public static void SaveAudiobookToFile<Audiobook>(Audiobook audiobook)
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
        public static void SaveMagazineToFile<Magazine>(Magazine magazine)
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
        public static List<Book> LoadAllBooks<Book>()
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
        public static List<Movie> LoadAllMovies<Movie>()
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
        public static List<Audiobook> LoadAllAudiobooks<Audiobook>()
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
        public static List<Magazine> LoadAllMagazines<Magazine>()
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
        public static Book loadBook<Book>(int id)
        {
            List<Book> books = LoadAllBooks<Book>();

            return books?.FirstOrDefault(book => book.Id == id);
        }

        /// <summary>
        /// Finds the movie of the given id in the json file
        /// </summary>
        /// <typeparam name="Movie"></typeparam>
        /// <param name="id">the id of the movie to be found</param>
        /// <returns>a movie object from the json file with the corresponding id</returns>
        public static Movie loadMovie<Movie>(int id)
        {
            List<Movie> movies = LoadAllMovies<Movie>();

            return movies?.FirstOrDefault(movie => movie.Id == id);
        }

        /// <summary>
        /// Finds the audiobook of the given id in the json file
        /// </summary>
        /// <typeparam name="Audiobook"></typeparam>
        /// <param name="id">the id of the audiobook to be found</param>
        /// <returns>an audiobook object from the json file with the corresponding id</returns>
        public static Audiobook loadAudiobook<Audiobook>(int id)
        {
            List<Audiobook> audiobooks = LoadAllMovies<Audiobook>();

            return audiobooks?.FirstOrDefault(audiobook => audiobook.Id == id);
        }

        /// <summary>
        /// Finds the magazine of the given id in the json file
        /// </summary>
        /// <typeparam name="Magazine"></typeparam>
        /// <param name="id">the id of the magazine to be found</param>
        /// <returns>a magazine object from the json file with the corresponding id</returns>
        public static Magazine loadMagazine<Magazine>(int id)
        {
            List<Magazine> magazines = LoadAllMovies<Magazine>();

            return magazines?.FirstOrDefault(magazine => magazine.Id == id);
        }

        /// <summary>
        /// Updates the loan status of a book
        /// </summary>
        /// <param name="bookId">the id of the book whose status has changed</param>
        /// <param name="status">the new status of the book</param>
        public static void UpdateBookStatus(int bookId, string status)
        {
            List<Book> books = LoadAllBooks<Book>();

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
            List<Movie> movies = LoadAllMovies<Movie>();

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
            List<Audiobook> audiobooks = LoadAllAudiobooks<Audiobook>();

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
            List<Magazine> magazines = LoadAllMagazines<Magazine>();

            Magazine magazineToUpdate = magazines.First(magazine => magazine.Id == magazineId);
            magazineToUpdate.Status = status;

            foreach (Magazine magazine in magazines)
            {
                SaveMagazineToFile(magazine);

            }
        }
    }
}
