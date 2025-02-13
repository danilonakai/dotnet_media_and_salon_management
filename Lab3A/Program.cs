using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Program
    {
        const string DATAFILE = "Data.txt";
        private static StreamReader reader = new StreamReader(DATAFILE);
        public static Media[] mediaCollection = new Media[100];
        private static int mediaCount = 0;

        /// <summary>
        /// The entry point for the program.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            bool operating = true;
            ReadData();

            while (operating)
            {
                DisplayMenu();
                string input = Console.ReadLine().Trim();

                if (int.TryParse(input, out int option))
                {
                    switch (option)
                    {
                        case 1:
                            ListBooks();
                            break;

                        case 2:
                            ListMovies();
                            break;

                        case 3:
                            ListSongs();
                            break;

                        case 4:
                            ListAllMedia();
                            break;

                        case 5:
                            Console.Write("Enter a search term: ");
                            string searchTerm = Console.ReadLine();

                            bool found = false;

                            Console.WriteLine("Search Results:");
                            foreach (var media in mediaCollection)
                            {
                                if (media != null && media.Title != null && media.Title.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    Console.WriteLine($"{media.GetType().Name} Title: {media.Title} ({media.Year})");
                                    found = true;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine("No matching media found.");
                            }
                            break;

                        case 6:
                            Console.WriteLine("Exiting the program.");
                            operating = false;
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please choose a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer option.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        /// <summary>
        /// Reads media data from the data file and populates the media collection.
        /// </summary>
        public static void ReadData()
        {
            try
            {
                string data;
                while ((data = reader.ReadLine()) != null)
                {
                    string[] parts = data.Split('|');

                    if (parts.Length >= 4)
                    {
                        string mediaType = parts[0].Trim();

                        switch (mediaType)
                        {
                            case "BOOK":
                                string title = parts[1].Trim();
                                int year = int.Parse(parts[2].Trim());
                                string author = parts[3].Trim();
                                string summary = reader.ReadLine();

                                Book book = new Book(title, year, author, summary);
                                book.Decrypt();
                                mediaCollection[mediaCount] = book;
                                mediaCount++;
                                break;

                            case "MOVIE":
                                string movieTitle = parts[1].Trim();
                                int movieYear = int.Parse(parts[2].Trim());
                                string director = parts[3].Trim();
                                string movieSummary = reader.ReadLine();

                                Movie movie = new Movie(movieTitle, movieYear, director, movieSummary);
                                movie.Decrypt();
                                mediaCollection[mediaCount] = movie;
                                mediaCount++;
                                break;

                            case "SONG":
                                string songTitle = parts[1].Trim();
                                int songYear = int.Parse(parts[2].Trim());
                                string artist = parts[3].Trim();
                                string album = parts[4].Trim();

                                Song song = new Song(songTitle, songYear, album, artist);
                                mediaCollection[mediaCount] = song;
                                mediaCount++;
                                break;

                            default:
                                Console.WriteLine("Unknown media type: " + mediaType);
                                break;
                        }
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while reading data: " + ex.Message);
            }
        }

        /// <summary>
        /// Displays the program menu.
        /// </summary>
        public static void DisplayMenu()
        {
            Console.WriteLine("Danilo's Media Collection");
            Console.WriteLine("==========================");
            Console.WriteLine("1. List All Books");
            Console.WriteLine("2. List All Movies");
            Console.WriteLine("3. List All Songs");
            Console.WriteLine("4. List All Media");
            Console.WriteLine("5. Search All Media by Title");
            Console.WriteLine("6. Exit Program");
            Console.WriteLine("\nEnter choice:");
        }

        /// <summary>
        /// Lists all books in the media collection.
        /// </summary>
        public static void ListBooks()
        {
            Console.WriteLine("List of Books:");
            foreach (var media in mediaCollection)
            {
                if (media is Book book)
                {
                    Console.WriteLine($"Book Title: {book.Title} ({book.Year})");
                }
            }
        }

        /// <summary>
        /// Lists all movies in the media collection.
        /// </summary>
        public static void ListMovies()
        {
            Console.WriteLine("List of Movies:");
            foreach (var media in mediaCollection)
            {
                if (media is Movie movie)
                {
                    Console.WriteLine($"Movie Title: {movie.Title} ({movie.Year})");
                }
            }
        }

        /// <summary>
        /// Lists all songs in the media collection.
        /// </summary>
        public static void ListSongs()
        {
            Console.WriteLine("List of Songs:");
            foreach (var media in mediaCollection)
            {
                if (media is Song song)
                {
                    Console.WriteLine($"Song Title: {song.Title} ({song.Year})");
                }
            }
        }

        /// <summary>
        /// Lists all media in the collection, regardless of type.
        /// </summary>
        public static void ListAllMedia()
        {
            Console.WriteLine("List of All Media:");
            foreach (var media in mediaCollection)
            {
                if (media != null)
                {
                    Console.WriteLine($"{media.GetType().Name} Title: {media.Title} ({media.Year})");
                }
            }
        }
    }

}

