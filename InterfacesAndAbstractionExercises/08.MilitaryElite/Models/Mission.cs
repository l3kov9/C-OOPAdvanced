using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        
        public string CodeName { get; }

        public string State { get; }

        public void CompleteMission()
        {
            throw new System.NotImplementedException();
        }
    }
}
