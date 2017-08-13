namespace Logger.Interfaces.IO
{
    public interface IWriter
    {
        void Write(string time, string reportLevel, string message);

        void WriteLine(string time, string reportLevel, string message);
    }
}