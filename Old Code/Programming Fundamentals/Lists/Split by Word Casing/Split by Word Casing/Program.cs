using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            var separators = new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' };
            var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var upperCaseWords = new List<string>();
            var lowerCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            foreach (var word in words)
            {
                bool isLowerCase = true;
                bool isUpperCase = true;
                var letters = word.ToCharArray();

                for (int i = 0; i < letters.Length; i++)
                {
                    if (char.IsUpper(letters[i]))
                    {
                        isLowerCase = false;
                    }
                    else if (char.IsLower(letters[i]))
                    {
                        isUpperCase = false;
                    }
                    else
                    {
                        isUpperCase = false;
                        isLowerCase = false;
                    }
                }

                if (isLowerCase)
                {
                    lowerCaseWords.Add(word);
                }
                else if (isUpperCase)
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));

        }
    }
}
