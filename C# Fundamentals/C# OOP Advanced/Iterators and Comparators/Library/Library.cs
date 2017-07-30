using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    private List<Book> books;

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
        this.books.Sort(new BookComparator());
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class LibraryIterator : IEnumerator<Book>
    {
        private IReadOnlyList<Book> books;
        private int currentIndex;

        public LibraryIterator(List<Book> list)
        {
            this.Reset();
            this.books = list;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return ++this.currentIndex < this.books.Count;
        }

        public void Reset()
        {
            this.currentIndex = -1;
        }

        public Book Current
        {
            get { return this.books[currentIndex]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}