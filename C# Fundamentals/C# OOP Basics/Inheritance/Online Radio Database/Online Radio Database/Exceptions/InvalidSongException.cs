using System;

namespace Online_Radio_Database
{
    public class InvalidSongException : Exception
    {
        public override string Message
        {
            get { return "Invalid song."; }
        }
    }
}