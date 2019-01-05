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
using LudoServer.Logic.Message.Client;

namespace LudoServer.Services
{
    public class Connection
    {
        private IPAddress _ip_address;
        private int _port;
        private TcpListener _server;
        private ServerView _form;
        private Game _game;
        private MessageManager _messageManager;
        private PackageClient _packageClient;

        public bool Create_Connection(ServerView form, int countGamers, Game game)
        {
            try
            {
                string ip_server = ConfigurationManager.AppSettings["ip_server"];
                string port_server = ConfigurationManager.AppSettings["port_server"];

                IPAddress.TryParse(ip_server, out _ip_address);

                _port = Convert.ToInt32(port_server);

                _form = form;

                _messageManager = new MessageManager();

                _server = new TcpListener(_ip_address, _port);

                _server.Start();

                _game = game;

                _server.BeginAcceptTcpClient(AcceptingClient, _server);

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

                MessageBox.Show("MI primera conexion", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);


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

    }
}
