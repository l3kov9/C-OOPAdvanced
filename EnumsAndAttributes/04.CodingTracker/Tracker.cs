using System.Linq;
using System.Reflection;

namespace _04.CodingTracker
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var methods = typeof(Startup)
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            foreach (var methodInfo in methods)
            {
                if (methodInfo.CustomAttributes.Any(n => n.AttributeType == typeof(SoftUniAttribute)))
                {
                    var attributes = methodInfo.GetCustomAttributes(false);

                    foreach (SoftUniAttribute attr in attributes)
                    {
                        System.Console.WriteLine($"{methodInfo.Name} is writen by {attr.Name}");
                    }
                }
            }
        }
    }
}
