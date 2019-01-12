using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoClient.Common.Entities;

namespace LudoClient.View
{
    public partial class Board : Form
    {
        Game _game;
        Player principalPlayer;
        private static Board _board = null;

        public Board()
        {
            InitializeComponent();
            _game = Game.GetGame;
        }

        private void Board_Load(object sender, EventArgs e)
        {

        }

        public static Board GetBoard
        {
            get
            {
                if (_board == null)
                    _board = new Board();

                return _board;
            }
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        public void UpdatePlayers()
        {
            MonitorBoardPlayer.Invoke(new Action(ShowPlayers));
        }

        public void UpdateTurning()
        {

            if (principalPlayer.Turn_Active)
            {
                throwDiceButton.Enabled = true;
                ShowInformation("¡ES TU TURNO!");
            }
            else
            {
                throwDiceButton.Enabled = false;
                ShowInformation("Es el turno del jugador: " + _game.GetActiveTurnPlayer().Name);
            }

        }

        private void ShowPlayers()
        {
            MonitorBoardPlayer.Items.Clear();
            foreach (Player player in _game.Players)
            {
                string turn = "";

                if (player.Turn_Active)
                    turn = "Si";
                else
                    turn= "No";

                MonitorBoardPlayer.Items.Add(player.Chip.Name + ": " + player.Name + " Turno Activo: " + turn.ToUpper() + "/3");
            }
        }

        public void LoadPrincipalPlayer()
        {
            principalPlayer = _game.Players.Find(j => j.PrincipalPlayer);
        }

        public void ShowPrincipalPlayer()
        {
            string message = "Jugador: " + principalPlayer.Name + " - Turno: " + principalPlayer.Turn.ToString() + " - Ficha: " + principalPlayer.Chip.Name.ToUpper();
            this.Text = message;
        }

        public void CloseWindow()
        {
            this.Invoke(new Action(InvokeCloseWindow));
        }

        public void ShowInformation(string message)
        {
            monitorLogs.Invoke(new Action<string>(InvokeShowInformation), message);
        }

        private void InvokeShowInformation(string message)
        {
            if (!String.IsNullOrEmpty(monitorLogs.Text))
                monitorLogs.Text = message + Environment.NewLine + monitorLogs.Text;
            else
                monitorLogs.Text = message;
        }

        private void InvokeCloseWindow()
        {
            this.Close();
        }
    }
}
