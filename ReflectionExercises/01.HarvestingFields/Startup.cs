using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _01.HarvestingFields
{
    public class Startup
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string, Func<FieldInfo[]>>
                {
                    { "private", ()=>typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public
                |BindingFlags.NonPublic | BindingFlags.Static).Where(x=>x.IsPrivate).ToArray() },
                     { "protected", ()=>typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public
                |BindingFlags.NonPublic | BindingFlags.Static).Where(x=>x.IsFamily).ToArray() },
                      { "public", ()=>typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public
                |BindingFlags.NonPublic | BindingFlags.Static).Where(x=>x.IsPublic).ToArray() },
                       { "all", ()=>typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public
                |BindingFlags.NonPublic | BindingFlags.Static) }
                };

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "HARVEST")
                {
                    break;
                }

                Print(dictionary[command]());

                //switch (command)
                //{
                //    case "private": PrintAllPrivateFields();
                //        break;
                //    case "protected":
                //        PrintAllProtectedFields();
                //        break;
                //    case "public":
                //        PrintAllPublicFields();
                //        break;
                //    case "all":
                //        PrintAllAllFields();
                //        break;
                //    default:
                //        break;
                //}
            }
        }

        private static void PrintAllAllFields()
        {
            FieldInfo[] allFields = typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public
                |BindingFlags.NonPublic | BindingFlags.Static);
            Print(allFields);
        }

        private static void Print(FieldInfo[] array)
        {
            foreach (var field in array)
            {
                Console.WriteLine($"{field.Attributes} {field.FieldType.Name} {field.Name}"
                    .Replace("Family","protected")
                    .ToLower());
            }
        }

        private static void PrintAllPublicFields()
        {
            FieldInfo[] publicFields = typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public);
            Print(publicFields);
        }

        private static void PrintAllProtectedFields()
        {
            FieldInfo[] protectedFields = typeof(HarvestingFields).GetFields(BindingFlags.Instance 
                | BindingFlags.NonPublic|BindingFlags.Public | BindingFlags.Static)
                .Where(x=>x.IsFamily).ToArray();
            Print(protectedFields);
        }

        private static void PrintAllPrivateFields()
        {
            FieldInfo[] privateFields = typeof(HarvestingFields).GetFields(BindingFlags.Instance
                | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static)
                .Where(x => x.IsPrivate).ToArray();
            Print(privateFields);
        }
    }
}
