using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string type = "";

            switch (fruit)
            {
                case "banana":
                    type = "fruit";
                    break;
                case "apple":
                    type = "fruit";
                    break;
                case "kiwi":
                    type = "fruit";
                    break;
                case "cherry":
                    type = "fruit";
                    break;
                case "lemon":
                    type = "fruit";
                    break;
                case "grapes":
                    type = "fruit";
                    break;
                case "tomato":
                    type = "vegetable";
                    break;
                case "cucumber":
                    type = "vegetable";
                    break;
                case "pepper":
                    type = "vegetable";
                    break;
                case "carrot":
                    type = "vegetable";
                    break;
                default:
                    type = "unknown";
                    break;
            }
            Console.WriteLine(type);
        }
    }
}
