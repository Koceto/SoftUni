using System;
using System.Collections.Generic;
using System.Linq;

namespace Second_Nature
{
    internal class Program
    {
        private static void Main()
        {
            // Flowers with ammount of water needed
            int[] flowers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            // Bucket with water ammount
            int[] buckets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();
            // Eternal Blooms
            Queue<int> eternalBlooms = new Queue<int>();

            for (int flowerIndex = 0; flowerIndex < flowers.Length; flowerIndex++)
            {
                for (int bucketIndex = 0; bucketIndex < buckets.Length; bucketIndex++)
                {
                    if (buckets[bucketIndex] == flowers[flowerIndex])
                    {
                        eternalBlooms.Enqueue(flowers[flowerIndex]);
                        buckets[bucketIndex] = 0;
                        flowers[flowerIndex] = 0;
                    }
                    else if (buckets[bucketIndex] > flowers[flowerIndex])
                    {
                        if (bucketIndex + 1 < buckets.Length)
                        {
                            buckets[bucketIndex + 1] += buckets[bucketIndex] - flowers[flowerIndex];
                            buckets[bucketIndex] = 0;
                        }
                        else
                        {
                            buckets[bucketIndex] -= flowers[flowerIndex];
                        }
                        flowers[flowerIndex] = 0;
                    }
                    else
                    {
                        flowers[flowerIndex] -= buckets[bucketIndex];
                        buckets[bucketIndex] = 0;
                    }

                    if (flowers[flowerIndex] == 0)
                    {
                        break;
                    }
                }
            }

            if (flowers.Any(f => f > 0))
            {
                Console.WriteLine(string.Join(" ", flowers.Where(f => f > 0)));
            }
            if (buckets.Any(b => b > 0))
            {
                Console.WriteLine(string.Join(" ", buckets.Where(b => b > 0)));
            }
            if (eternalBlooms.Count > 0)
            {
                Console.WriteLine(string.Join(" ", eternalBlooms));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}