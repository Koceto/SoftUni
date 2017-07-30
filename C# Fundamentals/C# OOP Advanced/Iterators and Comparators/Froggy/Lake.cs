using System.Collections;
using System.Collections.Generic;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private int[] numbers;

        public Lake(int[] numbers)
        {
            this.numbers = numbers;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.numbers[i];
                }
            }

            for (int i = this.numbers.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.numbers[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}