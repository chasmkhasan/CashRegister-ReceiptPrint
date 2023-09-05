using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    internal class Album
    {
        private string? albumName;
        private string? artistName;
        private int numOfTracks;

        public void AlbumStart()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************************");
            Console.WriteLine("Starting the Album Program!");
            Console.WriteLine("***************************");
            ReadAndSaveDataOfAlbum();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            DisplayDataOfAlbum();
            ReadDateTime();


        }

        private void ReadAndSaveDataOfAlbum()
        {
            ReadAlbumName();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ReadArtistName();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ReadNumOfTracks();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }

        private void ReadAlbumName()
        {
            Console.WriteLine();
            Console.WriteLine("What is the Name of your favorite music album?");
            albumName = Console.ReadLine().ToUpper();
        }
        private void ReadArtistName()
        {
            Console.WriteLine();
            Console.WriteLine("What is the name of the Artist or Band for " + albumName + "?");
            artistName = Console.ReadLine().ToUpper();
        }
        private void ReadNumOfTracks()
        {
            Console.WriteLine();
            Console.WriteLine("How many tracks does " + artistName + "?");
            numOfTracks = int.Parse(Console.ReadLine());
        }
        private void DisplayDataOfAlbum()
        {
            Console.WriteLine();
            Console.WriteLine("Album Name       : " + albumName);
            Console.WriteLine("Artist/Band Name : " + artistName);
            Console.WriteLine("Number of Tracks : " + numOfTracks);
            Console.WriteLine("Enjoy Listening");
        }
        private void ReadDateTime()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Receipt has been print on: " + now);
        }

    }
}
