using System;
using System.Collections.Generic;
using System.Linq;

namespace Sales_Report
{
    public class SalesReport
    {
        public static void Main()
        {
            int n =  int.Parse(Console.ReadLine());
            var Sales = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ');
                decimal money = decimal.Parse(input[2]) * decimal.Parse(input[3]);
                var city = input[0];

                if (!Sales.ContainsKey(city))
                {
                    Sales[city] = 0;
                }

                Sales[input[0]] += money;
            }

            foreach (var item in Sales)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
