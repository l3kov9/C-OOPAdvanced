using _06.StrategyPattern.Comparators;
using System;
using System.Collections.Generic;

namespace _06.StrategyPattern
{
    public class Startup
    {
        public static void Main()
        {
            var sortedSetByName = new SortedSet<Person>(new NameComparator());
            var sortedSetByAge = new SortedSet<Person>(new AgeComparator());
            AddElementsToSets(sortedSetByName, sortedSetByAge);

            PrintPeople(sortedSetByName);
            PrintPeople(sortedSetByAge);
        }

        private static void AddElementsToSets(SortedSet<Person> sortedSetByName, SortedSet<Person> sortedSetByAge)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);
                sortedSetByName.Add(new Person(name, age));
                sortedSetByAge.Add(new Person(name, age));
            }
        }

        private static void PrintPeople(IEnumerable<Person> sortedSetByName)
        {
            foreach (var person in sortedSetByName)
            {
                Console.WriteLine(person);
            }
        }
    }
}
