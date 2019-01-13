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
            CreateChips();
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

        public void AssignPlayerChip(Player player, int idChip)
        {
            if (player.Chip != null)
                return;

            player.Chip = Chips.Find(x => x.Id == idChip);
        }

        private void CreateChips()
        {
            Chip chip;

            chip = new Chip(1, "Rojo");
            chip.AssingCoordinateChip(0, 495, 498);
            chip.AssingCoordinateChip(1, 447, 510);
            chip.AssingCoordinateChip(2, 402, 510);
            chip.AssingCoordinateChip(3, 357, 510);
            chip.AssingCoordinateChip(4, 311, 510);
            chip.AssingCoordinateChip(5, 267, 510);
            chip.AssingCoordinateChip(6, 220, 510);
            chip.AssingCoordinateChip(7, 175, 510);
            chip.AssingCoordinateChip(8, 129, 510);
            chip.AssingCoordinateChip(9, 85, 510);
            chip.AssingCoordinateChip(10, 16, 510);
            chip.AssingCoordinateChip(11, 37, 448);
            chip.AssingCoordinateChip(12, 37, 403);
            chip.AssingCoordinateChip(13, 37, 258);
            chip.AssingCoordinateChip(14, 37, 312);
            chip.AssingCoordinateChip(15, 37, 266);
            chip.AssingCoordinateChip(16, 37, 220);
            chip.AssingCoordinateChip(17, 37, 175);
            chip.AssingCoordinateChip(18, 37, 129);
            chip.AssingCoordinateChip(19, 37, 83);
            chip.AssingCoordinateChip(20, 37, 16);
            chip.AssingCoordinateChip(21, 107, 16);
            chip.AssingCoordinateChip(22, 152, 16);
            chip.AssingCoordinateChip(23, 197, 16);
            chip.AssingCoordinateChip(24, 243, 16);
            chip.AssingCoordinateChip(25, 289, 16);
            chip.AssingCoordinateChip(26, 334, 16);
            chip.AssingCoordinateChip(27, 380, 16);
            chip.AssingCoordinateChip(28, 425, 16);
            chip.AssingCoordinateChip(29, 470, 16);
            chip.AssingCoordinateChip(30, 540, 16);
            chip.AssingCoordinateChip(31, 540, 84);
            chip.AssingCoordinateChip(32, 540, 129);
            chip.AssingCoordinateChip(33, 540, 175);
            chip.AssingCoordinateChip(34, 540, 220);
            chip.AssingCoordinateChip(35, 540, 266);
            chip.AssingCoordinateChip(36, 540, 312);
            chip.AssingCoordinateChip(37, 540, 358);
            chip.AssingCoordinateChip(38, 540, 403);
            chip.AssingCoordinateChip(39, 540, 448);
            Chips.Add(chip);

            chip = new Chip(2, "Amarillo");
            chip.AssingCoordinateChip(0, 495, 498);
            chip.AssingCoordinateChip(1, 447, 510);
            chip.AssingCoordinateChip(2, 402, 510);
            chip.AssingCoordinateChip(3, 357, 510);
            chip.AssingCoordinateChip(4, 311, 510);
            chip.AssingCoordinateChip(5, 267, 510);
            chip.AssingCoordinateChip(6, 220, 510);
            chip.AssingCoordinateChip(7, 175, 510);
            chip.AssingCoordinateChip(8, 129, 510);
            chip.AssingCoordinateChip(9, 85, 510);
            chip.AssingCoordinateChip(10, 16, 510);
            chip.AssingCoordinateChip(11, 37, 448);
            chip.AssingCoordinateChip(12, 37, 403);
            chip.AssingCoordinateChip(13, 37, 258);
            chip.AssingCoordinateChip(14, 37, 312);
            chip.AssingCoordinateChip(15, 37, 266);
            chip.AssingCoordinateChip(16, 37, 220);
            chip.AssingCoordinateChip(17, 37, 175);
            chip.AssingCoordinateChip(18, 37, 129);
            chip.AssingCoordinateChip(19, 37, 83);
            chip.AssingCoordinateChip(20, 37, 16);
            chip.AssingCoordinateChip(21, 107, 16);
            chip.AssingCoordinateChip(22, 152, 16);
            chip.AssingCoordinateChip(23, 197, 16);
            chip.AssingCoordinateChip(24, 243, 16);
            chip.AssingCoordinateChip(25, 289, 16);
            chip.AssingCoordinateChip(26, 334, 16);
            chip.AssingCoordinateChip(27, 380, 16);
            chip.AssingCoordinateChip(28, 425, 16);
            chip.AssingCoordinateChip(29, 470, 16);
            chip.AssingCoordinateChip(30, 540, 16);
            chip.AssingCoordinateChip(31, 540, 84);
            chip.AssingCoordinateChip(32, 540, 129);
            chip.AssingCoordinateChip(33, 540, 175);
            chip.AssingCoordinateChip(34, 540, 220);
            chip.AssingCoordinateChip(35, 540, 266);
            chip.AssingCoordinateChip(36, 540, 312);
            chip.AssingCoordinateChip(37, 540, 358);
            chip.AssingCoordinateChip(38, 540, 403);
            chip.AssingCoordinateChip(39, 540, 448);
            Chips.Add(chip);

            chip = new Chip(3, "Azul");
            chip.AssingCoordinateChip(0, 495, 498);
            chip.AssingCoordinateChip(1, 447, 510);
            chip.AssingCoordinateChip(2, 402, 510);
            chip.AssingCoordinateChip(3, 357, 510);
            chip.AssingCoordinateChip(4, 311, 510);
            chip.AssingCoordinateChip(5, 267, 510);
            chip.AssingCoordinateChip(6, 220, 510);
            chip.AssingCoordinateChip(7, 175, 510);
            chip.AssingCoordinateChip(8, 129, 510);
            chip.AssingCoordinateChip(9, 85, 510);
            chip.AssingCoordinateChip(10, 16, 510);
            chip.AssingCoordinateChip(11, 37, 448);
            chip.AssingCoordinateChip(12, 37, 403);
            chip.AssingCoordinateChip(13, 37, 258);
            chip.AssingCoordinateChip(14, 37, 312);
            chip.AssingCoordinateChip(15, 37, 266);
            chip.AssingCoordinateChip(16, 37, 220);
            chip.AssingCoordinateChip(17, 37, 175);
            chip.AssingCoordinateChip(18, 37, 129);
            chip.AssingCoordinateChip(19, 37, 83);
            chip.AssingCoordinateChip(20, 37, 16);
            chip.AssingCoordinateChip(21, 107, 16);
            chip.AssingCoordinateChip(22, 152, 16);
            chip.AssingCoordinateChip(23, 197, 16);
            chip.AssingCoordinateChip(24, 243, 16);
            chip.AssingCoordinateChip(25, 289, 16);
            chip.AssingCoordinateChip(26, 334, 16);
            chip.AssingCoordinateChip(27, 380, 16);
            chip.AssingCoordinateChip(28, 425, 16);
            chip.AssingCoordinateChip(29, 470, 16);
            chip.AssingCoordinateChip(30, 540, 16);
            chip.AssingCoordinateChip(31, 540, 84);
            chip.AssingCoordinateChip(32, 540, 129);
            chip.AssingCoordinateChip(33, 540, 175);
            chip.AssingCoordinateChip(34, 540, 220);
            chip.AssingCoordinateChip(35, 540, 266);
            chip.AssingCoordinateChip(36, 540, 312);
            chip.AssingCoordinateChip(37, 540, 358);
            chip.AssingCoordinateChip(38, 540, 403);
            chip.AssingCoordinateChip(39, 540, 448);
            Chips.Add(chip);

            chip = new Chip(4, "Verde");
            chip.AssingCoordinateChip(0, 495, 498);
            chip.AssingCoordinateChip(1, 447, 510);
            chip.AssingCoordinateChip(2, 402, 510);
            chip.AssingCoordinateChip(3, 357, 510);
            chip.AssingCoordinateChip(4, 311, 510);
            chip.AssingCoordinateChip(5, 267, 510);
            chip.AssingCoordinateChip(6, 220, 510);
            chip.AssingCoordinateChip(7, 175, 510);
            chip.AssingCoordinateChip(8, 129, 510);
            chip.AssingCoordinateChip(9, 85, 510);
            chip.AssingCoordinateChip(10, 16, 510);
            chip.AssingCoordinateChip(11, 37, 448);
            chip.AssingCoordinateChip(12, 37, 403);
            chip.AssingCoordinateChip(13, 37, 258);
            chip.AssingCoordinateChip(14, 37, 312);
            chip.AssingCoordinateChip(15, 37, 266);
            chip.AssingCoordinateChip(16, 37, 220);
            chip.AssingCoordinateChip(17, 37, 175);
            chip.AssingCoordinateChip(18, 37, 129);
            chip.AssingCoordinateChip(19, 37, 83);
            chip.AssingCoordinateChip(20, 37, 16);
            chip.AssingCoordinateChip(21, 107, 16);
            chip.AssingCoordinateChip(22, 152, 16);
            chip.AssingCoordinateChip(23, 197, 16);
            chip.AssingCoordinateChip(24, 243, 16);
            chip.AssingCoordinateChip(25, 289, 16);
            chip.AssingCoordinateChip(26, 334, 16);
            chip.AssingCoordinateChip(27, 380, 16);
            chip.AssingCoordinateChip(28, 425, 16);
            chip.AssingCoordinateChip(29, 470, 16);
            chip.AssingCoordinateChip(30, 540, 16);
            chip.AssingCoordinateChip(31, 540, 84);
            chip.AssingCoordinateChip(32, 540, 129);
            chip.AssingCoordinateChip(33, 540, 175);
            chip.AssingCoordinateChip(34, 540, 220);
            chip.AssingCoordinateChip(35, 540, 266);
            chip.AssingCoordinateChip(36, 540, 312);
            chip.AssingCoordinateChip(37, 540, 358);
            chip.AssingCoordinateChip(38, 540, 403);
            chip.AssingCoordinateChip(39, 540, 448);
            Chips.Add(chip);

        }
    }
}
