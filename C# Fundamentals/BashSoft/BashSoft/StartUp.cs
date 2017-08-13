using BashSoft.Contracts;

namespace BashSoft
{
    public class StartUp
    {
        public static void Main()
        {
            IContentComparer tester = new Tester();
            IDirectoryManager inputOutputManager = new IOManager();
            IDatabase repository = new StudentsRepository(new RepositoryFilter(), new RepositorySorter());
            IInterpreter interpreter = new CommandInterpreter(tester, repository, inputOutputManager);
            IReader reader = new InputReader(interpreter);

            reader.StartReadingCommands();
        }
    }
}