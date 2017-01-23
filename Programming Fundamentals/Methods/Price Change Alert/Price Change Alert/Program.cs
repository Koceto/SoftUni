using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Change_Alert
{
    public class priceAlert
    {
        public static void Main()
        {
            int numberOfPrice = int.Parse(Console.ReadLine());
            double priceChange = double.Parse(Console.ReadLine());
            double currentPrice = double.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i < numberOfPrice - 1; i++)
            {
                double prices = double.Parse(Console.ReadLine());
                double difference = DiffCalc(currentPrice, prices);
                bool isSignificantDifference = priceDiff(difference, priceChange);
                result = GetPrice(prices, currentPrice, difference, isSignificantDifference);

                currentPrice = prices;

            Console.WriteLine(result);
            }
        }

        public static string GetPrice(double prices, double currentPrice, double difference, bool isSignificantDifference)
        {
            string result = string.Empty;

            if (difference == 0)
            {
                result = string.Format("NO CHANGE: {0}", prices);
            }
            else if (!isSignificantDifference)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", currentPrice, prices, difference * 100);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", currentPrice, prices, difference * 100);
            }
            else if (isSignificantDifference && (difference < 0))
            {
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", currentPrice, prices, difference * 100);
            }

            return result;
        }
        public static bool priceDiff(double difference, double priceChange)
        {
            if (Math.Abs(difference) >= priceChange)
            {
                return true;
            }
            return false;
        }

        public static double DiffCalc(double currentPrice, double prices)
        {
            double result = (prices - currentPrice) / currentPrice;
            return result;
        }
    }
}
