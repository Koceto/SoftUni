using Bash_Soft.Exceptions;

namespace Bash_Soft.IO.Commands
{
    public class ChangeAbsolutePathCommand : Command
    {
        public ChangeAbsolutePathCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager ioManager) : base(input, data, judge, repository, ioManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }
            string absPath = this.Data[1];
            this.IOManager.ChangeCurrentDirectoryAbsolute(absPath);
        }
    }
}