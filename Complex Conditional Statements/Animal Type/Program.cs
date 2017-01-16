using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine().ToLower();
            string type = "";

            switch (animal)
            {
                case "dog":
                    type = "mammal";
                    break;
                case "crocodile":
                    type = "reptile";
                    break;
                case "tortoise":
                    type = "reptile";
                    break;
                case "snake":
                    type = "reptile";
                    break;
                default:
                    type = "unknown";
                    break;
            }
            Console.WriteLine(type);
        }
    }
}
