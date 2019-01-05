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
using LudoClient.Logic.Message.Server;
using System.Windows.Forms;

namespace LudoClient.Services
{
   public class Connection
    {
        private ViewsController _views;
        private Game _game;
        private Player _player;
        private MessageManager _mensajeManager;
        private PackageServer _packageServer;

        public bool CreateConnection(LogIn form,string name, string password)
        {
            try
            {
                string ip_server = ConfigurationManager.AppSettings["ip_server"];
                string port_server = ConfigurationManager.AppSettings["port_server"];

                _player = new Player(name, password);
                _player.Client = new TcpClient();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar contactar con el servidor");
                return false;
            }

        }
    }
}
