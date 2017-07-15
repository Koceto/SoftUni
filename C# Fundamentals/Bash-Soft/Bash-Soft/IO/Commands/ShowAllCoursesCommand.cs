using Bash_Soft.Exceptions;

namespace Bash_Soft.IO.Commands
{
    public class ShowAllCoursesCommand : Command
    {
        public ShowAllCoursesCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager ioManager) : base(input, data, judge, repository, ioManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length > 1)
            {
                throw new InvalidCommandException(this.Input);
            }

            if (this.Repository.Courses.Count == 0)
            {
                throw new InvalidDataBaseException();
            }

            foreach (var kvp in this.Repository.Courses)
            {
                OutputWriter.WriteMessageOnNewLine(kvp.Key);
            }
        }
    }
}