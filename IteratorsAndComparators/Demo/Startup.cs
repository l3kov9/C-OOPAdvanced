namespace Demo
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var bookCollection = new BookColletion
            {
                new Book(){Title="Pesho"},
                new Book(){Title="Misho"},
                new Book(){Title="Ginka"},
                new Book(){Title="Tanq"},
                new Book(){Title="Vanq"},
            };
            foreach (var book in bookCollection)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
