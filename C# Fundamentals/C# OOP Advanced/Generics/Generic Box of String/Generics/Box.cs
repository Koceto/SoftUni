using System;
using System.Collections.Generic;
using System.Linq;

public class Box<T>
    where T : IComparable
{
    private List<T> list;

    public Box()
    {
        this.list = new List<T>();
    }

    public IList<T> List
    {
        get { return this.list.AsReadOnly(); }
    }

    public void Add(T element)
    {
        this.list.Add(element);
    }

    public void Remove(int index)
    {
        this.list.RemoveAt(index);
    }

    public bool Contains(T element)
    {
        return this.list.Contains(element);
    }

    public void Swap(int firstIndex, int secondIndex)
    {
        T firstElement = this.list[firstIndex];
        this.list[firstIndex] = this.list[secondIndex];
        this.list[secondIndex] = firstElement;
    }

    public int GreaterThan(T element)
    {
        return this.list.Count(x => x.CompareTo(element) > 0);
    }

    public T Max()
    {
        return this.list.Max();
    }

    public T Min()
    {
        return this.list.Min();
    }

    public void Sort()
    {
        this.list = Sorter<T>.Sort(this.list);
    }

    public void Print()
    {
        foreach (var item in this.list)
        {
            Console.WriteLine(item);
        }
    }
}