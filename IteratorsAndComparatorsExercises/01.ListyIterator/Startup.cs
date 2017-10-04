using System;
using System.Linq;

namespace _01.ListyIterator
{
    public class Startup
    {
        public static void Main()
        {
            var collection = new ListyIterator<string>();

            while (true)
            {
                var commands = ParseInput();
                var firstCommand = commands[0];
                commands = commands.Skip(1).ToArray();
                if (firstCommand == "END")
                {
                    break;
                }

                try
                {
                    switch (firstCommand)
                    {
                        case "Create":
                            collection = new ListyIterator<string>(commands);
                            break;
                        case "Move":
                            Console.WriteLine(collection.Move());
                            break;
                        case "HasNext":
                            Console.WriteLine(collection.HasNext());
                            break;
                        case "Print":
                            collection.Print();
                            break;
                        case "PrintAll":
                            collection.PrintAll();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private static string[] ParseInput()
        {
            return Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
