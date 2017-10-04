using System;
using System.Linq;
using System.Text;

namespace _04.Froggy
{
    public class Startup
    {
        public static void Main()
        {
            var stoneNumbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            var lake = new Lake(stoneNumbers);
            var sb = new StringBuilder();

            foreach (var stone in lake)
            {
                sb.Append(stone + ", ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
