using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethod
{
    public class Startup
    {
        public static void Main()
        {
            var collection = GetCollection();

            var indexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            collection.SwapElements(indexes[0], indexes[1]);
            collection.Print();
        }

        private static GenericCollection<string> GetCollection()
        {
            var n = int.Parse(Console.ReadLine());
            var collection = new GenericCollection<string>();

            for (int i = 0; i < n; i++)
            {
                collection.Add(Console.ReadLine());
            }

            return collection;
        }
    }
}
