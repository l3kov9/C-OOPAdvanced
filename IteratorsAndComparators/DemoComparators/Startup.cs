using System.Collections.Generic;

namespace DemoComparators
{
    public class Startup
    {
        public static void Main()
        {
            var sortedSet = new SortedSet<Book>();

            sortedSet.Add(new Book { Title = "Pesho", Author = "Gosho" });
            sortedSet.Add(new Book { Title = "Minka", Author = "Ginka" });
            sortedSet.Add(new Book { Title = "Vanq", Author = "Polq" });
            sortedSet.Add(new Book { Title = "Misho", Author = "Cveta" });

            var bc = new BookComparer();
            var result=bc.Compare(new Book { Title = "pesho" }, new Book { Title = "Pesho" });

            var anotherSortedSet = new SortedSet<Book>(new BookComparer());

            System.Console.WriteLine(result);

            foreach (var book in sortedSet)
            {
                System.Console.WriteLine($"{book.Title} - {book.Author}");
            }
        }
    }
}
