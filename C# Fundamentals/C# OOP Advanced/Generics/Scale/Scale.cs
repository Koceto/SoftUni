using System;

public class Scale<T>
    where T : IComparable
{
    private T firstElement;
    private T secondElement;

    public Scale(T firstElement, T secondElement)
    {
        this.firstElement = firstElement;
        this.secondElement = secondElement;
    }

    public T GetHavier()
    {
        int compareResults = this.firstElement.CompareTo(this.secondElement);

        if (compareResults > 0)
        {
            return this.firstElement;
        }

        if (compareResults < 0)
        {
            return this.secondElement;
        }

        return default(T);
    }
}