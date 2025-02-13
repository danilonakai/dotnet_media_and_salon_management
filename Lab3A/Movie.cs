using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Movie : Media, IEncryptable, ISearchable
    {
        /// <summary>
        /// Gets or sets the director of the movie.
        /// </summary>
        string Director { get; set; }

        /// <summary>
        /// Gets or sets the summary of the movie.
        /// </summary>
        string Summary { get; set; }

        /// <summary>
        /// An array of lowercase letters used for decryption.
        /// </summary>
        public char[] letters = new char[]
        {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
        'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
        's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        /// <summary>
        /// Initializes a new instance of the Movie class with the specified title, year, director, and summary.
        /// </summary>
        /// <param name="title">The title of the movie.</param>
        /// <param name="year">The year the movie was released.</param>
        /// <param name="Director">The director of the movie.</param>
        /// <param name="Summary">The summary of the movie.</param>
        public Movie(string title, int year, string Director, string Summary) : base(title, year)
        {
            this.Director = Director;
            this.Summary = Summary;
        }

        /// <summary>
        /// Decrypts the summary of the movie by performing a simple letter substitution (Caesar cipher).
        /// </summary>
        /// <returns>The decrypted summary of the movie.</returns>
        public string Decrypt()
        {
            bool caps = false;
            char[] words = this.Summary.ToCharArray();

            for (int i = 0; i < words.Length; i++)
            {
                caps = char.IsUpper(words[i]) ? true : false;
                if (!char.IsLetter(words[i]))
                {
                    continue;
                }

                for (int k = 0; k < letters.Length; k++)
                {
                    char lower = char.ToLower(words[k]);
                    if (lower == letters[k])
                    {
                        k -= 13;
                        if (k < 0)
                        {
                            k = 26 - Math.Abs(k);
                        }
                        words[i] = caps ? char.ToUpper(letters[k]) : letters[k];
                        break;
                    }
                }
            }
            this.Summary = new string(words);
            return this.Summary;
        }

        /// <summary>
        /// Encrypts the summary of the movie. (Not implemented)
        /// </summary>
        /// <returns>The encrypted summary of the movie.</returns>
        public string Encrypt()
        {
            throw new NotImplementedException();
        }
    }
}

