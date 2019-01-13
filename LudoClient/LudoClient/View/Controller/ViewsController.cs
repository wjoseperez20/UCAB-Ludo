using LudoClient.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            _board.LoadPrincipalPlayer();
            _board.ShowPrincipalPlayer();
            _board.ShowChips();
            _login.ManageWindows(_board);
            UpdateInfoPlayers();
            UpdateTurning();
        }

        public void UpdateTurning()
        {
            _board.UpdateTurning();
        }

        public void UpdateInfoPlayers()
        {
            _board.UpdatePlayers();

        }

        public void ShowMessageMonitor(string message)
        {
            _board.ShowInformation(message);
        }

        public void ShowPrincipalMessage(string message)
        {
            MessageBox.Show(message, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void CloseWindows()
        {
            _login.CloseWindow();
            _board.CloseWindow();
        }


    }
}
