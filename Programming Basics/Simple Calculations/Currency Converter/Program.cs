using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumber
{
    class CountNumber
    {
        static void Main(string[] args)
        {
            var moneyToConvert = decimal.Parse(Console.ReadLine());
            var firstCurrency = Console.ReadLine();
            var secondCurrency = Console.ReadLine();
            Dictionary<string, decimal> currencies = new Dictionary<string, decimal>() { { "BGN", 1 }, { "USD", 1.79549m }, { "EUR", 1.95583m }, { "GBP", 2.53405m } };
            var result = moneyToConvert * (currencies[firstCurrency] / currencies[secondCurrency]);
            Console.WriteLine("{0} {1}", Math.Round(result, 2), secondCurrency);
        }
    }
}