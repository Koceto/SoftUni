namespace Bash_Soft.IO.Commands
{
    public class ChangeRelativePathCommand : Command
    {
        public ChangeRelativePathCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager ioManager) : base(input, data, judge, repository, ioManager)
        {
        }

        public override void Execute()
        {
            string relPath = this.Data[1];

            this.IOManager.ChangeCurrentDirectoryRelative(relPath);
        }
    }
}