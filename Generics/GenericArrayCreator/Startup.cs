using System;

namespace GenericArrayCreator
{
    public class Startup
    {
        public static void Main()
        {
            string[] array = ArrayCreator.Create(3, "Pesho");
            int[] arrayOfInts = ArrayCreator.Create(5, 11);

            Console.WriteLine(string.Join(", ",array));
            Console.WriteLine(string.Join(", ",arrayOfInts));
        }
    }
}
