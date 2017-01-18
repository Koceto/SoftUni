using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bgn = 1;
            var bgnToUsd = 1.79549;
            var bgnToEur = 1.95583;
            var bgnToGbp = 2.53405;

            var ammount = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();

            if (from == "USD")
            {
                ammount = ammount * bgnToUsd;
            }
            else if (from == "EUR")
            {
                ammount = ammount * bgnToEur;
            }
            else if (from == "GBP")
            {
                ammount = ammount * bgnToGbp;
            }

            if (to == "USD")
            {
                ammount = ammount / bgnToUsd;
            }
            else if (to == "EUR")
            {
                ammount = ammount / bgnToEur;
            }
            else if (to == "GBP")
            {
                ammount = ammount / bgnToGbp;
            }

            Console.WriteLine("{0} {1}", Math.Round(ammount,2), to);
        }
    }
}
