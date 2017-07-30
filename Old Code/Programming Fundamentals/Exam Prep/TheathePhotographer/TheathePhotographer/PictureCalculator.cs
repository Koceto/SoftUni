namespace TheathePhotographer
{
    using System;

    public class PictureCalculator
    {
        public static void Main()
        {
            double picturesTaken = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double percentGoodPictures = double.Parse(Console.ReadLine());
            double timeForUpload = double.Parse(Console.ReadLine());

            var totalTime = picturesTaken * filterTime;
            var picturesToUpload = Math.Ceiling((picturesTaken * percentGoodPictures) / 100);
            totalTime += picturesToUpload * timeForUpload;
            var result = new DateTime();
            var days = Math.Floor(totalTime / (24 * 60 * 60));
            var leftOvers = totalTime % (24 * 60 * 60);

            Console.WriteLine("{0}:{1}",days ,result.AddSeconds(leftOvers).ToString("HH:mm:ss"));
        }
    }
}
