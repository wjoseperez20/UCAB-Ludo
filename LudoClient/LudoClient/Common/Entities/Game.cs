using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoClient.Common.Entities
{
    public class Game
    {
        public List<Player> Players = new List<Player>();
        public List<Chip> Chips = new List<Chip>();
        private int _countPlayers;
        public bool StartedGame;
        private static Game _game;

        private Game()
        {
            StartedGame = false;
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

        public int CountPlayers
        {
            get { return _countPlayers; }
            set { _countPlayers = value; }
        }

        public Player GetPlayerById(int id)
        {
            return Players.Find(x => x.Id == id);
        }

        public Player GetPlayerByTurn(int turn)
        {
            return Players.Find(x => x.Turn == turn);
        }

        public Player GetActiveTurnPlayer()
        {
            return Players.Find(x => x.Turn_Active);
        }
    }
}
