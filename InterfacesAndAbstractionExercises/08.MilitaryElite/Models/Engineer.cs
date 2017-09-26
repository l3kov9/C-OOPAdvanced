using System.Collections.Generic;
using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<Repair> Repairs { get; }

        public Engineer(string id, string firstName, string lastName, double salary, string corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs=new List<Repair>();
        }
    }
}
