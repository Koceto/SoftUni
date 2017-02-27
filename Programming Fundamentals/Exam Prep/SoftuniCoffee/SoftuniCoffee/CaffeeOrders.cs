namespace SoftuniCoffee
{
    using System;
    using System.Globalization;

    public class CaffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var totalMoney = default(decimal);

            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(
                    Console.ReadLine(),
                    "d/M/yyyy",
                    CultureInfo.InvariantCulture);
                var capsuleAmmount = long.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var result = daysInMonth * capsuleAmmount * pricePerCapsule;
                totalMoney += result;

                Console.WriteLine($"The price for the coffee is: ${result:f2}");
            }
            Console.WriteLine($"Total: ${totalMoney:f2}");
        }
    }
}
