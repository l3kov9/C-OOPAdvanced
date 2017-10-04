using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo
{
    public class BookColletion : IEnumerable<Book>
    {
        private readonly List<Book> books;

        public BookColletion()
        {
            this.books = new List<Book>();
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            //return new BooksIterator(this.books);
            for (int i = 0; i < this.books.Count; i++)
            {
                yield return this.books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BooksIterator(this.books);
        }
    }
}
