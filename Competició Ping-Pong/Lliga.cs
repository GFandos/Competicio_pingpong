using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;

namespace Competició_Ping_Pong
{
    public partial class Lliga : Form
    {

        private String playerName = "";
        private String playerPicture = "";
        private FirebaseManager manager;
        private Game nextGame;

        public Lliga()
        {
            InitializeComponent();
            manager = new FirebaseManager();
            initializePlayers();
            initializeGames();
        }

        private async void initializePlayers()
        {
            manager.playersL.Clear();
            await manager.getPlayersDB(1);
            updateList();
        }

        private async void initializeGames()
        {
            manager.gamesL.Clear();
            await manager.getGamesDB();
            updateGamesList();
            initializeButtons();
        }

        private void initializeButtons()
        {
            if (manager.gamesL.Count > 0 )
            {
                manager.currentLeague = new League(123);
                manager.currentLeague.players = manager.playersL;
                manager.currentLeague.games = manager.gamesL;
                onStartLeague.Enabled = false;
                onAddPlayer.Enabled = false;
                onEditPlayer.Enabled = false;
                onDeletePlayer.Enabled = false;
            }
        }

        private void onAddPlayer_Click(object sender, EventArgs e)
        {
            playerName = addPName.Text;
            playerPicture = addPPicture.Text;

            if(!(playerName == "") && !(playerPicture == ""))
            {
                Player p = new Player(playerName, playerPicture);
                manager.addPlayer(p);
                updateList();
            } else
            {
                MessageBox.Show("Lacks information.");

            }

            addPName.Text = "";
            addPPicture.Text = "";

            updateGamesAndPlayersList();
        }

        public void updateList ()
        {
            playersList.Items.Clear();
            foreach (var p1 in manager.playersL)
            {

                string points = p1.points.ToString();
                string played = p1.played.ToString();
                string name = p1.name;
                string picture = p1.picture;
                string id = p1.id;

                //creamos un objeto listviewitem con el nombre del jugador(sera el valor)
                ListViewItem lvi = new ListViewItem(id);
                //le asignamos una clave que sera el id
                lvi.Text = name;
                //si en la lista no existe un jugador con la misma clave lo muestra en el listview
                lvi.SubItems.Add(picture);
                lvi.SubItems.Add(points);
                lvi.SubItems.Add(played);
                lvi.SubItems.Add(id);
                playersList.Items.Add(lvi);

            }
        }

        private void playersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playersList.SelectedItems.Count > 0)
            {
                int index = playersList.SelectedIndices[0];
                String name = playersList.Items[index].Text;
                String picture = playersList.Items[index].SubItems[1].Text;

                editPName.Text = name;
                editPPicture.Text = picture;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            manager.playersL.Clear();
            await manager.getPlayersDB(1);
            updateList();
        }

        private async void getPlayers()
        {
            manager.playersL.Clear();
            await manager.getPlayersDB(0);
        }

        private void onEditPlayer_Click(object sender, EventArgs e)
        {
            if (playersList.SelectedItems.Count > 0)
            {
                int index = playersList.SelectedIndices[0];

                String id = playersList.Items[index].SubItems[4].Text;
                String points = playersList.Items[index].SubItems[2].Text;
                String played = playersList.Items[index].SubItems[3].Text;
                String name = editPName.Text;
                String picture = editPPicture.Text;

                Player p = new Player(name, picture);
                p.points = int.Parse(points);
                p.played = int.Parse(played);
                p.id = id;

                manager.updatePlayer(p,0);
            }
        }

