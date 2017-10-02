using System;

namespace GenericBox
{
    public class Startup
    {
        public static void Main()
        {
            var boxOfInts = new Box<int>(5);
            Console.WriteLine(boxOfInts.ToString());

            var boxOfStrings = new Box<string>("Botev");
            Console.WriteLine(boxOfStrings.ToString());
        }
    }
}
