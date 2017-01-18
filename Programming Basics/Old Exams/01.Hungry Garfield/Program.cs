using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hungry_Garfield
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyInUSD = decimal.Parse(Console.ReadLine());
            decimal usdToLev = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine()) / usdToLev;
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine()) / usdToLev;
            decimal sandwichPrice = decimal.Parse(Console.ReadLine()) / usdToLev;
            long pizzaAmmount = long.Parse(Console.ReadLine());
            long lasagnaAmmount = long.Parse(Console.ReadLine());
            long sandwichAmmount = long.Parse(Console.ReadLine());

            decimal pizzaMoney = pizzaPrice * pizzaAmmount;
            decimal lasagnaMoney = lasagnaPrice * lasagnaAmmount;
            decimal sandwichMoney = sandwichPrice * sandwichAmmount;

            decimal foodMoney = pizzaMoney + lasagnaMoney + sandwichMoney;

            if (moneyInUSD - foodMoney >= 0)
            {
                foodMoney = Math.Abs(moneyInUSD - foodMoney);
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", foodMoney);
            }
            else
            {
                foodMoney = Math.Abs(foodMoney - moneyInUSD);
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", foodMoney);
            }
        }
    }
}