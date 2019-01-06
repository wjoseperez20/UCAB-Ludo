using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoClient.View.Controller
{
    public class ViewsController
    {
        private LogIn _logIn;
        private Board _board;

        public ViewsController(LogIn LogIn, Board Board)
        {
            _logIn = LogIn;
            _board = Board;
        }

        public LogIn LogInGame
        {
            get { return _logIn; }
            set { _logIn = value; }
        }

        public Board BoardGame
        {
            get { return _board; }
            set { _board = value; }
        }
    }
}
