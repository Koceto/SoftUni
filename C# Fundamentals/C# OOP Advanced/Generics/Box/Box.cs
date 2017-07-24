using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    private List<T> list;

    public Box()
    {
        this.list = new List<T>();
    }

    public int Count
    {
        get { return this.list.Count; }
    }

    public void Add(T element)
    {
        this.list.Add(element);
    }

    public T Remove()
    {
        T element = this.list.LastOrDefault();
        this.list.RemoveAt(this.list.Count - 1);

        return element;
    }
}