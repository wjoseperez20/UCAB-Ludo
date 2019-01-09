using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoServer.Logic.Message.Core.Interfaces;
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
        private int _countPlayer;
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

        public int CountPlayer
        {
            get { return _countPlayer; }
            set { _countPlayer = value; }
        }

        private void CreateChips()
        {
            for (int i = 1; i <= 4; i++)
            {
                Chips.Add(new Chip(i));
            }
        }

        public void AssignChipPlayer(Player player)
        {
            if (player.Chip != null)
                return;

            player.Chip = _game.Chips.Find(f => !f.Assigned);
            player.Chip.Assigned = true;
        }

        public void RestartGame()
        {
            InitValues();
        }

        public void SendBroadCastMessage(IMessageOutput mensaje)
        {
            foreach (Player x in PlayersConnected)
            {
                x.SendMessage(mensaje);
            }
        }

        public Player GetPlayerById(int id)
        {
            return PlayersConnected.Find(x => x.Id == id);
        }

        public Player GetPlayerByTurn(int turn)
        {
            return PlayersConnected.Find(x => x.Turn == turn);
        }

        public Player GetActiveTurnPlayer()
        {
            return PlayersConnected.Find(x => x.Turn_Active);
        }

        public bool RegisterPlayer(Player player)
        {
            return _json.RegisterPlayer(player);
        }

    }
}
