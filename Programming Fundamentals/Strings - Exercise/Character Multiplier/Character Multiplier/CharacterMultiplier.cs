namespace Character_Multiplier
{
    using System;

    class CharacterMultiplier
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split();
            var result = 0;
            var firstString = input[0].ToCharArray();
            var secondString = input[1].ToCharArray();

            for (int i = 0; i < Math.Max(firstString.Length, secondString.Length); i++)
            {
                if (firstString.Length > i && secondString.Length > i)
                {
                    result += firstString[i] * secondString[i];
                }
                else if (firstString.Length <= i && secondString.Length >= i)
                {
                    result += secondString[i];
                }
                else
                {
                    result += firstString[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
