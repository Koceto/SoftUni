using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int duration = int.Parse(Console.ReadLine());
            decimal studioDiscount = 0M;
            decimal apartmentDiscount = 0M;
            decimal studioPrice = 0M;
            decimal apartmentPrice = 0M;

            if (month.ToLower() == "may" || month.ToLower() == "october")
            {
                studioPrice = 50M;
                apartmentPrice = 65M;
                studioDiscount = duration > 7 && duration < 14 ? studioDiscount = 0.05M :
                    duration > 14 ? studioDiscount = 0.3M : studioDiscount = 0M;
                apartmentDiscount = duration > 14 ? apartmentDiscount = 0.1M : apartmentDiscount = 0M;
            }
            else if (month.ToLower() == "june" || month.ToLower() == "september")
            {
                studioPrice = 75.20M;
                apartmentPrice = 68.70M;
                studioDiscount = duration > 14 ? studioDiscount = 0.2M : studioDiscount = 0M;
                apartmentDiscount = duration > 14 ? apartmentDiscount = 0.1m : apartmentDiscount = 0M;
            }
            else
            {
                studioPrice = 76M;
                apartmentPrice = 77M;
                apartmentDiscount = duration > 14 ? apartmentDiscount = 0.1M : apartmentDiscount = 0M;
            }
            studioDiscount = (duration * studioPrice) * studioDiscount;
            studioPrice = duration * studioPrice - studioDiscount;

            apartmentDiscount = (duration * apartmentPrice) * apartmentDiscount;
            apartmentPrice = duration * apartmentPrice - apartmentDiscount;

            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
        }
    }
}
