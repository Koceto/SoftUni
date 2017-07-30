using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysPerMonth = int.Parse(Console.ReadLine());
            decimal moneyEarnedPerDay = decimal.Parse(Console.ReadLine());
            double usdToBgn = double.Parse(Console.ReadLine());

            decimal monthlyEarnings = workingDaysPerMonth * moneyEarnedPerDay;
            decimal yearlyEarnings = monthlyEarnings * 12M;
            decimal yearlyBonus = monthlyEarnings * 2.5M;
            decimal yearlyTax = (yearlyEarnings + yearlyBonus) * 0.25M;

            decimal levaToSpend = ((yearlyEarnings + yearlyBonus - yearlyTax) * (decimal)usdToBgn) / 365M;

            Console.WriteLine("{0:f2}", levaToSpend);
        }
    }
}
