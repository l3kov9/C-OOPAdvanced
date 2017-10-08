using System;
using System.Linq;
using System.Reflection;

namespace _02.BlackBoxInteger
{
    public class Startup
    {
        private const BindingFlags Flags = BindingFlags.Instance | BindingFlags.NonPublic;

        public static void Main()
        {
            Type blackboxType = typeof(BlackBoxInt);
            BlackBoxInt blackboxInstance = (BlackBoxInt)Activator.CreateInstance(blackboxType, true);
            Console.WriteLine(blackboxInstance.GetType());

            //ConstructorInfo constructorInfo = blackBoxType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic
            //    ,Type.DefaultBinder,new Type[] { }, null);
            //constructorInfo.Invoke

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END") break;

                var methodTokens = input.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                var methodName = methodTokens[0];
                var methodParam = int.Parse(methodTokens[1]);

                blackboxType
                    .GetMethod(methodName, Flags)
                    .Invoke(blackboxInstance, new object[] { methodParam });

                var innerValue = blackboxType
                    .GetFields(Flags)
                    .First()
                    .GetValue(blackboxInstance);

                Console.WriteLine(innerValue);
            }
        }
    }
}
