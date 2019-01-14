using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using LudoClient.Logic.Message.Core.Interfaces;
using System.Windows.Forms;
using LudoClient.Logic.Message.Output;
using System.Drawing;

namespace LudoClient.Common.Entities
{
    public class Player
    {
        private int _id;
        private string _name;
        private string _password;
        private int _resultDice;
        private bool _turn_active;
        private int _turn;
        public int Position;
        private bool _principalPlayer;
        private TcpClient _client;
        private ColorPlayer _color;
        public Dictionary<int, Point> _normalCoordinates;
        public Dictionary<int, Point> _startCoordinates;
        public Dictionary<int, Point> _preHouseCoordinates;
        public byte[] Reading;
        public byte[] Writing;
        public List<Chip> Chips = new List<Chip>();

        public Player(string name, string password)
        {
            _name = name;
            _password = password;
            _turn_active = false;
            _turn = 0;
            Reading = new byte[512];
        }

        public Player(string name)
        {
            _name = name;
            _turn_active = false;
            Reading = new byte[512];
        }

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name
        {
            get { return this._name; }
        }

        public int ResultDice
        {
            get { return this._resultDice; }
            set { this._resultDice = value; }
        }

        public bool Turn_Active
        {
            get { return this._turn_active; }
            set { this._turn_active = value; }
        }

        public TcpClient Client
        {
            get { return this._client; }
            set { this._client = value; }
        }

        public string Password
        {
            get { return _password; }
        }

        public int Turn
        {
            get { return _turn; }
            set { _turn = value; }
        }

        public bool PrincipalPlayer
        {
            get { return this._principalPlayer; }
            set { this._principalPlayer = value; }
        }

        public void ThrowDiceChip()
        {
            SendMessage(new Output_ThrowDice(this));
        }

        public void MoveChip(int idChip)
        {
            SendMessage(new Output_MoveChip(this, idChip));

        }

        public ColorPlayer Color
        {
            get { return this._color; }
            set { this._color = value; }
        }


        public string ColorToString()
        {
            string retorno = "";

            if (_color == ColorPlayer.AZUL)
                retorno = "Azul";
            else if (_color == ColorPlayer.ROJO)
                retorno = "Rojo";
            else if (_color == ColorPlayer.VERDE)
                retorno = "Verde";
            else
                retorno = "Amarillo";

            return retorno;
        }

        public void SendMessage(IMessageOutput IMessageOutput)
        {
            try
            {
                string[] package = IMessageOutput.GetMessage();

                if (_client == null)
                    return;

                if (!_client.Connected)
                    return;

                string message = string.Join(";", package);

                Writing = Encoding.ASCII.GetBytes(message);
                _client.GetStream().Write(Writing, 0, Writing.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().FullName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
