namespace SoftuniCoffeeOrdersTheSecond
{
    using System;
    using System.Globalization;

    public class CoffeeOrders
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var totalPrice = default(decimal);

            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var orderAmmount = long.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var totalAmmount = orderAmmount * daysInMonth;
                var orderPrice = pricePerCapsule * totalAmmount;

                totalPrice += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
