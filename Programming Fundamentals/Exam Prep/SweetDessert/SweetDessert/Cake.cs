namespace SweetDessert
{
    using System;

    public class Cake
    {
        public static void Main()
        {
            var currMoney = decimal.Parse(Console.ReadLine());
            var guestCount = long.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());    //Per Unit
            var eggPrice = decimal.Parse(Console.ReadLine());   //Per Unit
            var berriesPrice = decimal.Parse(Console.ReadLine());   //Per Kilogram
            var portionsToCook = guestCount;

            while (portionsToCook % 6 !=0)
            {
                portionsToCook++;
            }

            var bananasNeeded = (portionsToCook / 6) * 2;
            var eggsNeeded = (portionsToCook / 6) * 4;
            var berriesNeeded = (portionsToCook / 6) * 0.2M;

            var totalBill = (bananasNeeded * bananaPrice) + (eggsNeeded * eggPrice) + (berriesNeeded * berriesPrice);

            if (totalBill <= currMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalBill:f2}lv.");
            }
            else
            {
                var moneyNeeded = totalBill - currMoney;

                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
