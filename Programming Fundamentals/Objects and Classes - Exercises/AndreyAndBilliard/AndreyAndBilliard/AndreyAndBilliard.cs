using System;
using System.Collections.Generic;

public class CustomerOrders
{
    public Dictionary<string, int> Orders { get; set; }
};

namespace AndreyAndBilliard
{
    public class AndreyAndBilliard
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var menu = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var manuInput = Console.ReadLine()
                    .Split('-');
                var product = manuInput[0];
                var price = decimal.Parse(manuInput[1]);

                menu.Remove(product);
                menu.Add(product, price);
            }

            var clients = new SortedDictionary<string, CustomerOrders>();

            while (true)
            {
                var orders = Console.ReadLine()
                    .Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (orders[0].ToLower() == "end of clients")
                {
                    var totalBill = 0M;

                    foreach (var client in clients)
                    {
                        var currBill = 0M;

                        Console.WriteLine(client.Key);

                        foreach (var item in client.Value.Orders)
                        {
                            Console.WriteLine($"-- {item.Key} - {item.Value}");
                            currBill += item.Value * menu[item.Key];
                        }

                        Console.WriteLine($"Bill: {currBill:f2}");

                        totalBill += currBill;
                    }
                    Console.WriteLine($"Total bill: {totalBill:f2}");
                    return;
                }

                var currClient = orders[0];
                var currProduct = orders[1];
                var currAmmount = int.Parse(orders[2]);

                if (menu.ContainsKey(currProduct))
                {
                    if (!clients.ContainsKey(currClient))
                    {
                        clients[currClient] = new CustomerOrders
                        {
                            Orders = new Dictionary<string, int>()
                        };
                    }
                    if (!clients[currClient].Orders.ContainsKey(currProduct))
                    {
                        clients[currClient].Orders.Add(currProduct, currAmmount);
                    }
                    else
                    {
                        clients[currClient].Orders[currProduct] += currAmmount;
                    }
                }
            }
        }
    }
}
