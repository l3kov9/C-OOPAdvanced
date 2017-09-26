using System.Collections.Generic;
using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public List<Private> Privates { get; }

        public LeutenantGeneral(string id, string firstName, string lastName, double salary) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates=new List<Private>();
        }
    }
}
