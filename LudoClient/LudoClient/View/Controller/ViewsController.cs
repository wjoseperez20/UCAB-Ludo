using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoClient.View.Controller
{
    public class ViewsController
    {
        private Login _login;
        private Board _board;

        public ViewsController(Login Login, Board Board)
        {
            _login = Login;
            _board = Board;
        }

        public Login LoginGame
        {
            get { return _login; }
            set { _login = value; }
        }

        public Board BoardGame
        {
            get { return _board; }
            set { _board = value; }
        }

        public void EnableLoginButton()
        {
            _login.EnableLoginButton();
        }

        public void StartGame()
        {
        
        }

        public void CloseWindows()
        {
            _login.CloseWindow();
            _board.CloseWindow();
        }

    }
}
