using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ammount of pictures
            long picturesAmmount = long.Parse(Console.ReadLine());
            // Ammount of time for filter per picture
            long filterTime = long.Parse(Console.ReadLine());
            // Percentage of good pictures
            long goodPicturePercent = long.Parse(Console.ReadLine());
            // Time needed for upload per picture
            long uploadTime = long.Parse(Console.ReadLine());
            // The ammount of good pictures that will be uploaded
            double goodPicture = (double)picturesAmmount * goodPicturePercent / 100;
            goodPicture = Math.Ceiling(goodPicture);
            // The time invested in filtering the pictures plus the time taken for uploading the GOOD ones, IN SECONDS
            long totalFilterTimeInSecond = (picturesAmmount * filterTime) + ((long)goodPicture * uploadTime);
            
            TimeSpan time = TimeSpan.FromSeconds(totalFilterTimeInSecond);
            string watch = time.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(watch);
        }
    }
}
