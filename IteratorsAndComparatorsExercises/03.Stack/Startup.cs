using System;
using System.Linq;

namespace _03.Stack
{
    public class Startup
    {
        public static void Main()
        {
            CustomStack<string> customStack = GetCustomStack();
            Print(customStack);
            Print(customStack);
        }

        private static CustomStack<string> GetCustomStack()
        {
            var customStack = new CustomStack<string>();

            while (true)
            {
                var commands = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var firstCommand = commands[0];
                commands = commands.Skip(1).ToArray();

                if (firstCommand == "END")
                {
                    break;
                }

                switch (firstCommand)
                {
                    case "Push":
                        commands.ToList().ForEach(x => customStack.Push(x));
                        break;
                    case "Pop":
                        customStack.Pop();
                        break;
                    default:
                        break;
                }
            }

            return customStack;
        }

        private static void Print(CustomStack<string> customStack)
        {
            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
