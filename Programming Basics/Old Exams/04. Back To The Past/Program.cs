using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal fortune = decimal.Parse(Console.ReadLine());
            int yearToSurvive = int.Parse(Console.ReadLine());
            int ageOfIvancho = 18;
            decimal yearlyExpenses = 0M;
            decimal totalExpenses = 0M;

            for (int year = 1800; year <= yearToSurvive; year++, ageOfIvancho++)
            {
                yearlyExpenses = year % 2 != 0 ?
                    yearlyExpenses = 12000 + (50 * ageOfIvancho) :
                    yearlyExpenses = 12000;
                totalExpenses += yearlyExpenses;
            }
            if (totalExpenses <= fortune)
            {
                fortune = fortune - totalExpenses;
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", fortune);
            }
            else
            {

                fortune = totalExpenses - fortune;
                Console.WriteLine("He will need {0:f2} dollars to survive.", fortune);
            }
        }
    }
}
