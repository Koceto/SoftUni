namespace RageQuit
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Collections.Generic;

    public class JustQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .ToUpper();
            var regex = new Regex(@"[\D]+[0-9]+");
            var result = regex.Matches(input);
            var message = new StringBuilder();

            foreach (Match item in result)
            {
                var digits = @"[\d]+";
                var letters = @"[\D]+";
                var number = Regex.Match(item.ToString(), digits);
                var chars = Regex.Match(item.ToString(), letters);
                
                for (int i = 0; i < int.Parse(number.ToString()); i++)
                {
                    message.Append(chars);
                }
            }

            var finalMessage = message.ToString();
            var stupidUselessExerciseVariableTotalyUnnecesery = finalMessage.ToCharArray().Distinct().Count();

            Console.WriteLine("Unique symbols used: " + stupidUselessExerciseVariableTotalyUnnecesery);
            Console.WriteLine(finalMessage);
        }
    }
}
