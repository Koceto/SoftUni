using System;
using System.Linq;
using Online_Radio_Database.Exceptions;

namespace Online_Radio_Database
{
    public class Song
    {
        private string artist;
        private string name;
        private int minutes;
        private int seconds;

        public Song(string artist, string name, string length)
        {
            this.Artist = artist;
            this.Name = name;
            this.Length = length;
        }

        public string Length
        {
            get { return $"{this.minutes}:{this.seconds}"; }
            set
            {
                var minAndSec = value.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int min;
                int sec;

                if (minAndSec.Length != 2)
                {
                    throw new InvalidSongLengthException();
                }

                var isMinute = int.TryParse(minAndSec[0], out min);
                var isSecond = int.TryParse(minAndSec[1], out sec);

                if (!isMinute || !isSecond)
                {
                    throw new InvalidSongLengthException();
                }

                this.Minutes = min;
                this.Seconds = sec;
            }
        }

        public int Minutes
        {
            get { return this.minutes; }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get { return this.seconds; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.seconds = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }
                this.name = value;
            }
        }

        public string Artist
        {
            get { return this.artist; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                this.artist = value;
            }
        }

        public int GetSeconds()
        {
            return this.Minutes * 60 + this.Seconds;
        }
    }
}