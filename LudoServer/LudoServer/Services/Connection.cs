using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Configuration;
using LudoServer.View;
using LudoServer.Common.Entities;
using LudoServer.Logic.Message.Core;
using LudoServer.Logic.Message.Output;

namespace LudoServer.Services
{
    public class Connection
    {
        private IPAddress _ip_address;
        private int _port;
        private TcpListener _server;
        private ServerView _serverView;
        private Game _game;
        private MessageManager _messageManager;
        private PackageClient _packageClient;

        public bool Create_Connection(ServerView serverView, int countPlayers, Game game)
        {
            try
            {
                string ip_server = ConfigurationManager.AppSettings["ip_server"];
                string port_server = ConfigurationManager.AppSettings["port_server"];

                IPAddress.TryParse(ip_server, out _ip_address);

                _port = Convert.ToInt32(port_server);

                _serverView = serverView;

                _messageManager = new MessageManager();

                _server = new TcpListener(_ip_address, _port);

                _server.Start();

                _serverView.ShowMonitorMessageLog("Conexión abierta.");

                _game = game;

                _game.CountPlayer = countPlayers;

                _server.BeginAcceptTcpClient(AcceptingClient, _server);

                _serverView.ShowMonitorMessageLog("Esperando jugadores...");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
                return false;
            }

        }

        private void AcceptingClient(IAsyncResult AsyncResult)
        {

            _server = (TcpListener)AsyncResult.AsyncState;
            TcpClient Client_Incoming = null;
            Player _player;

            try
            {
                if (_server == null || _server.Server == null)
                    return;

                Client_Incoming = _server.EndAcceptTcpClient(AsyncResult);
                _server.BeginAcceptTcpClient(AcceptingClient, _server);

                _player = new Player();
                _player.Client = Client_Incoming;

                if ((_game.PlayersConnected.Count + 1) > _game.CountPlayer)
                {
                    _player.SendMessage(new Output_RejectPlayer(_game, "Lo sentimos, la partida esta llena. (Numero maximo de jugadores: " + _game.PlayersConnected + ")"));
                    return;
                }

                if (_game.StartedGame)
                {
                    _player.SendMessage(new Output_RejectPlayer(_game, "Lo sentimos el juego ya ha iniciado."));
                    return;
                }

                _serverView.ShowMonitorMessageLog("Recibiendo información de un jugador...");

                lock (_game.PlayersConnected)
                {
                    _game.PlayersConnected.Add(_player);
                }

                _player.Reading = new byte[512];

                _player.Client.Client.BeginReceive(_player.Reading, 0, _player.Reading.Length, 0, new AsyncCallback(ReceivingClientMessage), _player.Client);
 
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Conexión finalizada", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceivingClientMessage(IAsyncResult AsyncResult)
        {
            int nCountReadBytes = 0;
            string messageReceived = "";
            Player _player = null;

            lock (_game.PlayersConnected)
            {
                try
                {
                    _player = _game.PlayersConnected.Find(x => x.Client == (TcpClient)AsyncResult.AsyncState);

                    if (_player == null)
                        return;

                    nCountReadBytes = _player.Client.GetStream().EndRead(AsyncResult);

                    messageReceived = Encoding.ASCII.GetString(_player.Reading, 0, nCountReadBytes).Trim();

                    _packageClient = new PackageClient(messageReceived.Split(';'));

                    _messageManager.RunMessage(_packageClient, _player, _game, _serverView);

                }
                catch (IndexOutOfRangeException)
                {
                    _serverView.ShowMonitorMessageLog("Error al decodificar el mensaje: " + messageReceived);
                }
                catch (System.IO.IOException)
                {
                    _serverView.ShowMonitorMessageLog("ATENCION: El jugador: " + _player.User + " se ha desconectado.");
                    RemovePlayer(_player);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (_player != null)
                    {
                        if (_player.Client.Connected)
                        {
                            _player.Reading = new byte[512];
                            _player.Client.Client.BeginReceive(_player.Reading, 0, _player.Reading.Length, 0, new AsyncCallback(ReceivingClientMessage), _player.Client);
                        }
                    }
                }
            }
        }

        private void RemovePlayer(Player player)
        {
          
            bool reassign = false;

            player.Chip.Assigned = false;

            if (player.Turn_Active)
            {
                _game.ManageTurn();
                reassign = true;
            }

            _game.PlayersConnected.Remove(player);
   
            _game.RecalculateTurnOrder();

            SendDesconnectedPlayer(player, reassign);

            _serverView.ShowPlayerEntryConnected(player, true);
        }

        private void SendDesconnectedPlayer(Player player, bool reassign)
        {
            foreach (Player j in _game.PlayersConnected)
            {
                j.SendMessage(new Output_DeletePlayer(player, reassign));
            }
        }

        public void CloseConnection()
        {
            foreach (Player _player in _game.PlayersConnected)
            {
                _player.SendMessage(new Output_ConnectionClose());
            }
            _server.Stop();
            _server = null;
            _game.RestartGame();

        }
    }
}
