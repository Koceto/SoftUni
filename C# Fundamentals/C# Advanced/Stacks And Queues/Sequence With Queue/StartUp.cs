using System;
using System.Collections.Generic;

namespace Sequence_With_Queue
{
    public static class StartUp
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            var result = new Queue<long>();

            queue.Enqueue(n);

            while (result.Count < 50)
            {
                result.Enqueue(queue.Peek());
                var currNumber = queue.Dequeue();

                queue.Enqueue(currNumber + 1);

                queue.Enqueue(2 * currNumber + 1);

                queue.Enqueue(currNumber + 2);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{result.Dequeue()} ");
            }
        }
    }
}