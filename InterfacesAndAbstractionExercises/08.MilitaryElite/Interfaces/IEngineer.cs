using System.Collections.Generic;
using _08.MilitaryElite.Models;

namespace _08.MilitaryElite.Interfaces
{
    public interface IEngineer
    {
        List<Repair> Repairs { get; }
    }
}
