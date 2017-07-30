using Comparing_Objects;
using System;
using System.Collections.Generic;

public class FullCompare : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        if (String.Compare(x.Name, y.Name, StringComparison.Ordinal) == 0)
        {
            return x.Age.CompareTo(y.Age);
        }
        return String.Compare(x.Name, y.Name, StringComparison.Ordinal);
    }
}