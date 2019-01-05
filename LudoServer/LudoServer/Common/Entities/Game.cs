using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoServer.Persistence;

namespace LudoServer.Common.Entities
{
    public class Game
    {
        public List<Gamer> PlayersRegistered;
        public List<Gamer> PlayersConnected;
        public List<Chip> Chips;
        public bool Connected;
        private int _countGamers;
        private UserJson _json;
        public bool Iniciado;
        private Random functionRandom;
        private static Game _game = null;

        private Game()
        {
            InitValues();
        }

        public static Game ObtenerJuego
        {
            get
            {
                if (_game == null)
                    _game = new Game();

                return _game;
            }

            private set { }
        }

        private void InitValues()
        {
            PlayersRegistered = new List<Gamer>();

            PlayersConnected = new List<Gamer>();

            Chips = new List<Chip>();

            CreateChips();

            Connected = false;

            _json = new UserJson(this);

            Iniciado = false;

            functionRandom = new Random();
        }

        private void CreateChips()
        {
            for (int i = 1; i <= 4; i++)
            {
                Chips.Add(new Chip(i));
            }
        }
    }
}
