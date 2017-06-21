using System.Diagnostics;

namespace Bash_Soft
{
    internal class CommandInterpreter
    {
        public static void InterpredCommand(string input)

        {
            string[] data = input.Split(' ');
            string command = data[0];

            switch (command)
            {
                case "open":
                    TryOpenFi1e(input, data);
                    break;

                case "mkdir":
                    TryCreateDirectory(input, data);
                    break;

                case "ls":
                    TryTraverseFolders(input, data);
                    break;

                case "cmp":
                    TryCompareFiles(input, data);
                    break;

                case "cdRel":
                    TryChangePathRelatively(input, data);
                    break;

                case "cdAbs":
                    TryChangePathAbsolute(input, data);
                    break;

                case "readDb":
                    TryReadDatabaseFromFile(input, data);
                    break;

                case "help":
                    TryGetHelp(input, data);
                    break;

                case "show":
                    TryShowWanterData(input, data);
                    break;

                case "filter":
                    TryFilterAndTake(input, data);
                    break;

                case "order":
                    TryOrderAndTake(input, data);
                    break;

                default:
                    DisplayInvalidCommandMessage(input);
                    break;
            }
        }

        private static void TryOrderAndTake(string input, string[] data)
        {
            if (data.Length == 5)
            {
                string courseName = data[1];
                string filter = data[2].ToLower();
                string takeCommand = data[3].ToLower();
                string takeQuantity = data[4].ToLower();

                TryParseParametersForOrderAndTake(takeCommand, takeQuantity, courseName, filter);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private static void TryParseParametersForOrderAndTake(string takeCommand, string takeQuantity, string courseName, string filter)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    StudentsRepository.OrderAndTake(courseName, filter);
                }
                else
                {
                    int studentstotake;
                    bool hasparsed = int.TryParse(takeQuantity, out studentstotake);

                    if (hasparsed)
                    {
                        StudentsRepository.OrderAndTake(courseName, filter, studentstotake);
                    }
                    else
                    {
                        OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
                    }
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidTakeCommand);
            }
        }

        private static void TryFilterAndTake(string input, string[] data)
        {
            if (data.Length == 5)
            {
                string courseName = data[1];
                string filter = data[2].ToLower();
                string takeCommand = data[3].ToLower();
                string takeQuantity = data[4].ToLower();

                TryParseParametersForFilterAndTake(takeCommand, takeQuantity, courseName, filter);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private static void TryParseParametersForFilterAndTake(string takeCommand, string takeQuantity, string courseName, string filter)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    StudentsRepository.FilterAndTake(courseName, filter);
                }
                else
                {
                    int studentstotake;
                    bool hasparsed = int.TryParse(takeQuantity, out studentstotake);

                    if (hasparsed)
                    {
                        StudentsRepository.FilterAndTake(courseName, filter, studentstotake);
                    }
                    else
                    {
                        OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
                    }
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidTakeCommand);
            }
        }

        private static void TryShowWanterData(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string courseName = data[1];
                StudentsRepository.GetAllStudentsFromCourse(courseName);
            }
            else if (data.Length == 3)
            {
                string courseName = data[1];
                string userName = data[2];
                StudentsRepository.GetStudentScoresFromCourse(courseName, userName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private static void DisplayInvalidCommandMessage(string input)
        {
            OutputWriter.WriteMessageOnNewLine($"The command '{input}' is invalid");
        }

        private static void TryGetHelp(string input, string[] data)
        {
            OutputWriter.WriteEmptyLine();
            OutputWriter.WriteMessageOnNewLine($"{"Description",-20}|{"Command",-20}|{"Parameters",-20}");
            OutputWriter.WriteMessageOnNewLine(new string('-', 60));
            OutputWriter.WriteMessageOnNewLine($"{"Create Folder",-20}|{"\"mkdir\"",-20}|{"<name>",-20}");
            OutputWriter.WriteMessageOnNewLine($"{"Traverse Directory",-20}|{"\"ls\"",-20}|{"<depth>",-20}");
            OutputWriter.WriteMessageOnNewLine($"{"Compare Files",-20}|{"\"cmp\"",-20}|{"<path1> <path2>",-20}");
            OutputWriter.WriteMessageOnNewLine($"{"Change Directory",-20}|{"\"changeDirREl\"",-20}|{"<relative path>",-20}");
            OutputWriter.WriteMessageOnNewLine($"{"Change Directory",-20}|{"\"changeDir\"",-20}|{"<absolute path>",-20}");
            OutputWriter.WriteMessageOnNewLine($"{"Read Database",-20}|{"\"readDb\"",-20}|{"<filename>",-20}");
            OutputWriter.WriteEmptyLine();
            OutputWriter.WriteMessageOnNewLine("Other Commands:");
            OutputWriter.WriteMessageOnNewLine($"\"filter\" <courseName> <excelent/average/poor>  <take [2/5/all]>");
            OutputWriter.WriteMessageOnNewLine($"\"order\" <courseName> <ascending/descending> <take [10/20/all]>");
            OutputWriter.WriteEmptyLine();
        }

        private static void TryReadDatabaseFromFile(string input, string[] data)
        {
            string fileName = data[1];
            StudentsRepository.InitializeData(fileName);
        }

        private static void TryChangePathAbsolute(string input, string[] data)
        {
            string absPath = data[1];

            IOManager.ChangeCurrentDirectoryAbsolute(absPath);
        }

        private static void TryChangePathRelatively(string input, string[] data)
        {
            string relPath = data[1];

            IOManager.ChangeCurrentDirectoryRelative(relPath);
        }

        private static void TryCompareFiles(string input, string[] data)
        {
            if (data.Length == 3)
            {
                string firstPath = data[1];
                string secondPath = data[2];

                Tester.CompaeContent(firstPath, secondPath);
            }
        }

        private static void TryTraverseFolders(string input, string[] data)
        {
            if (data.Length == 1)
            {
                IOManager.TraverseDirectory(0);
            }
            else if (data.Length == 2)
            {
                int depth;
                bool hasParsed = int.TryParse(data[1], out depth);

                if (hasParsed)
                {
                    IOManager.TraverseDirectory(depth);
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.UnableToParseNumber);
                }
            }
        }

        private static void TryCreateDirectory(string input, string[] data)
        {
            string folderName = data[1];
            IOManager.CreateDirectoryInCurrentFolder(folderName);
        }

        private static void TryOpenFi1e(string input, string[] data)
        {
            string fileName = data[1];
            Process.Start(SessionData.currentPath + "\\" + fileName);
        }
    }
}