using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Stack
{
    public class CustomStack<T>
    {
        private List<T> collection;

        public CustomStack()
        {
            this.collection = new List<T>();
        }

        public void Push(T[] array)
        {
            foreach (var element in array)
            {
                this.collection.Add(element);
            }
        }

        public void Pop()
        {
            if (!this.collection.Any())
            {
                throw new ArgumentException("No elements");
            }
            this.collection.RemoveAt(this.collection.Count - 1);
        }

        public void PrintAll()
        {
            for (int i = this.collection.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(this.collection[i]);
            }
        }
    }
}