        private void onDeletePlayer_Click(object sender, EventArgs e)
        {
            if (playersList.SelectedItems.Count > 0)
            {
                int index = playersList.SelectedIndices[0];

                String id = playersList.Items[index].SubItems[4].Text;

                manager.deletePlayer(id);
                playersList.Items[index].Remove();
                MessageBox.Show("Player deleted.");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void onStartLeague_Click(object sender, EventArgs e)
        {
            onStartLeague.Enabled = false;

            onAddPlayer.Enabled = false;
            onEditPlayer.Enabled = false;
            onDeletePlayer.Enabled = false;
            manager.startLeague();
            updateGamesAndPlayersList();
        }


        private async void button1_Click_1(object sender, EventArgs e)
        {
            manager.gamesL.Clear();
            await manager.getGamesDB();
            updateGamesList();
        }

        public void updateGamesList()
        {
            GamesList.Items.Clear();
            foreach (var p1 in manager.gamesL)
            {

                string name = p1.id;
                string player1 = p1.player1.name;
                string player2 = p1.player2.name;
                string winner = "";
                if (p1.winner != null)
                {
                    winner = p1.winner.name;
                }
                string id = p1.id;

                //creamos un objeto listviewitem con el nombre del jugador(sera el valor)
                ListViewItem lvi = new ListViewItem(id);
                //le asignamos una clave que sera el id
                lvi.Text = name;
                //si en la lista no existe un jugador con la misma clave lo muestra en el listview
                lvi.SubItems.Add(player1);
                lvi.SubItems.Add(player2);
                lvi.SubItems.Add(winner);
                GamesList.Items.Add(lvi);

            }

            getNextGame();

        }

        private void getNextGame()
        {
            bool ends = true;
            for(int i = 0; i < GamesList.Items.Count; ++i)
            {
                if(GamesList.Items[i].SubItems[3].Text == "")
                {
                    string p1Name = GamesList.Items[i].SubItems[1].Text;
                    string p2Name = GamesList.Items[i].SubItems[2].Text;
                    versus.Text = p1Name + " VS " + p2Name;
                    nextGame = manager.gamesL[i];
                    ends = false;
                    return;
                }
            }

            if(ends && manager.currentLeague != null && GamesList.Items.Count > 0)
            {
                string winner = "";

                winner = calculateWinner();

                MessageBox.Show("League ends! The winner is " + winner);
                cancelLeague();
                return;
            }

        }

        private string calculateWinner()
        {
            string winner = "";
            int max = 0;
            for (int i = 0; i < manager.playersL.Count; ++i)
            {
                if(max <= manager.playersL[i].points)
                {

                    max = manager.playersL[i].points;
                    winner = manager.playersL[i].name;
                }   
            }
            return winner;
        }

        private void onCancelLeague_Click(object sender, EventArgs e)
        {
            cancelLeague();
        }

        private void onPlayGame_Click(object sender, EventArgs e)
        {
            if(pointsP1.Text != "" && pointsP2.Text != "")
            {
                int points1 = int.Parse(pointsP1.Text);
                int points2 = int.Parse(pointsP2.Text);
                nextGame.calculateWin(points1, points2);

                pointsP1.Text = "";
                pointsP2.Text = "";

                manager.updateGame(nextGame);
                manager.updatePlayer(nextGame.player1,1);
                manager.updatePlayer(nextGame.player2,1);
                updateGamesAndPlayersList();
            } else
            {
                MessageBox.Show("Introduce puntuation.");
            }
        }

        private async void updateGamesAndPlayersList()
        {
            manager.playersL.Clear();
            playersList.Items.Clear();
            GamesList.Items.Clear();
            manager.gamesL.Clear();
            System.Threading.Thread.Sleep(2000);
            await manager.getPlayersDB(1);
            await manager.getGamesDB();

            updateList();
            updateGamesList();
        }

        private void cancelLeague()
        {
            manager.deleteGames();
            manager.resetPlayersStats();
            onStartLeague.Enabled = true;
            manager.currentLeague = null;

            onStartLeague.Enabled = true;
            onAddPlayer.Enabled = true;
            onEditPlayer.Enabled = true;
            onDeletePlayer.Enabled = true;

            updateGamesList();
        }

        private void GamesList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (GamesList.SelectedItems.Count > 0)
            {
                int index = GamesList.SelectedIndices[0];
                int pointsP1 = manager.gamesL[index].pointsPlayer1;
                int pointsP2 = manager.gamesL[index].pointsPlayer2;

                infoP1.Text = pointsP1.ToString();
                infoP2.Text = pointsP2.ToString();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
