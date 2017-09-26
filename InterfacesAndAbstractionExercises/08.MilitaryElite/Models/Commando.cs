using System.Collections.Generic;
using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public List<Mission> Missions { get; }

        public Commando(string id, string firstName, string lastName, double salary, string corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions=new List<Mission>();
        }
    }
}
