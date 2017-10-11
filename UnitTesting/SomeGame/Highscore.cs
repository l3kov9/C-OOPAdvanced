using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SomeGame
{
    public static class Highscore
    {
        public const int MaxPlayers = 10;

        private static List<Player> currentHighscore= new List<Player>();

        public static IEnumerable<Player> Load()
        {
            return new ReadOnlyCollection<Player>(currentHighscore);
        }

        public static void AddPlayer(Player player)
        {
                currentHighscore.Add(player);
                currentHighscore = currentHighscore
                    .OrderByDescending(x => x.Points)
                    .Take(MaxPlayers)
                    .ToList();
        }
    }
}
