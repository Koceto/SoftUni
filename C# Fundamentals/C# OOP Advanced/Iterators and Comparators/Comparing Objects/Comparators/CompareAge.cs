using Comparing_Objects;
using System.Collections.Generic;

public class CompareAge : IComparer<Person>
{
    public int Compare(Person first, Person second)
    {
        return first.Age.CompareTo(second.Age);
    }
}