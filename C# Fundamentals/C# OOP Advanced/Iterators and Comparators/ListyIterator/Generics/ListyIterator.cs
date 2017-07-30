using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ListyIterator.Generics
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private IReadOnlyList<T> collection;
        private int index;

        public ListyIterator()
        {
            this.collection = new Collection<T>();
            this.index = 0;
        }

        public IReadOnlyList<T> Collection
        {
            get { return this.collection; }
        }

        public void Create(IEnumerable<T> collection)
        {
            if (!collection.Any())
            {
                throw new ArgumentException("Invalid Operation!");
            }

            this.collection = collection.ToList();
        }

        public bool Move()
        {
            if (this.index + 1 >= this.Collection.Count)
            {
                return false;
            }
            this.index += 1;

            return true;
        }

        public void Print()
        {
            if (this.index < this.Collection.Count)
            {
                Console.WriteLine(this.Collection[this.index]);
            }
        }

        public bool HasNext()
        {
            if (this.index + 1 < this.Collection.Count)
            {
                return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Collection.Count; i++)
            {
                yield return this.Collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", this.Collection));
        }
    }
}