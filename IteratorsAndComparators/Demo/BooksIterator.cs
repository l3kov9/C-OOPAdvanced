using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo
{
    public class BooksIterator : IEnumerator<Book>
    {
        private int currentIndex;
        private readonly List<Book> books;

        public BooksIterator(List<Book> books)
        {
            this.Reset();
            this.books = books;
        }

        public Book Current => this.books[this.currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            this.currentIndex += 2;
            if (this.currentIndex >= this.books.Count)
            {
                return false;
            }

            return true;
        }

        public void Reset() => this.currentIndex = -2;
    }
}
