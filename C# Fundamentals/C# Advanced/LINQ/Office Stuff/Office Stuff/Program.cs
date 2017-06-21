using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Office_Stuff
{
    public class Company
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Order
    {
        public string Name { get; set; }
        public int Ammount { get; set; }
    }

    internal class Program
    {
        public const string OrderPattern = @"\|(\w+) - (\d+) - (\w+)\|";

        private static void Main()
        {
            List<Company> allOrders = new List<Company>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, OrderPattern);
                string currCompany = match.Groups[1].ToString();
                string currOrder = match.Groups[3].ToString();
                int currAmmount = int.Parse(match.Groups[2].ToString());
                Company currentCompany = allOrders.FirstOrDefault(c => c.Name == currCompany);

                if (currentCompany != null)
                {
                    Order currentOrder = currentCompany.Orders.FirstOrDefault(o => o.Name == currOrder);

                    if (currentOrder != null)
                    {
                        currentOrder.Ammount += currAmmount;
                    }
                    else
                    {
                        currentCompany.Orders.Add(new Order()
                        {
                            Name = currOrder,
                            Ammount = currAmmount
                        });
                    }
                }
                else
                {
                    allOrders.Add(new Company()
                    {
                        Name = currCompany,
                        Orders = new List<Order>()
                        {
                            new Order()
                            {
                                Name = currOrder,
                                Ammount = currAmmount
                            }
                        }
                    });
                }
            }

            foreach (var company in allOrders.OrderBy(c => c.Name))
            {
                var temp = new List<string>();

                foreach (var companyOrder in company.Orders)
                {
                    temp.Add($"{companyOrder.Name}-{companyOrder.Ammount}");
                }

                Console.WriteLine($"{company.Name}: {string.Join(", ", temp)}");
            }
        }
    }
}