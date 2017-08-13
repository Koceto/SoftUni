namespace Logger.Models
{
    public class LogFile
    {
        private string name;
        private string path;

        public LogFile()
        {
            this.Name = "log.txt";
            this.Path = System.IO.Directory.GetCurrentDirectory() + "..\\..\\..\\";
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }
    }
}