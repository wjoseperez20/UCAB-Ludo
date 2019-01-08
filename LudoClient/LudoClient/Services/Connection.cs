using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Configuration;
using LudoClient.View;
using LudoClient.View.Controller;
using LudoClient.Common.Entities;
using LudoClient.Logic.Message.Core;
using LudoClient.Logic.Message.Output;
using System.Windows.Forms;

namespace LudoClient.Services
{
   public class Connection
    {
        private ViewsController _viewsController;
        private Game _game;
        private Player _player;
        private MessageManager _messageManager;
        private PackageServer _packageServer;

        public bool CreateConnection(Login logIn,string name, string password)
        {
            try
            {
                string ip_server = ConfigurationManager.AppSettings["ip_server"];
                string port_server = ConfigurationManager.AppSettings["port_server"];

                _player = new Player(name, password); 
                _player.Client = new TcpClient();

                _game = Game.GetGame;

                Board _board = Board.GetBoard;

                _viewsController = new ViewsController(logIn, _board);

                _messageManager = new MessageManager();

                _player.Client.BeginConnect(ip_server, Convert.ToInt32(port_server), CompleteConnection, _player.Client);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al intentar contactar con el servidor");
                return false;
            }

        }

        void CompleteConnection(IAsyncResult iar)
        {

            try
            {
                _player.Client = (TcpClient)iar.AsyncState;
                _player.Client.EndConnect(iar);
                _player.Reading = new byte[512];

                _player.Client.GetStream().BeginRead(_player.Reading, 0, _player.Reading.Length, ServerRead, _player.Client);

                _player.SendMessage(new Output_CreatePlayer(_player));

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al recibir respuesta del servidor.");
            }

        }

        void ServerRead(IAsyncResult iar)
        {
            int BytesReceived;
            string messageReceived;

            try
            {

                _player.Client = (TcpClient)iar.AsyncState;
                BytesReceived = _player.Client.GetStream().EndRead(iar);

                if (BytesReceived == 0)
                {
                    MessageBox.Show("Conexión cerrada.");
                    return;
                }

                messageReceived = Encoding.ASCII.GetString(_player.Reading, 0, BytesReceived);

                _packageServer = new PackageServer(messageReceived.Split(';'));
                _messageManager.RunMessage(_packageServer, _player, _game, _viewsController);

                _player.Reading = new byte[512];
                _player.Client.GetStream().BeginRead(_player.Reading, 0, _player.Reading.Length, ServerRead, _player.Client);
            }
            catch (Exception e)
            {
                MessageBox.Show("El servidor ha cerrado la conexión.");
            }
        }
    }
}
