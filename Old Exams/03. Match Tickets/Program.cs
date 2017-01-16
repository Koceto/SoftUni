using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int members = int.Parse(Console.ReadLine());

            decimal vipTicketCost = 499.99M;
            decimal normalTicketCost = 249.99M;

            double transportBudget = 0.0;

            if (members >= 1 && members <= 4)
                transportBudget = 0.75;
            else if (members >= 5 && members <= 9)
                transportBudget = 0.60;
            else if (members >= 10 && members <= 24)
                transportBudget = 0.50;
            else if (members >= 25 && members <= 49)
                transportBudget = 0.40;
            else
                transportBudget = 0.25;

            budget = budget - (budget * (decimal)transportBudget);
            budget = budget / members;

            if (budget >= vipTicketCost && ticketType.ToLower() == "vip")
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.",
                    (budget - vipTicketCost) * members);
            }
            else if (budget >= normalTicketCost && ticketType.ToLower() == "normal")
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.",
                    (budget - normalTicketCost) * members);
            }
            else if (budget <= vipTicketCost && ticketType.ToLower() == "vip")
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.",
                    (vipTicketCost - budget) * members);
            }
            else if (budget <= normalTicketCost && ticketType.ToLower() == "normal")
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.",
                    (normalTicketCost - budget) * members);
            }
        }
    }
}
