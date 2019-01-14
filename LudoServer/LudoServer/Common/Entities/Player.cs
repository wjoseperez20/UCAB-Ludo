using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using LudoServer.Logic.Message.Core.Interfaces;
using System.Windows.Forms;

namespace LudoServer.Common.Entities
{
   public class Player
    {
        private int _id;
        private string _user;
        private string _password;
        private string _name;
        private string _lastname;
        private int _position;
        private bool _turn_active;
        private int _turn;
        public List<Chip> chips;
        private int _resultDice;
        private TcpClient _client;
        private Chip _chip;
        public byte[] Reading;
        public byte[] Writing;

        public Player()
        {
            this._position = 0;
            this._turn_active = false;
            _turn = 0;
            _chip = null;
            chips = new List<Chip>();

        }

        public int Id
        {
            get { return this._id; }
            set { _id = value; }
        }

        public string User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        public int Position
        {
            get { return this._position; }
            set { this._position = value; }
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
            set { _password = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public int Turn
        {
            get { return _turn; }
            set { _turn = value; }
        }

        public Chip Chip
        {
            get { return _chip; }
            set { _chip = value; }
        }

        public int ResultDice { get => _resultDice; set => _resultDice = value; }

        public void Play()
        {
            if (!this._turn_active)
                return;

            _resultDice = Dice.throwDice();

            //CalculatePosition(result_dice);

        }

        public void SendMessage(IMessageOutput IMessageOutput)
        {
            try
            {
                lock (_client)
                {
                    string[] package = IMessageOutput.GetMessage();

                    if (!_client.Connected)
                        return;

                    string message = string.Join(";", package);

                    Writing = Encoding.ASCII.GetBytes(message);
                    _client.GetStream().Write(Writing, 0, Writing.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al enviar mensaje TCP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
