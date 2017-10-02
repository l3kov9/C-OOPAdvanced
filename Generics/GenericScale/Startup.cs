using System;

namespace GenericScale
{
    public class Startup
    {
        public static void Main()
        {
            var scale = new Scale<int>(-22,-4);
            Console.WriteLine(scale.GetHeavier());
        }
    }
}
