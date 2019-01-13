using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LudoClient.Common.Entities.Squares
{
    public abstract class Square
    {
        private int _position;
        private SquareType _type;
        private Image _image;

        public abstract void ExecuteEfect(Player player);

        public int Position
        {
            get { return this._position; }
            set { _position = value; }
        }

        public SquareType Type
        {
            get { return this._type; }
            set { _type = value; }
        }

        public Image Image
        {
            get { return this._image; }
            set { _image = value; }
        }

    }
}
