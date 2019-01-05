using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoServer.Common.Entities
{
    public class Dice
    {
        private static int _diceGame;
        private static bool _throwAgain = false;
        private static int _diceResult;

        static Random rand = new Random();

        public static int DiceGame
        {
            get { return _diceGame; }
            set { _diceGame = value; }
        }

        public static bool ThrowAgain
        {
            get { return _throwAgain; }
            set { _throwAgain = value; }
        }

        public static int DiceResult
        {
            get { return _diceResult; }
            set { _diceResult = value; }
        }

        public static int throwDice()
        {
            DiceGame = rand.Next(1, 7);
           
            if (DiceGame == 7)
                ThrowAgain = true;
            else
                ThrowAgain = false;

            DiceResult = DiceGame;

            return _diceGame;
        }
    }
}
