using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoComparators
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }
}
