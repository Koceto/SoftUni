namespace ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Array
    {
        public static void Main()
        {
            var arrList = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input.First() == "end")
                {
                    break;
                }

                switch (input.First())
                {
                    case "exchange":

                        var index = int.Parse(input.Last());

                        if (index < 0
                            || index >= arrList.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }

                        var temp = arrList
                            .Take(index + 1)
                            .ToArray();

                        arrList.RemoveRange(0, index + 1);
                        arrList.AddRange(temp);

                        break;
                    case "max":

                        if (input.Last() == "even")
                        {
                            if (!arrList.Any(n => n % 2 == 0))
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var maxEven = arrList.FindAll(n => n % 2 == 0).Max();

                                Console.WriteLine(arrList.LastIndexOf(maxEven));
                            }
                        }
                        else if (input.Last() == "odd")
                        {
                            if (arrList.Any(n => n % 2 != 0))
                            {
                                var maxEven = arrList.FindAll(n => n % 2 != 0).Max();

                                Console.WriteLine(arrList.LastIndexOf(maxEven));
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }

                        break;
                    case "min":

                        if (input.Last() == "even")
                        {
                            if (arrList.Any(n => n % 2 == 0))
                            {
                                var maxEven = arrList.FindAll(n => n % 2 == 0).Min();

                                Console.WriteLine(arrList.LastIndexOf(maxEven));
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        else if (input.Last() == "odd")
                        {
                            if (!arrList.Any(n => n % 2 != 0))
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var maxEven = arrList.FindAll(n => n % 2 != 0).Min();

                                Console.WriteLine(arrList.LastIndexOf(maxEven));
                            }
                        }

                        break;
                    case "first":
                        
                        var firstCount = int.Parse(input[1]);

                        if (firstCount < 0
                            || firstCount > arrList.Count)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }

                        if (input.Last() == "even")
                        {
                            if (arrList.Any(n => n % 2 == 0))
                            {
                                var firstEven = arrList.FindAll(n => n % 2 == 0).Take(firstCount).ToArray();

                                Console.WriteLine("[{0}]", string.Join(", ", firstEven));
                            }
                            else
                            {
                                Console.WriteLine("[]");
                            }
                        }
                        else if (input.Last() == "odd")
                        {
                            if (arrList.Any(n => n % 2 != 0))
                            {
                                var firstOdd = arrList.FindAll(n => n % 2 != 0).Take(firstCount).ToArray();

                                Console.WriteLine("[{0}]", string.Join(", ", firstOdd));
                            }
                            else
                            {
                                Console.WriteLine("[]");
                            }
                        }

                        break;
                    case "last":
                        
                        var lastCount = int.Parse(input[1]);

                        if (lastCount < 0
                            || lastCount > arrList.Count)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }

                        if (input.Last() == "even")
                        {
                            if (arrList.Any(n => n % 2 == 0))
                            {
                                var lastEven = arrList.FindAll(n => n % 2 == 0).ToArray();

                                lastEven = lastEven.Reverse().ToArray();

                                var result = lastEven.Take(lastCount).Reverse().ToArray();

                                Console.WriteLine("[{0}]", string.Join(", ", result));
                            }
                            else
                            {
                                Console.WriteLine("[]");
                            }
                        }
                        else if (input.Last() == "odd")
                        {
                            if (arrList.Any(n => n % 2 != 0))
                            {
                                var lastOdd = arrList.FindAll(n => n % 2 != 0).ToArray();

                                lastOdd = lastOdd.Reverse().ToArray();

                                var result = lastOdd.Take(lastCount).Reverse().ToArray();

                                Console.WriteLine("[{0}]", string.Join(", ", result));
                            }
                            else
                            {
                                Console.WriteLine("[]");
                            }
                        }

                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", arrList)}]");
        }
    }
}
