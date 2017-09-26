using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class Soldier : ISoldier
    {
        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
