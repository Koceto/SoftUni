using System;

namespace Cubic_s_Rube
{
    public static class StartUp
    {
        private const string EndCommand = "Analyze";

        public static void Main()
        {
            int dimention = int.Parse(Console.ReadLine());
            int numberCells = dimention * dimention * dimention;
            long particlesAmmount = 0L;
            string input;

            while ((input = Console.ReadLine()) != EndCommand)
            {
                string[] data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int x = int.Parse(data[0]);
                int y = int.Parse(data[1]);
                int z = int.Parse(data[2]);
                int currentAmmount = int.Parse(data[3]);

                if (x >= 0 && x < dimention &&
                    y >= 0 && y < dimention &&
                    z >= 0 && z < dimention &&
                    currentAmmount != 0)
                {
                    numberCells--;
                    particlesAmmount += currentAmmount;
                }
            }

            Console.WriteLine(particlesAmmount);
            Console.WriteLine(numberCells);
        }
    }
}