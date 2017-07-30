using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string tittle = "";

            switch (gender)
            {
                case "f":
                    if (age >= 16)
                    {
                        tittle = "Ms.";
                    }
                    else
                    {
                        tittle = "Miss";
                    }
                    break;

                case "m":
                    if (age >= 16)
                    {
                        tittle = "Mr.";
                    }
                    else
                    {
                        tittle = "Master";
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine(tittle.ToLower());
        }
    }
}
