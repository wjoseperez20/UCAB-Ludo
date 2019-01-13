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
            blueChipLabel.Parent = boardLabel;
            blueChipLabel.BackColor = Color.Transparent;
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

        private void Board_Load(object sender, EventArgs e)
        {
            blueChipLabel.Parent = boardLabel;
            blueChipLabel.BackColor = Color.Transparent;
        }

        private void Board_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cerrar el juego?", "¡Atención!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("¡Cobarde! Que mal perdedor", ">:(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Jaja casi pierdes todo tu esfuerzo", ":D", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

               MonitorBoardPlayer.Items.Add(player.Chip.Name + ": " + player.Name + " Turno Activo: " + turn.ToUpper());
            }
        }

        public void ShowChips()
        {
            foreach (Player player in _game.Players)
            {
                if (player.Chip.Id == 1)
                    player.Chip.AssignLabel(blueChipLabel);
                else if (player.Chip.Id == 2)
                    player.Chip.AssignLabel(blueChipLabel);
                else if (player.Chip.Id == 3)
                    player.Chip.AssignLabel(blueChipLabel);
                else
                    player.Chip.AssignLabel(blueChipLabel);

                player.Chip.Image.Visible = true;
                player.Chip.Image.Location = player.Chip.Coordinates[0];
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void throwDiceButton_Click(object sender, EventArgs e)
        {

        }

        private void blueChipLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
