using System;
using System.Linq;
using System.Reflection;

namespace Demo
{
    public class Startup
    {
        public static void Main()
        {
            Type main = typeof(Startup);
            Console.WriteLine("S".GetType().Name);
            var Str = typeof(String);

            Console.WriteLine(typeof(Cat).Name);
            Console.WriteLine(typeof(Cat).FullName);
            Console.WriteLine(typeof(Cat).Assembly.FullName);

            foreach (var prop in typeof(Cat).GetProperties())
            {
                Console.WriteLine(prop.PropertyType.Name);
            }

            var xnew = GetTypeName<Startup>();
            Console.WriteLine(xnew);

            var baseClass = typeof(Cat).BaseType;
            Console.WriteLine(baseClass.Name);

            Type[] interfaces = typeof(Cat).BaseType.GetInterfaces();

            foreach (var @interface in interfaces)
            {
                Console.WriteLine(@interface.Name);
            }
            Console.WriteLine(new string('*', 111));

            var assembly = Assembly.GetEntryAssembly().GetTypes().Where(x => x.IsPublic);
            foreach (var ass in assembly)
            {
                Console.WriteLine(ass.Name);
            }
            Console.WriteLine(new string('*', 111));

            var cat = Activator.CreateInstance<Cat>(); //we can add parameters if there is constructors
            cat.Name = "Pesho";

            Console.WriteLine(new string('*', 111));

            var typeOfCat = typeof(Cat);
            var fields = typeOfCat.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var field in fields)
            {
                Console.WriteLine(field.Name);
            }
            Console.WriteLine(new string('*', 111));

            var properties = typeOfCat.GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine(prop.Name);
            }

            var anotherCat = new Cat
            {
                Name = "Pesho",
                Age = 22
            };

            var nameProperty = anotherCat.GetType().GetProperty("Name");
            Console.WriteLine(nameProperty.GetValue(anotherCat));
            nameProperty.SetValue(anotherCat, "Gosho");
            Console.WriteLine(anotherCat.Name);

            Console.WriteLine(new string('*', 111));

            var constructors = typeof(Cat).GetConstructors();

            foreach (var constr in constructors)
            {
                var parameters = constr.GetParameters();

                foreach (var param in parameters)
                {
                    Console.WriteLine(param.Name + " " + param.ParameterType);
                }
                Console.WriteLine("------");
            }
            var emptyConstructor = typeof(Cat).GetConstructor(Type.EmptyTypes);

            Console.WriteLine(new string('*', 111));

            var methods = typeof(Cat).GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }

        private static string GetTypeName<T>()
        {
            return typeof(T).Name;
        }
    }
}
