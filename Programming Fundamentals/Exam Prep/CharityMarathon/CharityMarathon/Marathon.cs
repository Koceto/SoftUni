namespace CharityMarathon
{
    using System;

    public class Marathon
    {
        public static void Main()
        {
            int marathonDays = int.Parse(Console.ReadLine());
            int numberOfParticipants = int.Parse(Console.ReadLine());
            double lapsForRunners = double.Parse(Console.ReadLine());
            double trackLength = double.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());
            var runningParticipants = Math.Min(marathonDays * trackCapacity, numberOfParticipants);
            var kilometers = (runningParticipants * lapsForRunners * trackLength) / 1000;

            Console.WriteLine("Money raised: {0:f2}", (decimal)kilometers * moneyPerKilometer);
        }
    }
}
