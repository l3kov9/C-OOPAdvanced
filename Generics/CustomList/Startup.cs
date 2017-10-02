using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomList
{
    public class Startup
    {
        public static void Main()
        {
            var customList = new CustomList<string>();
            ReadCustomListCommands(customList);
        }

        private static void ReadCustomListCommands(CustomList<string> customList)
        {
            while (true)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (command[0] == "END")
                {
                    break;
                }

                ReadCommand(command, customList);
            }
        }

        private static void ReadCommand(List<string> command, CustomList<string> customList)
        {
            switch (command[0])
            {
                case "Add": customList.Add(command[1]);
                    break;
                case "Remove": customList.Remove(int.Parse(command[1]));
                    break;
                case "Contains": Console.WriteLine(customList.Contains(command[1])); 
                    break;
                case "Swap": customList.Swap(int.Parse(command[1]), int.Parse(command[2]));
                    break;
                case "Greater": Console.WriteLine(customList.CountGreaterThan(command[1]));
                    break;
                case "Max": Console.WriteLine(customList.Max());
                    break;
                case "Min":Console.WriteLine(customList.Min());
                    break;
                case "Print": customList.Print();
                    break;
                default:
                    break;
            }
        }
    }
}
