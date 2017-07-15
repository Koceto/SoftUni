using System.Text;
using Bash_Soft.Exceptions;

namespace Bash_Soft.IO.Commands
{
    public class GetHelpCommand : Command
    {
        public GetHelpCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager ioManager) : base(input, data, judge, repository, ioManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 1)
            {
                throw new InvalidCommandException(this.Input);
            }
            DisplayHelp();
        }

        private void DisplayHelp()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine()
                .AppendLine($"{"Description",-20}|{"Command",-20}|{"Parameters",-20}")
                .AppendLine(new string('-', 60))
                .AppendLine($"{"Open",-20}|{"\"open\"",-20}|{"<name>",-20}")
                .AppendLine($"{"Show Students",-20}|{"\"show\"",-20}|{"<courseName>",-20}")
                .AppendLine($"{"Show All Courses",-20}|{"\"showAll\"",-20}")
                .AppendLine($"{"Create Folder",-20}|{"\"mkdir\"",-20}|{"<name>",-20}")
                .AppendLine($"{"Traverse Directory",-20}|{"\"ls\"",-20}|{"<depth>",-20}")
                .AppendLine($"{"Compare Files",-20}|{"\"cmp\"",-20}|{"<path1> <path2>",-20}")
                .AppendLine($"{"Change Directory",-20}|{"\"cdRel\"",-20}|{"<relative path>",-20}")
                .AppendLine($"{"Change Directory",-20}|{"\"cdAbs\"",-20}|{"<absolute path>",-20}")
                .AppendLine($"{"Read Database",-20}|{"\"readDb\"",-20}|{"<filename>",-20}")
                .AppendLine($"{"Drop Database",-20}|{"\"dropDb\"",-20}")
                .AppendLine(new string('-', 60))
                .AppendLine("Other Commands:")
                .AppendLine("\"filter\" <courseName> <excelent/average/poor>  <take [2/5/all]>")
                .AppendLine("\"order\" <courseName> <ascending/descending> <take [10/20/all]>");

            OutputWriter.WriteMessageOnNewLine(info.ToString());
        }
    }
}