using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Song : Media, IEncryptable, ISearchable
    {
        /// <summary>
        /// Gets or sets the album of the song.
        /// </summary>
        string Album { get; set; }

        /// <summary>
        /// Gets or sets the artist of the song.
        /// </summary>
        string Artist { get; set; }

        /// <summary>
        /// Initializes a new instance of the Song class with the specified title, year, album, and artist.
        /// </summary>
        /// <param name="title">The title of the song.</param>
        /// <param name="year">The year the song was released.</param>
        /// <param name="Album">The album to which the song belongs.</param>
        /// <param name="Artist">The artist who performed the song.</param>
        public Song(string title, int year, string Album, string Artist) :
            base(title, year)
        {
            this.Album = Album;
            this.Artist = Artist;
        }

        /// <summary>
        /// Decrypts the song. (Not implemented)
        /// </summary>
        /// <returns>A decrypted version of the song.</returns>
        public string Decrypt()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Encrypts the song. (Not implemented)
        /// </summary>
        /// <returns>An encrypted version of the song.</returns>
        public string Encrypt()
        {
            throw new NotImplementedException();
        }
    }
}
