using System;

namespace DemoConstraints
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = CreateInstance<int>();
            Console.WriteLine(numbers);
        }

        public static T CreateInstance<T>()
            where T : new()
        {
            return new T();
        }
    }
}
