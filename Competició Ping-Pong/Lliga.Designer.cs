namespace Competició_Ping_Pong
{
    partial class Lliga
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Players = new System.Windows.Forms.TabPage();
            this.onUpdatePL = new System.Windows.Forms.Button();
            this.onDeletePlayer = new System.Windows.Forms.Button();
            this.onEditPlayer = new System.Windows.Forms.Button();
            this.editPPicture = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editPName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.onAddPlayer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addPPicture = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addPName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playersList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pointsP2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pointsP1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.onPlayGame = new System.Windows.Forms.Button();
            this.versus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.onCancelLeague = new System.Windows.Forms.Button();
            this.infoP2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.infoP1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.onStartLeague = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GamesList = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Player1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Player2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Winner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.Players.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Players);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 529);
            this.tabControl1.TabIndex = 0;
            // 
            // Players
            // 
            this.Players.Controls.Add(this.onUpdatePL);
            this.Players.Controls.Add(this.onDeletePlayer);
            this.Players.Controls.Add(this.onEditPlayer);
            this.Players.Controls.Add(this.editPPicture);
            this.Players.Controls.Add(this.label5);
            this.Players.Controls.Add(this.editPName);
            this.Players.Controls.Add(this.label6);
            this.Players.Controls.Add(this.onAddPlayer);
            this.Players.Controls.Add(this.label4);
            this.Players.Controls.Add(this.addPPicture);
            this.Players.Controls.Add(this.label3);
            this.Players.Controls.Add(this.addPName);
            this.Players.Controls.Add(this.label2);
            this.Players.Controls.Add(this.label1);
            this.Players.Controls.Add(this.playersList);
            this.Players.Location = new System.Drawing.Point(4, 22);
            this.Players.Name = "Players";
            this.Players.Padding = new System.Windows.Forms.Padding(3);
            this.Players.Size = new System.Drawing.Size(959, 503);
            this.Players.TabIndex = 0;
            this.Players.Text = "Players";
            this.Players.UseVisualStyleBackColor = true;
            // 
            // onUpdatePL
            // 
            this.onUpdatePL.Location = new System.Drawing.Point(671, 459);
            this.onUpdatePL.Name = "onUpdatePL";
            this.onUpdatePL.Size = new System.Drawing.Size(130, 23);
            this.onUpdatePL.TabIndex = 14;
            this.onUpdatePL.Text = "Update players list";
            this.onUpdatePL.UseVisualStyleBackColor = true;
            this.onUpdatePL.Click += new System.EventHandler(this.button1_Click);
            // 
            // onDeletePlayer
            // 
            this.onDeletePlayer.Location = new System.Drawing.Point(822, 459);
            this.onDeletePlayer.Name = "onDeletePlayer";
            this.onDeletePlayer.Size = new System.Drawing.Size(117, 23);
            this.onDeletePlayer.TabIndex = 13;
            this.onDeletePlayer.Text = "Delete player";
            this.onDeletePlayer.UseVisualStyleBackColor = true;
            this.onDeletePlayer.Click += new System.EventHandler(this.onDeletePlayer_Click);
            // 
            // onEditPlayer
            // 
            this.onEditPlayer.Location = new System.Drawing.Point(294, 323);
            this.onEditPlayer.Name = "onEditPlayer";
            this.onEditPlayer.Size = new System.Drawing.Size(75, 23);
            this.onEditPlayer.TabIndex = 12;
            this.onEditPlayer.Text = "Edit";
            this.onEditPlayer.UseVisualStyleBackColor = true;
            this.onEditPlayer.Click += new System.EventHandler(this.onEditPlayer_Click);
            // 
            // editPPicture
            // 
            this.editPPicture.Location = new System.Drawing.Point(65, 282);
            this.editPPicture.Name = "editPPicture";
            this.editPPicture.Size = new System.Drawing.Size(304, 20);
            this.editPPicture.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Picture";
            // 
            // editPName
            // 
            this.editPName.Location = new System.Drawing.Point(65, 243);
            this.editPName.Name = "editPName";
            this.editPName.Size = new System.Drawing.Size(304, 20);
            this.editPName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            // 
            // onAddPlayer
            // 
            this.onAddPlayer.Location = new System.Drawing.Point(294, 149);
            this.onAddPlayer.Name = "onAddPlayer";
            this.onAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.onAddPlayer.TabIndex = 7;
            this.onAddPlayer.Text = "Add";
            this.onAddPlayer.UseVisualStyleBackColor = true;
            this.onAddPlayer.Click += new System.EventHandler(this.onAddPlayer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edit player";
            // 
            // addPPicture
            // 
            this.addPPicture.Location = new System.Drawing.Point(65, 110);
            this.addPPicture.Name = "addPPicture";
            this.addPPicture.Size = new System.Drawing.Size(304, 20);
            this.addPPicture.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Picture";
            // 
            // addPName
            // 
            this.addPName.Location = new System.Drawing.Point(65, 71);
            this.addPName.Name = "addPName";
            this.addPName.Size = new System.Drawing.Size(304, 20);
            this.addPName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add player";
            // 
            // playersList
            // 
            this.playersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.playersList.Location = new System.Drawing.Point(418, 41);
            this.playersList.Name = "playersList";
            this.playersList.Size = new System.Drawing.Size(521, 412);
            this.playersList.TabIndex = 0;
            this.playersList.UseCompatibleStateImageBehavior = false;
            this.playersList.View = System.Windows.Forms.View.Details;
            this.playersList.SelectedIndexChanged += new System.EventHandler(this.playersList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 199;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Picture";
            this.columnHeader2.Width = 163;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Points";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Played games";
            this.columnHeader4.Width = 95;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.pointsP2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.pointsP1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.onPlayGame);
            this.tabPage2.Controls.Add(this.versus);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.onCancelLeague);
            this.tabPage2.Controls.Add(this.infoP2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.infoP1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.onStartLeague);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.GamesList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "League";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update games list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pointsP2
            // 
            this.pointsP2.Location = new System.Drawing.Point(433, 294);
            this.pointsP2.Name = "pointsP2";
            this.pointsP2.Size = new System.Drawing.Size(46, 20);
            this.pointsP2.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Points player 2";
            // 
            // pointsP1
            // 
            this.pointsP1.Location = new System.Drawing.Point(433, 268);
            this.pointsP1.Name = "pointsP1";
            this.pointsP1.Size = new System.Drawing.Size(46, 20);
            this.pointsP1.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Points player 1";
            // 
            // onPlayGame
            // 
            this.onPlayGame.Location = new System.Drawing.Point(418, 320);
            this.onPlayGame.Name = "onPlayGame";
            this.onPlayGame.Size = new System.Drawing.Size(75, 23);
            this.onPlayGame.TabIndex = 10;
            this.onPlayGame.Text = "Play game";
            this.onPlayGame.UseVisualStyleBackColor = true;
            this.onPlayGame.Click += new System.EventHandler(this.onPlayGame_Click);
            // 
            // versus
            // 
            this.versus.AutoSize = true;
            this.versus.Location = new System.Drawing.Point(392, 240);
            this.versus.Name = "versus";
            this.versus.Size = new System.Drawing.Size(0, 13);
            this.versus.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Next game:";
            // 
            // onCancelLeague
            // 
            this.onCancelLeague.Location = new System.Drawing.Point(760, 447);
            this.onCancelLeague.Name = "onCancelLeague";
            this.onCancelLeague.Size = new System.Drawing.Size(93, 26);
            this.onCancelLeague.TabIndex = 7;
            this.onCancelLeague.Text = "Cancel league";
            this.onCancelLeague.UseVisualStyleBackColor = true;
            this.onCancelLeague.Click += new System.EventHandler(this.onCancelLeague_Click);
            // 
            // infoP2
            // 
            this.infoP2.Location = new System.Drawing.Point(433, 115);
            this.infoP2.Name = "infoP2";
            this.infoP2.ReadOnly = true;
            this.infoP2.Size = new System.Drawing.Size(46, 20);
            this.infoP2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Points player 2";
            // 
            // infoP1
            // 
            this.infoP1.Location = new System.Drawing.Point(433, 65);
            this.infoP1.Name = "infoP1";
            this.infoP1.ReadOnly = true;
            this.infoP1.Size = new System.Drawing.Size(46, 20);
            this.infoP1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Points player 1";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // onStartLeague
            // 
            this.onStartLeague.Location = new System.Drawing.Point(859, 447);
            this.onStartLeague.Name = "onStartLeague";
            this.onStartLeague.Size = new System.Drawing.Size(77, 26);
            this.onStartLeague.TabIndex = 2;
            this.onStartLeague.Text = "Start league";
            this.onStartLeague.UseVisualStyleBackColor = true;
            this.onStartLeague.Click += new System.EventHandler(this.onStartLeague_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Game information";
            // 
            // GamesList
            // 
            this.GamesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Player1,
            this.Player2,
            this.Winner});
            this.GamesList.Location = new System.Drawing.Point(548, 22);
            this.GamesList.Name = "GamesList";
            this.GamesList.Size = new System.Drawing.Size(388, 419);
            this.GamesList.TabIndex = 0;
            this.GamesList.UseCompatibleStateImageBehavior = false;
            this.GamesList.View = System.Windows.Forms.View.Details;
            this.GamesList.SelectedIndexChanged += new System.EventHandler(this.GamesList_SelectedIndexChanged_1);
            // 
            // Name
            // 
            this.Name.Text = "Lliga";
            this.Name.Width = 94;
            // 
            // Player1
            // 
            this.Player1.Text = "Player1";
            this.Player1.Width = 116;
            // 
            // Player2
            // 
            this.Player2.Text = "Player2";
            this.Player2.Width = 117;
            // 
            // Winner
            // 
            this.Winner.Text = "Winner";
            this.Winner.Width = 58;
            // 
            // Lliga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 553);
            this.Controls.Add(this.tabControl1);
            this.Text = "Ping-Pong Competition";
            this.tabControl1.ResumeLayout(false);
            this.Players.ResumeLayout(false);
            this.Players.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Players;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button onDeletePlayer;
        private System.Windows.Forms.Button onEditPlayer;
        private System.Windows.Forms.TextBox editPPicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editPName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button onAddPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addPPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addPName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView playersList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button onUpdatePL;
        private System.Windows.Forms.ListView GamesList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button onStartLeague;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Player1;
        private System.Windows.Forms.ColumnHeader Player2;
        private System.Windows.Forms.ColumnHeader Winner;
        private System.Windows.Forms.Button onCancelLeague;
        private System.Windows.Forms.TextBox infoP2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox infoP1;
        private System.Windows.Forms.Label versus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pointsP2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pointsP1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button onPlayGame;
        private System.Windows.Forms.Button button1;
    }
}

