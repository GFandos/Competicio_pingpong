using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competició_Ping_Pong
{
    class Game
    {
        public String id { get; set; }
        public Player player1 { get; set; }
        public Player player2 { get; set; }
        public int pointsPlayer1 { get; set; }
        public int pointsPlayer2 { get; set; }
        public Player winner { get; set; }

        public Game(Player p1, Player p2)
        {

            player1 = p1;
            player2 = p2;
            pointsPlayer1 = 0;
            pointsPlayer2 = 0;
            winner = null; 

        }

        public Game()
        {
        }

        public override String ToString()
        {
            return player1 + " / " + player2 + " / " + pointsPlayer1 + " / " + pointsPlayer2 + " / " + winner;
        }

        public void calculateWin(int p1, int p2)
        {
            pointsPlayer1 = p1;
            pointsPlayer2 = p2;

            player1.played++;
            player2.played++;
            if (p1 > p2)
            {
                winner = player1;
                player1.points = 3;
                player2.points = 0;
            }
            else if (p1 < p2)
            {
                winner = player2;
                player1.points = 0;
                player2.points = 3;
            }
            else winner = new Player("Draft", "");
        }

    }
}
