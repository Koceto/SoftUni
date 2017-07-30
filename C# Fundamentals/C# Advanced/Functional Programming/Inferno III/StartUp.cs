namespace Inferno_III
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StartUp
    {
        public static void Main()
        {
            Func<List<int>, int> Sum = arr =>
             {
                 int sum = 0;

                 foreach (var i in arr)
                 {
                     sum += i;
                 }

                 return sum;
             };

            Func<int[], CommandParameters, List<int>, List<int>> CommandExecutor = (arr, currCommand, currentIndex) =>
            {
                string method = currCommand.Method;
                int parameter = currCommand.Parameter;

                if (method == "Sum Left")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        List<int> leftArr = new List<int>(arr.Take(i + 1));

                        if (Sum(leftArr) == parameter)
                        {
                            currentIndex.Add(i);
                        }
                        else if (Sum(leftArr) > parameter)
                        {
                            break;
                        }
                    }
                }
                if (method == "Sum Right")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        List<int> rightArr = new List<int>(arr.Skip(i));

                        if (Sum(rightArr) == parameter)
                        {
                            currentIndex.Add(i);
                        }
                        else if (Sum(rightArr) > parameter)
                        {
                            break;
                        }
                    }
                }
                if (method == "Sum Left Right")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        var currentSum = arr[i] + (i - 1 < 0 ? 0 : arr[i - 1]) + (i + 1 > arr.Length - 1 ? 0 : arr[i + 1]);

                        if (currentSum == parameter)
                        {
                            currentIndex.Add(i);
                        }
                    }
                }

                return currentIndex;
            };

            int[] numbers = Console.ReadLine()
                         .Split(' ')
                         .Select(int.Parse)
                         .ToArray();
            var commandQueue = new List<CommandParameters>();
            string command = String.Empty;
            List<int> indexes = new List<int>();

            while ((command = Console.ReadLine()) != "Forge")
            {
                string[] temp = command.Split(';');
                string action = temp[0];
                string method = temp[1];
                int parameter = int.Parse(temp[2]);

                CommandParameters currentCommandParameters = new CommandParameters()
                {
                    Method = method,
                    Parameter = parameter
                };

                if (action == "Exclude")
                {
                    commandQueue.Add(currentCommandParameters);
                }
                else if (action == "Reverse")
                {
                    int index = commandQueue.FindLastIndex(c => c.Method == method && c.Parameter == parameter);
                    commandQueue.RemoveAt(index);
                }
            }

            foreach (var currentCommand in commandQueue)
            {
                CommandExecutor(numbers, currentCommand, indexes);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!indexes.Contains(i))
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}