namespace WinningTicket
{
    using System;
    using System.Linq;

    public class TicketChecket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(new[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var winningSymbols = new char[] { '@', '#', '$', '^' };

            foreach (var ticket in tickets)
            {
                var firstCounter = 1;
                var firstMaxCounter = 5;
                var firstWinningSymbol = ' ';
                var secondCounter = 1;
                var secondMaxCounter = 5;
                var secondWinningSymbol = ' ';

                if (ticket.Length == 20)
                {
                    for (int i = 1; i < 10; i++)
                    {
                        var firstPrev = ticket[i - 1];
                        var firstCurrent = ticket[i];
                        var secondPrev = ticket[i - 1 + 10];
                        var secondCurrent = ticket[i + 10];

                        // Left part check
                        if (firstCurrent == firstPrev)
                        {
                            firstCounter++;
                        }
                        else
                        {
                            firstCounter = 1;
                        }
                        if (firstCounter >= 6)
                        {
                            firstWinningSymbol = ticket[i];
                        }
                        if (firstCounter > firstMaxCounter)
                        {
                            firstMaxCounter = firstCounter;
                        }

                        // Right part check
                        if (secondCurrent == secondPrev)
                        {
                            secondCounter++;
                        }
                        else
                        {
                            secondCounter = 1;
                        }
                        if (secondCounter >= 6)
                        {
                            secondWinningSymbol = ticket[i + 10];
                        }
                        if (secondCounter > secondMaxCounter)
                        {
                            secondMaxCounter = secondCounter;
                        }
                    }
                }

                if (secondMaxCounter > 5 && firstMaxCounter > 5 && firstWinningSymbol.Equals(secondWinningSymbol) && winningSymbols.Contains(firstWinningSymbol))
                {
                    var matchingLength = Math.Min(secondMaxCounter, firstMaxCounter);

                    if (matchingLength < 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {matchingLength}{firstWinningSymbol}");
                    }
                    else if (firstMaxCounter == 10 && secondMaxCounter == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {matchingLength}{firstWinningSymbol} Jackpot!");
                    }
                }
                else if (ticket.Length == 20)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                else
                {
                    Console.WriteLine($"invalid ticket");
                }
            }
        }
    }
}
