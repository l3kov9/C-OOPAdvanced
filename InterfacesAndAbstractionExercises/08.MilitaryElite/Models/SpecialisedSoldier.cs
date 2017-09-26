using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public string Corps { get; }

        public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }
    }
}
