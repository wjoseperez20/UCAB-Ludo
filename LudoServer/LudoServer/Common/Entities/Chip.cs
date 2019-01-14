using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoServer.Common.Entities
{
    public class Chip
    {
        private int _id;
        private bool _assigned;
        private int _position;

        public Chip(int id)
        {
            _id = id;
            _position = 1;
        }

        public int Id
        {
            get { return _id; }
        }

        public bool Assigned
        {
            get { return _assigned; }
            set { _assigned = value; }
        }

        public int Position { get => _position; }

        public void CalculatePosition(int result_dice)
        {
            int positionBoard = this._position + result_dice;

            if (positionBoard > 52)
            {
                this._position = positionBoard - 52;
                //house
            }
            else
            {
                this._position = positionBoard;
            }
        }
    }
}
