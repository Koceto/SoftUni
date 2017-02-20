using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__Name_
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(AddNameToString(Console.ReadLine()));
        }

        private static string AddNameToString(string name)
        {
            string helloName = $"Hello, {name}!";
            return helloName;
        }
    }
}
