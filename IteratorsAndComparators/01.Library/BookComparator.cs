using System;
using System.Collections.Generic;

namespace _01.Library
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            var result = x.Title.CompareTo(y.Title);
            if (result != 0)
            {
                return result;
            }

            return y.Year.CompareTo(x.Year);
        }
    }
}
