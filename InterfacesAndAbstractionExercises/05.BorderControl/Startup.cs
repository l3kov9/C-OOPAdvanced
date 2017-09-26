namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var members = GetSocietyMembers();
            
            members
                .Where(x => x.IsValidId(Console.ReadLine()))
                .ToList()
                .ForEach(x => Console.WriteLine(x.Id));
        }

        private static IEnumerable<SocietyMember> GetSocietyMembers()
        {
            var members = new List<SocietyMember>();

            while (true)
            {
                var memberInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (memberInfo[0] == "End")
                {
                    break;
                }

                if (memberInfo.Length == 3)
                {
                    members.Add(new Citizen(memberInfo[0], int.Parse(memberInfo[1]), memberInfo[2]));
                }

                if (memberInfo.Length == 2)
                {
                    members.Add(new Robot(memberInfo[0], memberInfo[1]));
                }
            }

            return members;
        }
    }
}
