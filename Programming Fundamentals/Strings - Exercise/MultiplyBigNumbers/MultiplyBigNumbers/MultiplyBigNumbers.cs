namespace SumBignumbers
{
    using System;
    using System.Linq;
    using System.Text;

    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine()
                .TrimStart('0')
                .ToCharArray()
                .Reverse()
                .ToArray();
            var secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber == 0)
            {
                Console.WriteLine("0");
                return;
            }

            Console.WriteLine(SumNumbers(firstNumber, secondNumber).Reverse().ToArray());
        }

        private static string SumNumbers(char[] firstNumber, int secondNumber)
        {
            var sb = new StringBuilder();
            var carryOver = 0;

            for (int i = 0; i < firstNumber.Length; i++)
            {
                var tempRes = int.Parse(firstNumber[i].ToString()) * secondNumber + carryOver;

                if (tempRes > 9 && i != firstNumber.Length - 1)
                {
                    var temp = tempRes.ToString();
                    carryOver = int.Parse(temp[0].ToString());
                    var sum = int.Parse(temp[1].ToString());
                    sb.Append(sum);
                }
                else
                {
                    sb.Append(tempRes.ToString().Reverse().ToArray());
                    carryOver = 0;
                }
            }
            return sb.ToString();
        }
    }
}