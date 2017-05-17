using Microsoft.VisualStudio.TestTools.UnitTesting;
using Competició_Ping_Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competició_Ping_Pong.Tests
{
    [TestClass()]
    public class LeagueTests
    {

        [TestMethod()]
        public void addPlayerTest()
        {
            League l = new League(123);
            l.addPlayer(new Player("p1", "p1.png"));
            Assert.IsTrue(l.players.Count == 1);
        }

        [TestMethod()]
        public void deletePlayerTest()
        {
            League l = new League(123);
            l.addPlayer(new Player("p1", "p1.png"));
            l.deletePlayer(0);
            Assert.IsTrue(l.players.Count == 0);
        }

        [TestMethod()]
        public void calculateGamesTest()
        {
            League l = new League(123);
            l.addPlayer(new Player("p1", "p1.png"));
            l.addPlayer(new Player("p2", "p2.png"));
            l.addPlayer(new Player("p3", "p3.png"));
            l.addPlayer(new Player("p4", "p4.png"));
            l.calculateGames();

            Assert.IsTrue(l.games.Count == 6);
        }
    }
}