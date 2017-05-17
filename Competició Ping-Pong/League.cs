using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competició_Ping_Pong
{
    public class League
    {
        
        public int id;
        public List<Player> players;
        public List<Game> games = new List<Game>();

        public List<Player> getListaJugadors { get; }

        public League()
        {

        }

        public League(int id_)
        {
            id = id_;
            players = new List<Player>();
        }

        public void addPlayer(Player p)
        {
            players.Add(p);
        }

        public Player getPlayer(int i)
        {
            if (i < players.Count)
                return players[i];
            else
                return null;
        }

        public void deletePlayer(int i)
        {
            if (i < players.Count)
                players.RemoveAt(i);
        }

        public List<Player> getPlayerList()
        {
            return this.players;
        }

        public void setPlayerList(List<Player> newPlayers)
        {
            this.players = newPlayers;
        }

        public void calculateGames()
        {
            for(int i = 0; i < players.Count; ++i)
            {
                for(int j = 0; j < players.Count; ++j)
                {
                    if(j > i)
                    {
                        Game g = new Game(players[i], players[j]);
                        games.Add(g);
                    }
                }
            }

        }


    }
}
