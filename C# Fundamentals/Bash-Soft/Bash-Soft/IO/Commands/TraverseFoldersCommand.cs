using Bash_Soft.Exceptions;

namespace Bash_Soft.IO.Commands
{
    public class TraverseFoldersCommand : Command
    {
        public TraverseFoldersCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager ioManager) : base(input, data, judge, repository, ioManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length == 1)
            {
                this.IOManager.TraverseDirectory(0);
            }
            else if (this.Data.Length == 2)
            {
                int depth;
                bool hasParsed = int.TryParse(this.Data[1], out depth);

                if (hasParsed)
                {
                    this.IOManager.TraverseDirectory(depth);
                }
                else
                {
                    throw new UnableToParseNumberException();
                }
            }
        }
    }
}