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
            blueChipLabel1.Visible = false;
            blueChipLabel2.Visible = false;
            blueChipLabel3.Visible = false;
            blueChipLabel4.Visible = false;

            redChipLabel1.Visible = false;
            redChipLabel2.Visible = false;
            redChipLabel3.Visible = false;
            redChipLabel4.Visible = false;

            greenChipLabel1.Visible = false;
            greenChipLabel2.Visible = false;
            greenChipLabel3.Visible = false;
            greenChipLabel4.Visible = false;

            yellowChipLabel1.Visible = false;
            yellowChipLabel2.Visible = false;
            yellowChipLabel3.Visible = false;
            yellowChipLabel4.Visible = false;
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

            blueChipLabel1.Parent = boardLabel;
            blueChipLabel1.BackColor = Color.Transparent;
            blueChipLabel2.Parent = boardLabel;
            blueChipLabel2.BackColor = Color.Transparent;
            blueChipLabel3.Parent = boardLabel;
            blueChipLabel3.BackColor = Color.Transparent;
            blueChipLabel4.Parent = boardLabel;
            blueChipLabel4.BackColor = Color.Transparent;

            redChipLabel1.Parent = boardLabel;
            redChipLabel1.BackColor = Color.Transparent;
            redChipLabel2.Parent = boardLabel;
            redChipLabel2.BackColor = Color.Transparent;
            redChipLabel3.Parent = boardLabel;
            redChipLabel3.BackColor = Color.Transparent;
            redChipLabel4.Parent = boardLabel;
            redChipLabel4.BackColor = Color.Transparent;

            greenChipLabel1.Parent = boardLabel;
            greenChipLabel1.BackColor = Color.Transparent;
            greenChipLabel2.Parent = boardLabel;
            greenChipLabel2.BackColor = Color.Transparent;
            greenChipLabel3.Parent = boardLabel;
            greenChipLabel3.BackColor = Color.Transparent;
            greenChipLabel4.Parent = boardLabel;
            greenChipLabel4.BackColor = Color.Transparent;

            yellowChipLabel1.Parent = boardLabel;
            yellowChipLabel1.BackColor = Color.Transparent;
            yellowChipLabel2.Parent = boardLabel;
            yellowChipLabel2.BackColor = Color.Transparent;
            yellowChipLabel3.Parent = boardLabel;
            yellowChipLabel3.BackColor = Color.Transparent;
            yellowChipLabel4.Parent = boardLabel;
            yellowChipLabel4.BackColor = Color.Transparent;


        }

        private void Board_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
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

               MonitorBoardPlayer.Items.Add(player.Name + " Turno Activo: " + turn.ToUpper());
            }
        }

        public void ShowChips()
        {
            foreach (Player player in _game.Players)
            {
                AssignPlayerChip(player);
            }
        }

        private void AssignPlayerChip(Player player)
        {
            if (player.Color == ColorPlayer.AZUL)
            {
                AssignBlueChips(player);
            }
            else if (player.Color == ColorPlayer.ROJO)
            {
                AssignRedChips(player);
            }
            else if (player.Color == ColorPlayer.AMARILLO)
            {
                AssignYellowChips(player);
            }
            else
            {
                AssignGreenChips(player);
            }
        }

        private void AssignBlueChips(Player player)
        {

            player.Chips[0].AssignLabel(blueChipLabel1, player._startCoordinates[1]);
            player.Chips[1].AssignLabel(blueChipLabel2, player._startCoordinates[2]);
            player.Chips[2].AssignLabel(blueChipLabel3, player._startCoordinates[3]);
            player.Chips[3].AssignLabel(blueChipLabel4, player._startCoordinates[4]);
        }

        private void AssignRedChips(Player player)
        {
            player.Chips[0].AssignLabel(redChipLabel1, player._startCoordinates[1]);
            player.Chips[1].AssignLabel(redChipLabel2, player._startCoordinates[2]);
            player.Chips[2].AssignLabel(redChipLabel3, player._startCoordinates[3]);
            player.Chips[3].AssignLabel(redChipLabel4, player._startCoordinates[4]);
        }

        private void AssignGreenChips(Player player)
        {
            player.Chips[0].AssignLabel(greenChipLabel1, player._startCoordinates[1]);
            player.Chips[1].AssignLabel(greenChipLabel2, player._startCoordinates[2]);
            player.Chips[2].AssignLabel(greenChipLabel3, player._startCoordinates[3]);
            player.Chips[3].AssignLabel(greenChipLabel4, player._startCoordinates[4]);
        }

        private void AssignYellowChips(Player player)
        {
            player.Chips[0].AssignLabel(yellowChipLabel1, player._startCoordinates[1]);
            player.Chips[1].AssignLabel(yellowChipLabel2, player._startCoordinates[2]);
            player.Chips[2].AssignLabel(yellowChipLabel3, player._startCoordinates[3]);
            player.Chips[3].AssignLabel(yellowChipLabel4, player._startCoordinates[4]);
        }

        public void LoadPrincipalPlayer()
        {
            principalPlayer = _game.Players.Find(j => j.PrincipalPlayer);
        }

        public void ShowPrincipalPlayer()
        {
            string message = "Jugador: " + principalPlayer.Name + " - Turno: " + principalPlayer.Turn.ToString() + " - Color: " + principalPlayer.ColorToString().ToUpper();
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
            principalPlayer.ThrowDiceChip();
        }

        private void blueChipLabel_Click(object sender, EventArgs e)
        {

        }

        private void noteLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void powerOffButton_Click(object sender, EventArgs e)
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
                MessageBox.Show("Jaja casi pierdes todo tu esfuerzo", ":D", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonChip1_Click(object sender, EventArgs e)
        {
            principalPlayer.MoveChip(1);
        }

        private void buttonChip2_Click(object sender, EventArgs e)
        {
            principalPlayer.MoveChip(2);
        }

        private void buttonChip3_Click(object sender, EventArgs e)
        {
            principalPlayer.MoveChip(3);
        }

        private void buttonChip4_Click(object sender, EventArgs e)
        {
            principalPlayer.MoveChip(4);
        }

        public void MoveChipPrincipalPlayer(int idChip, int newPosition)
        {
            Chip chip = principalPlayer.Chips.Find(c => c.Id == idChip);

            chip.Image.Invoke(new Action<Player, Label, int>(InvokeMoveChip), principalPlayer, chip.Image, newPosition);
        }

        private void InvokeMoveChip(Player player, Label chip, int Position)
        {
            chip.Location = player._normalCoordinates[Position];
        }
    }
}
