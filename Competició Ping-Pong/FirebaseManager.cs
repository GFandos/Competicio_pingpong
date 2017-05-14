
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using System.Collections.Generic;


namespace Competició_Ping_Pong
{
    class FirebaseManager
    {
        private FirebaseClient firebase;
        public List<Player> playersL = new List<Player>();
        public League currentLeague = new League(123);
        public List<Game> gamesL = new List<Game>();

        public FirebaseManager()
        {
            firebase = new FirebaseClient("https://ping-pong-competition.firebaseio.com/");
            var observablePlayers = firebase
                .Child("players")
                .AsObservable<Player>()
                .Subscribe(d => {
                    // Quan hi ha un canvi a Firebase es crida aquest codi
                    // Al objecte d rebem la info de la operació realitzada
            });
            var observableGames = firebase
                .Child("games")
                .AsObservable<Game>()
                .Subscribe(d => {
                    // Quan hi ha un canvi a Firebase es crida aquest codi
                    // Al objecte d rebem la info de la operació realitzada
             });


        }

        public async void resetPlayersStats()
        {
            for(int i = 0; i < playersL.Count; ++i)
            {
                var child = firebase.Child("players/" + playersL[i].id);


                await child.PutAsync(playersL[i]);
                //MessageBox.Show("Player edited.");
                playersL.Clear();
                await getPlayersDB(1);
            }

        }


        // Lectura dels jugadors usant la API de C# per a Firebase.
        public async Task getPlayersDB(int mode)
        {

            playersL.Clear();
            var jugadors = await firebase.Child("players").OnceAsync<Player>();
            foreach (var p1 in jugadors)
            {
                p1.Object.id = p1.Key;

                this.playersL.Add(p1.Object);
            }

            if(mode == 0)
            {
                currentLeague.players = playersL;

                foreach (var g in currentLeague.games)
                {
                    addGame(g);
                }

            }


        }

        public async Task getGamesDB()
        {
            var games = await firebase.Child("games").OnceAsync<Game>();
            gamesL.Clear();
            foreach (var g in games)
            {
                g.Object.id = g.Key;

                this.gamesL.Add(g.Object);
            }

            if(currentLeague != null)
            {
                currentLeague.games = gamesL;

            }
        }

        public async void addPlayer(Player p)
        {
            var client = new FirebaseClient("https://ping-pong-competition.firebaseio.com/");
            var child = client.Child("players");

            // Al fer l'insert ens retorna un FirebaseObject que conté la Key
            var p1 = await child.PostAsync(p);
            //currentLeague.addPlayer(p1.Object);
            MessageBox.Show("Player correctly added");
        }

        public async void updatePlayer(Player p, int mode)
        {
            var child = firebase.Child("players/" + p.id);


            await child.PutAsync(p);
            //MessageBox.Show("Player edited.");
            playersL.Clear();
            if(mode == 0)
            {
                await getPlayersDB(1);
            }

        }

        public async void deletePlayer(String id)
        {
            var child = firebase.Child("players/" + id);
            await child.DeleteAsync();
            await getPlayersDB(1);
        }


        public void startLeague()
        {
            currentLeague = new League(123);
            currentLeague.players = playersL;
            currentLeague.calculateGames();
            
            for(int i = 0; i < currentLeague.games.Count; ++i)
            {
                addGame(currentLeague.games[i]);
            }

        }

        public async void addGame(Game g)
        {
            var client = new FirebaseClient("https://ping-pong-competition.firebaseio.com/");
            var child = client.Child("games");

            // Al fer l'insert ens retorna un FirebaseObject que conté la Key
            var p1 = await child.PostAsync(g);
        }

        public async void deleteGames()
        {
            gamesL.Clear();

            var child = firebase.Child("games/");
            await child.DeleteAsync();
        }

        public async void updateGame(Game g)
        {
            var child = firebase.Child("games/" + g.id);
            await child.PutAsync(g);
            await getGamesDB();
        }

    }
}
