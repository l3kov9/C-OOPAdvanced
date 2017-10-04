using System;
using System.Collections.Generic;

namespace _01.Library
{
    public class Book : IBook, IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors {get;set;}

        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);

            if (result != 0)
            {
                return result;
            }

            return this.Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
