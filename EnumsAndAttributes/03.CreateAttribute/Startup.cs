using System.Linq;
using System.Reflection;

namespace _03.CreateAttribute
{
    [SoftUni("Lekov")]
    public class Startup
    {
        [SoftUni("Cantona")]
        public static void Main()
        {
            var testResult = Assembly.GetEntryAssembly().GetCustomAttributes().ToList();

            foreach (var item in testResult)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
