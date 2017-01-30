using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    public class AppendLists
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split('|').ToList();

            numbers.Reverse();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
