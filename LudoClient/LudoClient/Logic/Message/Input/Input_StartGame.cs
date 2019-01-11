using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoClient.Common.Entities;
using LudoClient.Logic.Message.Core;
using LudoClient.Logic.Message.Core.Interfaces;
using LudoClient.View.Controller;

namespace LudoClient.Logic.Message.Input
{
   public  class Input_StartGame : IMessageInput
    {
        public void Execute(PackageServer message, Player player, Game game, ViewsController viewsController) {

            int countPlayers= message.PopInt();

            Player _playerTurn = null;
            int idPlayer = 0, turnPlayer = 0;

            for (int i = 0; i < countPlayers; i++)
            {
                idPlayer = message.PopInt();
                turnPlayer = message.PopInt();

                _playerTurn = game.Players.Find(j => j.Id == idPlayer);

                if (_playerTurn == null)
                {
                    return;
                }

                _playerTurn.Turn = turnPlayer;

                if (_playerTurn.Turn == 1)
                    _playerTurn.Turn_Active = true;
            }

            game.StartedGame = true;

            viewsController.StartGame();
        }
    }
}
