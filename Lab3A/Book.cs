using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Book : Media, IEncryptable, ISearchable
    {
        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        string Author { get; set; }

        /// <summary>
        /// Gets or sets the summary of the book.
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
        /// Initializes a new instance of the Book class with the specified title, year, author, and summary.
        /// </summary>
        /// <param name="title">The title of the book.</param>
        /// <param name="year">The year the book was published.</param>
        /// <param name="Author">The author of the book.</param>
        /// <param name="Summary">The summary of the book.</param>
        public Book(string title, int year, string Author, string Summary) : base(title, year)
        {
            this.Author = Author;
            this.Summary = Summary;
        }

        /// <summary>
        /// Decrypts the summary of the book by performing a simple letter substitution (Caesar cipher).
        /// </summary>
        /// <returns>The decrypted summary of the book.</returns>
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
        /// Encrypts the summary of the book. (Not implemented)
        /// </summary>
        /// <returns>The encrypted summary of the book.</returns>
        public string Encrypt()
        {
            throw new NotImplementedException();
        }
    }
}
