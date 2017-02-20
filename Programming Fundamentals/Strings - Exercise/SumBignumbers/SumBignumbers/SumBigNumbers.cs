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
            var secondNumber = Console.ReadLine()
                .TrimStart('0')
                .ToCharArray()
                .Reverse()
                .ToArray();

            if (firstNumber.Length >= secondNumber.Length)
            {
                Console.WriteLine(SumNumbers(firstNumber, secondNumber).Reverse().ToArray());
            }
            else
            {
                Console.WriteLine(SumNumbers(secondNumber, firstNumber).Reverse().ToArray());
            }
        }

        private static string SumNumbers(char[] firstNumber, char[] secondNumber)
        {
            var sb = new StringBuilder();
            var carryOver = 0;

            for (int i = 0; i < firstNumber.Length; i++)
            {
                if (secondNumber.Length > i)
                {
                    var firstNum = int.Parse(firstNumber[i].ToString());
                    var secondNum = int.Parse(secondNumber[i].ToString());
                    var sum = firstNum + secondNum;

                    if (sum + carryOver > 9 && i != firstNumber.Length - 1)
                    {
                        var temp = (sum + carryOver).ToString();
                        carryOver = int.Parse(temp[0].ToString());
                        sum = int.Parse(temp[1].ToString());
                        sb.Append(sum);
                    }
                    else
                    {
                        var tempRes = sum + carryOver;
                        sb.Append(tempRes.ToString().Reverse().ToArray());
                        carryOver = 0;
                    }
                }
                else
                {
                    var firstNum = int.Parse(firstNumber[i].ToString());
                    var sum = firstNum;

                    if (sum + carryOver > 9 && i != firstNumber.Length - 1)
                    {
                        var temp = (sum + carryOver).ToString();
                        carryOver = int.Parse(temp[0].ToString());
                        sum = int.Parse(temp[1].ToString());
                        sb.Append(sum);
                    }
                    else
                    {
                        var tempRes = sum + carryOver;
                        sb.Append(tempRes.ToString().Reverse().ToArray());
                        carryOver = 0;
                    }
                }
            }
            return sb.ToString();
        }
    }
}
