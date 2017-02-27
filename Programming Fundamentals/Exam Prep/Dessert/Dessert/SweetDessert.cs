namespace Dessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            var currMoney = decimal.Parse(Console.ReadLine());
            var guestCount = int.Parse(Console.ReadLine());
            var bananaPricePerUnit = decimal.Parse(Console.ReadLine());
            var eggPricePerUnit = decimal.Parse(Console.ReadLine());
            var berriesPricePerKilo = decimal.Parse(Console.ReadLine());
            var portionsNeeded = default(int);

            for (int i = 6; i < guestCount + 6; i += 6)
            {
                portionsNeeded = i;
            }

            var bananasNeeded = (portionsNeeded / 6) * 2M;
            var eggsNeeded = (portionsNeeded / 6) * 4M;
            var berriesNeeded = (portionsNeeded / 6) * 0.2M;
            decimal moneyNeeded = (bananasNeeded * bananaPricePerUnit) + (eggsNeeded * eggPricePerUnit) + (berriesNeeded * berriesPricePerKilo);

            if (moneyNeeded > currMoney)
            {
                var moreMoney = moneyNeeded - currMoney;

                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moreMoney:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            }
        }
    }
}
