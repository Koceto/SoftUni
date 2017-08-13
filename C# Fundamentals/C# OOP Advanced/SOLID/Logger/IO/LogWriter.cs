using Logger.Interfaces.IO;
using System.Collections.Generic;

namespace Logger.IO
{
    public class LogWriter
    {
        private List<IWriter> writeres;

        public LogWriter(params IWriter[] writers)
        {
            this.writeres = new List<IWriter>(writers);
        }

        public void Write(string time, string reportlevel, string message)
        {
            foreach (IWriter writer in this.writeres)
            {
                writer.WriteLine(time, reportlevel, message);
            }
        }
    }
}