using System;
using System.Collections.Generic;

namespace Online_Radio_Database
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            TimeSpan timeSpan = new TimeSpan();

            for (int i = 0; i < n; i++)
            {
                string[] songInfo = Console.ReadLine()
                    .Split(';');

                string artist = songInfo[0];
                string name = songInfo[1];
                string length = songInfo[2];

                try
                {
                    Song song = new Song(artist, name, length);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Songs added: {songs.Count}");

            foreach (var song in songs)
            {
                timeSpan += new TimeSpan(0, 0, 0, song.GetSeconds());
            }

            Console.WriteLine($"Playlist length: {timeSpan.Hours}h {timeSpan.Minutes}m {timeSpan.Seconds}s");
        }
    }
}