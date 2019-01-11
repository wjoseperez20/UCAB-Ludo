using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoServer.Services;
using LudoServer.Common.Entities;

namespace LudoServer.View
{
    public partial class ServerView : Form
    {
        Connection Connection = new Connection();

        public ServerView()
        {
            InitializeComponent();
            MonitorListRegisteredPlayers();
            powerOffButton.Enabled = false;
            startGameButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Connection.Create_Connection(this, 3, Game.GetGame))
                MessageBox.Show("Ingresa una dirección IP valida");
            else
            {
                powerOffButton.Enabled = true;
                powerOnButton.Enabled = false;
                registerPlayerButton.Enabled = false;
                startGameButton.Enabled = true;
            }
        }

        private void ServerView_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bRegistarJugador_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(userNameText.Text) || string.IsNullOrEmpty(passwordText.Text)
                 || string.IsNullOrEmpty(nameText.Text) || string.IsNullOrEmpty(lastnameText.Text))
            {
                MessageBox.Show("¡No pueden haber campos vacios!", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Player player = new Player();

            player.User = userNameText.Text;
            player.Password = passwordText.Text;
            player.Name = nameText.Text;
            player.Name = lastnameText.Text;

            if (!Game.GetGame.RegisterPlayer(player))
                MessageBox.Show("El usuario ya esta registrado");
            else
            {
                MessageBox.Show("Usuario registrado con éxito");
                MonitorListRegisteredPlayers();
                userNameText.Clear();
                passwordText.Clear();
                nameText.Clear();
                lastnameText.Clear();
            }
        }

        private void powerOffButton_Click(object sender, EventArgs e)
        {
            ClearServer();
            Connection.CloseConnection();
        }

        public void ShowPlayerEntryConnected(Player player, bool remove)
        {
            listConnectedPlayers.Invoke(new Action<Player, bool>(MonitorListConnetedPlayers), player, remove);
        }

        public void ClearServer()
        {
            monitorLogs.Clear();
            startGameButton.Enabled = false;
            powerOnButton.Enabled = true;
            powerOffButton.Enabled= false;
            registerPlayerButton.Enabled = true;
            listConnectedPlayers.Items.Clear();

        }

        public void MonitorListRegisteredPlayers()
        {
            listRecordPlayers.Items.Clear();

            foreach (Player j in Game.GetGame.PlayersRegistered.OrderBy(j => j.Id))
            {
                listRecordPlayers.Items.Add("Id: " + j.Id + " - Usuario: " + j.User);
            }
        }

        private void MonitorListConnetedPlayers(Player player, bool remove)
        {
            if (!remove)
                listConnectedPlayers.Items.Add(player.User);
            else
                listConnectedPlayers.Items.Remove(player.User);
        }
    }
}
