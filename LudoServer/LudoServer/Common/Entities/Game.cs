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
        public List<Player> PlayersRegistered;
        public List<Player> PlayersConnected;
        public List<Chip> Chips;
        public bool Connected;
        public bool StartedGame;
        private int _countGamers;
        private UserJson _json;
        private Random functionRandom;
        private static Game _game = null;

        private Game()
        {
            InitValues();
        }

        public static Game GetGame
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
            PlayersRegistered = new List<Player>();

            PlayersConnected = new List<Player>();

            Chips = new List<Chip>();

            CreateChips();

            Connected = false;

            _json = new UserJson(this);

            StartedGame = false;

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
