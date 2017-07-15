namespace Bash_Soft
{
    public class StartUp
    {
        public static void Main()
        {
            Tester tester = new Tester();
            IOManager ioManager = new IOManager();
            StudentsRepository repository = new StudentsRepository(new RepositoryFilter(), new RepositorySorter());
            CommandInterpreter interpreter = new CommandInterpreter(tester, repository, ioManager);
            InputReader reader = new InputReader(interpreter);

            reader.StartReadingCommands();
        }
    }
}