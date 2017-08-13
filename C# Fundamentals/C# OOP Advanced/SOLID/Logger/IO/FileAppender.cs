using Logger.Interfaces;
using Logger.Models;
using System.IO;
using Logger.Interfaces.IO;

namespace Logger.IO
{
    public class FileAppender : IWriter
    {
        private ILayout format;

        public FileAppender(ILayout format)
        {
            this.format = format;
            this.File = new LogFile();
            this.File.Path = Directory.GetCurrentDirectory() + "..\\..\\..\\";
            this.File.Name = "log.txt";
        }

        public LogFile File { get; set; }

        public void Write(string time, string reportLevel, string message)
        {
            using (StreamWriter writer = new StreamWriter(this.File.Path + this.File.Name, true))
            {
                writer.Write(this.format.GetFormat(), time, reportLevel, message);
            }
        }

        public void WriteLine(string time, string reportLevel, string message)
        {
            using (StreamWriter writer = new StreamWriter(this.File.Path + this.File.Name, true))
            {
                writer.WriteLine(this.format.GetFormat(), time, reportLevel, message);
            }
        }
    }
}