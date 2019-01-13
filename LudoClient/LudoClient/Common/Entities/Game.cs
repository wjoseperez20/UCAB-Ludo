using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Dictionary<int, Point> _normalCoordinatesBlue;
        public Dictionary<int, Point> _normalCoordinatesYellow;
        public Dictionary<int, Point> _normalCoordinatesRed;
        public Dictionary<int, Point> _normalCoordinatesGreen;

        private Game()
        {
            StartedGame = false;
            _normalCoordinatesBlue = new Dictionary<int, Point>();
            _normalCoordinatesYellow = new Dictionary<int, Point>();
            _normalCoordinatesRed = new Dictionary<int, Point>();
            _normalCoordinatesGreen = new Dictionary<int, Point>();
            CreateCommonCordinatesBlue();
            CreateCommonCordinatesYellow();
            CreateCommonCordinatesRed();
            CreateCommonCordinatesGreen();
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
            chip.AssingCoordinateChip(0,56,221);
            Chips.Add(chip);

            chip = new Chip(2, "Amarillo");
            chip.AssingCoordinateChip(0, 462, 290);
            Chips.Add(chip);

            chip = new Chip(3, "Azul");
            chip.AssingCoordinateChip(0, 226, 462);
            Chips.Add(chip);

            chip = new Chip(4, "Verde");
            chip.AssingCoordinateChip(0, 293, 49);
            Chips.Add(chip);

        }

        private void CreateCommonCordinatesBlue()
        {
            _normalCoordinatesBlue.Add(1, new Point(226, 462));
            _normalCoordinatesBlue.Add(2, new Point(226, 429));
            _normalCoordinatesBlue.Add(3, new Point(226, 394));
            _normalCoordinatesBlue.Add(4, new Point(226, 359));
            _normalCoordinatesBlue.Add(5, new Point(226, 325));
            _normalCoordinatesBlue.Add(6, new Point(192, 290));
            _normalCoordinatesBlue.Add(7, new Point(158, 290));
            _normalCoordinatesBlue.Add(8, new Point(124, 290));
            _normalCoordinatesBlue.Add(9, new Point(91, 290));
            _normalCoordinatesBlue.Add(10, new Point(56, 290));
            _normalCoordinatesBlue.Add(11, new Point(23, 290));
            _normalCoordinatesBlue.Add(12, new Point(23, 255));
            _normalCoordinatesBlue.Add(13, new Point(23, 221));
            _normalCoordinatesBlue.Add(14, new Point(56, 221));
            _normalCoordinatesBlue.Add(15, new Point(91, 221));
            _normalCoordinatesBlue.Add(16, new Point(124, 221));
            _normalCoordinatesBlue.Add(17, new Point(158, 221));
            _normalCoordinatesBlue.Add(18, new Point(190, 221));
            _normalCoordinatesBlue.Add(19, new Point(225, 186));
            _normalCoordinatesBlue.Add(20, new Point(225, 152));
            _normalCoordinatesBlue.Add(21, new Point(225, 118));
            _normalCoordinatesBlue.Add(22, new Point(225, 84));
            _normalCoordinatesBlue.Add(23, new Point(225, 49));
            _normalCoordinatesBlue.Add(24, new Point(225, 14));
            _normalCoordinatesBlue.Add(25, new Point(260, 14));
            _normalCoordinatesBlue.Add(26, new Point(293, 14));
            _normalCoordinatesBlue.Add(27, new Point(293, 49));
            _normalCoordinatesBlue.Add(28, new Point(293, 83));
            _normalCoordinatesBlue.Add(29, new Point(293, 117));
            _normalCoordinatesBlue.Add(30, new Point(293, 152));
            _normalCoordinatesBlue.Add(31, new Point(293, 186));
            _normalCoordinatesBlue.Add(32, new Point(327, 221));
            _normalCoordinatesBlue.Add(33, new Point(361, 221));
            _normalCoordinatesBlue.Add(34, new Point(395, 221));
            _normalCoordinatesBlue.Add(35, new Point(429, 221));
            _normalCoordinatesBlue.Add(36, new Point(462, 221));
            _normalCoordinatesBlue.Add(37, new Point(496, 221));
            _normalCoordinatesBlue.Add(38, new Point(496, 256));
            _normalCoordinatesBlue.Add(39, new Point(496, 290));
            _normalCoordinatesBlue.Add(40, new Point(462, 290));
            _normalCoordinatesBlue.Add(41, new Point(428, 290));
            _normalCoordinatesBlue.Add(42, new Point(395, 290));
            _normalCoordinatesBlue.Add(43, new Point(361, 290));
            _normalCoordinatesBlue.Add(44, new Point(328, 290));
            _normalCoordinatesBlue.Add(45, new Point(293, 325));
            _normalCoordinatesBlue.Add(46, new Point(293, 360));
            _normalCoordinatesBlue.Add(47, new Point(293, 395));
            _normalCoordinatesBlue.Add(48, new Point(293, 429));
            _normalCoordinatesBlue.Add(49, new Point(293, 463));
            _normalCoordinatesBlue.Add(50, new Point(293, 497));
            _normalCoordinatesBlue.Add(51, new Point(259, 497));
            _normalCoordinatesBlue.Add(52, new Point(226, 497));
        }

        private void CreateCommonCordinatesRed()
        {
            _normalCoordinatesRed.Add(1, new Point(56, 221));
            _normalCoordinatesRed.Add(2, new Point(91, 221));
            _normalCoordinatesRed.Add(3, new Point(124, 221));
            _normalCoordinatesRed.Add(4, new Point(158, 221));
            _normalCoordinatesRed.Add(5, new Point(190, 221));
            _normalCoordinatesRed.Add(6, new Point(225, 186));
            _normalCoordinatesRed.Add(7, new Point(225, 152));
            _normalCoordinatesRed.Add(8, new Point(225, 118));
            _normalCoordinatesRed.Add(9, new Point(225, 84));
            _normalCoordinatesRed.Add(10, new Point(225, 49));
            _normalCoordinatesRed.Add(11, new Point(225, 14));
            _normalCoordinatesRed.Add(12, new Point(260, 14));
            _normalCoordinatesRed.Add(13, new Point(293, 14));
            _normalCoordinatesRed.Add(14, new Point(293, 49));
            _normalCoordinatesRed.Add(15, new Point(293, 83));
            _normalCoordinatesRed.Add(16, new Point(293, 117));
            _normalCoordinatesRed.Add(17, new Point(293, 152));
            _normalCoordinatesRed.Add(18, new Point(293, 186));
            _normalCoordinatesRed.Add(19, new Point(327, 221));
            _normalCoordinatesRed.Add(20, new Point(361, 221));
            _normalCoordinatesRed.Add(21, new Point(395, 221));
            _normalCoordinatesRed.Add(22, new Point(429, 221));
            _normalCoordinatesRed.Add(23, new Point(462, 221));
            _normalCoordinatesRed.Add(24, new Point(496, 221));
            _normalCoordinatesRed.Add(25, new Point(496, 256));
            _normalCoordinatesRed.Add(26, new Point(496, 290));
            _normalCoordinatesRed.Add(27, new Point(462, 290));
            _normalCoordinatesRed.Add(28, new Point(428, 290));
            _normalCoordinatesRed.Add(29, new Point(395, 290));
            _normalCoordinatesRed.Add(30, new Point(361, 290));
            _normalCoordinatesRed.Add(31, new Point(328, 290));
            _normalCoordinatesRed.Add(32, new Point(293, 325));
            _normalCoordinatesRed.Add(33, new Point(293, 360));
            _normalCoordinatesRed.Add(34, new Point(293, 395));
            _normalCoordinatesRed.Add(35, new Point(293, 429));
            _normalCoordinatesRed.Add(36, new Point(293, 463));
            _normalCoordinatesRed.Add(37, new Point(293, 497));
            _normalCoordinatesRed.Add(38, new Point(259, 497));
            _normalCoordinatesRed.Add(39, new Point(226, 497));
            _normalCoordinatesRed.Add(40, new Point(226, 462));
            _normalCoordinatesRed.Add(41, new Point(226, 429));
            _normalCoordinatesRed.Add(42, new Point(226, 394));
            _normalCoordinatesRed.Add(43, new Point(226, 359));
            _normalCoordinatesRed.Add(44, new Point(226, 325));
            _normalCoordinatesRed.Add(45, new Point(192, 290));
            _normalCoordinatesRed.Add(46, new Point(158, 290));
            _normalCoordinatesRed.Add(47, new Point(124, 290));
            _normalCoordinatesRed.Add(48, new Point(91, 290));
            _normalCoordinatesRed.Add(49, new Point(56, 290));
            _normalCoordinatesRed.Add(50, new Point(23, 290));
            _normalCoordinatesRed.Add(51, new Point(23, 255));
            _normalCoordinatesRed.Add(52, new Point(23, 221));
        }

        private void CreateCommonCordinatesYellow()
        {
            _normalCoordinatesYellow.Add(1, new Point(462, 290));
            _normalCoordinatesYellow.Add(2, new Point(428, 290));
            _normalCoordinatesYellow.Add(3, new Point(395, 290));
            _normalCoordinatesYellow.Add(4, new Point(361, 290));
            _normalCoordinatesYellow.Add(5, new Point(328, 290));
            _normalCoordinatesYellow.Add(6, new Point(293, 325));
            _normalCoordinatesYellow.Add(7, new Point(293, 360));
            _normalCoordinatesYellow.Add(8, new Point(293, 395));
            _normalCoordinatesYellow.Add(9, new Point(293, 429));
            _normalCoordinatesYellow.Add(10, new Point(293, 463));
            _normalCoordinatesYellow.Add(11, new Point(293, 497));
            _normalCoordinatesYellow.Add(12, new Point(259, 497));
            _normalCoordinatesYellow.Add(13, new Point(226, 497));
            _normalCoordinatesYellow.Add(14, new Point(226, 462));
            _normalCoordinatesYellow.Add(15, new Point(226, 429));
            _normalCoordinatesYellow.Add(16, new Point(226, 394));
            _normalCoordinatesYellow.Add(17, new Point(226, 359));
            _normalCoordinatesYellow.Add(18, new Point(226, 325));
            _normalCoordinatesYellow.Add(19, new Point(192, 290));
            _normalCoordinatesYellow.Add(20, new Point(158, 290));
            _normalCoordinatesYellow.Add(21, new Point(124, 290));
            _normalCoordinatesYellow.Add(22, new Point(91, 290));
            _normalCoordinatesYellow.Add(23, new Point(56, 290));
            _normalCoordinatesYellow.Add(24, new Point(23, 290));
            _normalCoordinatesYellow.Add(25, new Point(23, 255));
            _normalCoordinatesYellow.Add(26, new Point(23, 221));
            _normalCoordinatesYellow.Add(27, new Point(56, 221));
            _normalCoordinatesYellow.Add(28, new Point(91, 221));
            _normalCoordinatesYellow.Add(29, new Point(124, 221));
            _normalCoordinatesYellow.Add(30, new Point(158, 221));
            _normalCoordinatesYellow.Add(31, new Point(190, 221));
            _normalCoordinatesYellow.Add(32, new Point(225, 186));
            _normalCoordinatesYellow.Add(33, new Point(225, 152));
            _normalCoordinatesYellow.Add(34, new Point(225, 118));
            _normalCoordinatesYellow.Add(35, new Point(225, 84));
            _normalCoordinatesYellow.Add(36, new Point(225, 49));
            _normalCoordinatesYellow.Add(37, new Point(225, 14));
            _normalCoordinatesYellow.Add(38, new Point(260, 14));
            _normalCoordinatesYellow.Add(39, new Point(293, 14));
            _normalCoordinatesYellow.Add(40, new Point(293, 49));
            _normalCoordinatesYellow.Add(41, new Point(293, 83));
            _normalCoordinatesYellow.Add(42, new Point(293, 117));
            _normalCoordinatesYellow.Add(43, new Point(293, 152));
            _normalCoordinatesYellow.Add(44, new Point(293, 186));
            _normalCoordinatesYellow.Add(45, new Point(327, 221));
            _normalCoordinatesYellow.Add(46, new Point(361, 221));
            _normalCoordinatesYellow.Add(47, new Point(395, 221));
            _normalCoordinatesYellow.Add(48, new Point(429, 221));
            _normalCoordinatesYellow.Add(49, new Point(462, 221));
            _normalCoordinatesYellow.Add(50, new Point(496, 221));
            _normalCoordinatesYellow.Add(51, new Point(496, 256));
            _normalCoordinatesYellow.Add(52, new Point(496, 290));

        }

        private void CreateCommonCordinatesGreen()
        {
            _normalCoordinatesGreen.Add(1, new Point(293, 49));
            _normalCoordinatesGreen.Add(2, new Point(293, 83));
            _normalCoordinatesGreen.Add(3, new Point(293, 117));
            _normalCoordinatesGreen.Add(4, new Point(293, 152));
            _normalCoordinatesGreen.Add(5, new Point(293, 186));
            _normalCoordinatesGreen.Add(6, new Point(327, 221));
            _normalCoordinatesGreen.Add(7, new Point(361, 221));
            _normalCoordinatesGreen.Add(8, new Point(395, 221));
            _normalCoordinatesGreen.Add(9, new Point(429, 221));
            _normalCoordinatesGreen.Add(10, new Point(462, 221));
            _normalCoordinatesGreen.Add(11, new Point(496, 221));
            _normalCoordinatesGreen.Add(12, new Point(496, 256));
            _normalCoordinatesGreen.Add(13, new Point(496, 290));
            _normalCoordinatesGreen.Add(14, new Point(462, 290));
            _normalCoordinatesGreen.Add(15, new Point(428, 290));
            _normalCoordinatesGreen.Add(16, new Point(395, 290));
            _normalCoordinatesGreen.Add(17, new Point(361, 290));
            _normalCoordinatesGreen.Add(18, new Point(328, 290));
            _normalCoordinatesGreen.Add(19, new Point(293, 325));
            _normalCoordinatesGreen.Add(20, new Point(293, 360));
            _normalCoordinatesGreen.Add(21, new Point(293, 395));
            _normalCoordinatesGreen.Add(22, new Point(293, 429));
            _normalCoordinatesGreen.Add(23, new Point(293, 463));
            _normalCoordinatesGreen.Add(24, new Point(293, 497));
            _normalCoordinatesGreen.Add(25, new Point(259, 497));
            _normalCoordinatesGreen.Add(26, new Point(226, 497));
            _normalCoordinatesGreen.Add(27, new Point(226, 462));
            _normalCoordinatesGreen.Add(28, new Point(226, 429));
            _normalCoordinatesGreen.Add(29, new Point(226, 394));
            _normalCoordinatesGreen.Add(30, new Point(226, 359));
            _normalCoordinatesGreen.Add(31, new Point(226, 325));
            _normalCoordinatesGreen.Add(32, new Point(192, 290));
            _normalCoordinatesGreen.Add(33, new Point(158, 290));
            _normalCoordinatesGreen.Add(34, new Point(124, 290));
            _normalCoordinatesGreen.Add(35, new Point(91, 290));
            _normalCoordinatesGreen.Add(36, new Point(56, 290));
            _normalCoordinatesGreen.Add(37, new Point(23, 290));
            _normalCoordinatesGreen.Add(38, new Point(23, 255));
            _normalCoordinatesGreen.Add(39, new Point(23, 221));
            _normalCoordinatesGreen.Add(40, new Point(56, 221));
            _normalCoordinatesGreen.Add(41, new Point(91, 221));
            _normalCoordinatesGreen.Add(42, new Point(124, 221));
            _normalCoordinatesGreen.Add(43, new Point(158, 221));
            _normalCoordinatesGreen.Add(44, new Point(190, 221));
            _normalCoordinatesGreen.Add(45, new Point(225, 186));
            _normalCoordinatesGreen.Add(46, new Point(225, 152));
            _normalCoordinatesGreen.Add(47, new Point(225, 118));
            _normalCoordinatesGreen.Add(48, new Point(225, 84));
            _normalCoordinatesGreen.Add(49, new Point(225, 49));
            _normalCoordinatesGreen.Add(50, new Point(225, 14));
            _normalCoordinatesGreen.Add(51, new Point(260, 14));
            _normalCoordinatesGreen.Add(52, new Point(293, 14));

        }
    }
}
