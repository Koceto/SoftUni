using System.Collections.Generic;
using System.Linq;

public static class Sorter<T>
{
    public static List<T> Sort(List<T> list)
    {
        return list.OrderBy(x => x).ToList();
    }
}