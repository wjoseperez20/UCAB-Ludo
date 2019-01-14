using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoServer.Logic.Message.Core.Interfaces;
using LudoServer.Logic.Message.Output;
using LudoServer.Persistence;
using LudoServer.Common.Entities.Squares;
using System.Windows.Forms;

namespace LudoServer.Common.Entities
{
    public class Game
    {
        public List<Player> PlayersRegistered;
        public List<Player> PlayersConnected;
        public List<Square> Squares;
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

        public bool StartGame()
        {
            if (PlayersConnected.Count < _countPlayer)
                return false;


            StartedGame = true;

            CalculateTurnOrder();

            AssignTurnPlayer();

            return true;

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

        public void ThrowDicePlayer(Player player)
        {
            player.Play();

            player.SendMessage(new Output_ThrowDice(player));
        }

        public void ManagePlayChip(Player player, int idChip)
        {

            Chip chipToMove = player.chips.Find(c => c.Id == idChip);

            chipToMove.CalculatePosition(player.ResultDice);

            ManageTurn();

            SendBroadCastMessage(new Output_MoveChip(player, chipToMove));



            /*Square _square = Squares.Find(c => c.Position == SquareId);

            if (_square == null)
                return;

            _square.ExecuteEffect(player);*/
        }


        public void AssignChipPlayer(Player player)
        {
            if (player.Chip != null)
                return;

            player.Chip = _game.Chips.Find(f => !f.Assigned);
            player.Chip.Assigned = true;

            player.chips.Add(new Chip(1));
            player.chips.Add(new Chip(2));
            player.chips.Add(new Chip(3));
            player.chips.Add(new Chip(4));
        }

        public void AssignTurnPlayer()
        {
            foreach (Player player in PlayersConnected)
            {
                player.SendMessage(new Output_StartGame(this));
            }
        }

        private void CalculateTurnOrder()
        {
            List<int> TurnOrder = new List<int>();

            for (int i = 1; i <= PlayersConnected.Count; i++)
            {
                TurnOrder.Add(i);
            }

            int index = 0;

            foreach (Player player in PlayersConnected)
            {
                index = functionRandom.Next(0, TurnOrder.Count);
                player.Turn = TurnOrder.ElementAt(index);
                TurnOrder.RemoveAt(index);

                if (player.Turn == 1)
                    player.Turn_Active = true;
            }
        }

        public void RecalculateTurnOrder()
        {
            List<int> TurnOrder = new List<int>();

            for (int i = 1; i <= PlayersConnected.Count; i++)
            {
                TurnOrder.Add(i);
            }

            int index = 0;

            foreach (Player player in PlayersConnected.OrderBy(x => x.Turn))
            {
                player.Turn = TurnOrder.ElementAt(index);
                TurnOrder.RemoveAt(index);
            }
        }

        public void ManageTurn()
        {
            Player PlayerTurnActive = GetActiveTurnPlayer();

            if (PlayerTurnActive == null)
                return;

            int turnActual = PlayerTurnActive.Turn;

            PlayerTurnActive.Turn_Active = false;

            if (turnActual < PlayersConnected.Count)
                turnActual = turnActual + 1;
            else
                turnActual = 1;

            Player NextIdPlayerTurn = GetPlayerByTurn(turnActual);

            if (NextIdPlayerTurn == null)
                return;

            NextIdPlayerTurn.Turn_Active = true;

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
