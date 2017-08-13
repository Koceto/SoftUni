using Logger.Interfaces;
using System;
using Logger.Interfaces.IO;

namespace Logger.IO
{
    public class ConsoleAppender : IWriter
    {
        private ILayout format;

        public ConsoleAppender(ILayout format)
        {
            this.format = format;
        }

        public void Write(string time, string reportLevel, string message)
        {
            Console.Write(this.format.GetFormat(), time, reportLevel, message);
        }

        public void WriteLine(string time, string reportLevel, string message)
        {
            Console.WriteLine(this.format.GetFormat(), time, reportLevel, message);
        }
    }
}