using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class Startup
    {
        public static void Main()
        {
            var people = new List<Person>();

            while (true)
            {
                var personInfo = Console.ReadLine()
                    .Split();
                if (personInfo[0] == "END")
                {
                    break;
                }

                var person = new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]);
                people.Add(person);
            }

            var personIndex = int.Parse(Console.ReadLine())-1;
            var numberOfEqualPeople = 0;
            var notEqualPeople = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (i == personIndex)
                {
                    continue;
                }

                if (people[personIndex].CompareTo(people[i]) == 0)
                {
                    numberOfEqualPeople++;
                }
                else
                {
                    notEqualPeople++;
                }
            }

            Console.WriteLine($"{numberOfEqualPeople} {notEqualPeople} {people.Count}");
        }
    }
}
