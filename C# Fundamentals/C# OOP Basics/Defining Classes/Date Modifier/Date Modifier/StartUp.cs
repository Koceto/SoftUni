using System;

namespace Date_Modifier
{
    public class StartUp
    {
        public static void Main()
        {
            string firstInputLine = Console.ReadLine();
            string secondInputLine = Console.ReadLine();

            DateModifier dateModifier = new DateModifier(firstInputLine, secondInputLine);

            Console.WriteLine(dateModifier.Difference);
        }
    }
}