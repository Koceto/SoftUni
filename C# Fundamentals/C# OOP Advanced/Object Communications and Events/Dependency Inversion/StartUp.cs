using System;

namespace Dependency_Inversion
{
    public class StartUp
    {
        public static void Main()
        {
            AdditionStrategy addition = new AdditionStrategy();
            PrimitiveCalculator primitiveCalculator = new PrimitiveCalculator(addition);

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(' ');

                if (commandArgs[0] == "mode")
                {
                    primitiveCalculator.ChangeStrategy(commandArgs[1][0]);
                }
                else
                {
                    Console.WriteLine(primitiveCalculator.PerformCalculation(int.Parse(commandArgs[0]), int.Parse(commandArgs[1])));
                }
            }
        }
    }
}