using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Party_Reservation_Filter_Module
{
    public static class StartUp
    {
        public static void Main()
        {
            Func<string, string, string, bool> NameChecker = (name, method, parameter) =>
            {
                var n = 0;

                if (name.IndexOf(parameter) == 0 && method == "Starts with")
                {
                    return true;
                }
                if (name.IndexOf(parameter) == name.Length - parameter.Length && method == "Ends with")
                {
                    return true;
                }
                if (method == "Contains" && name.Contains(parameter))
                {
                    return true;
                }
                if (int.TryParse(parameter, out n) && method == "Length")
                {
                    if (name.Length == n)
                    {
                        return true;
                    }
                }

                return false;
            };

            string[] guestsList = Console.ReadLine()
                            .Split(' ');
            var commandQueue = new List<CommandParameters>();
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Print")
            {
                string[] temp = command.Split(';');
                string action = temp[0];
                string method = temp[1];
                string parameter = temp[2];

                CommandParameters currCommandParameters = new CommandParameters()
                {
                    Action = action,
                    Method = method,
                    Parameter = parameter
                };

                if (action == "Add filter")
                {
                    commandQueue.Add(currCommandParameters);
                }
                else if (action == "Remove filter")
                {
                    commandQueue.RemoveAll(c => c.Method == method && c.Parameter == parameter);
                }
            }

            foreach (var currentCommand in commandQueue)
            {
                guestsList = guestsList
                        .Where(n => !NameChecker(n, currentCommand.Method, currentCommand.Parameter))
                        .ToArray();
            }

            Console.WriteLine(string.Join(" ", guestsList));
        }
    }
}