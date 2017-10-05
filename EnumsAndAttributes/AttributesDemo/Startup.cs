using System.Linq;
using System.Reflection;

namespace AttributesDemo
{
    public class Startup
    {
        [Author("Pesho", Year = 2000)]
        public static void Main()
        {
            var value = Permission.Read | Permission.Write | Permission.ReadWrite;

            if (value.HasFlag(Permission.ReadWrite))
            {
                System.Console.WriteLine("OK");
            }

            System.Console.WriteLine(value);

            var types = Assembly.GetEntryAssembly().GetTypes().Where(x=>x.GetCustomAttribute<AuthorAttribute>()!=null);

            foreach (var type in types)
            {
                System.Console.WriteLine(type.Name);
            }
        }
    }
}
