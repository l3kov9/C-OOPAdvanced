using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SomeGame.Test
{

    [TestClass]
    public class HighScoreTest
    {
        [TestMethod]
        public void AddPlayerShouldHaveNoMoreTenPlayers()
        {
            for (int i = 0; i < Highscore.MaxPlayers+10; i++)
            {
                Highscore.AddPlayer(new Player());
            }
            Assert.AreEqual(Highscore.MaxPlayers, Highscore.Load().Count());
        }

        [TestMethod]
        public void AddPlayerShoudOrderByDescendingPlayerPoints()
        {

        }
    }
}
