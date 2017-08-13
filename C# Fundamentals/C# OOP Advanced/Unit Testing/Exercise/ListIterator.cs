using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class ListIterator
    {
        private IList<string> collection;
        private int index;

        public ListIterator(ICollection<string> collection)
        {
            this.Collection = collection.ToList();
            this.index = 0;
        }

        private IList<string> Collection
        {
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.collection = value;
            }
        }

        public bool Move()
        {
            if (this.index + 1 >= this.collection.Count)
            {
                return false;
            }
            this.index++;

            return true;
        }

        public bool HasNext()
        {
            if (this.index + 1 >= this.collection.Count)
            {
                return false;
            }
            return true;
        }

        public string Print()
        {
            if (!this.collection.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            return this.collection[this.index];
        }
    }
}