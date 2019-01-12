using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoClient.Common.Entities;
using LudoClient.Logic.Message.Core;
using LudoClient.Logic.Message.Core.Constants;
using LudoClient.Logic.Message.Core.Interfaces;
using LudoClient.View.Controller;

namespace LudoClient.Logic.Message.Input
{
    class Input_AssingPlayer : IMessageInput
    {
        public void Execute(PackageServer message, Player player, Game game, ViewsController viewsController)
        {
            int idPlayer = message.PopInt();

            if (idPlayer == player.Id || game.Players.Exists(u => u.Id == idPlayer))
            {
                return;
            }

            string name = message.PopString();

            Player _newPlayer = new Player(name);

            _newPlayer.Id = idPlayer;
            _newPlayer.Position = message.PopInt();
            _newPlayer.Turn_Active = message.PopBool();
            game.AssignPlayerChip(_newPlayer, message.PopInt());
            _newPlayer.PrincipalPlayer = false;

            game.Players.Add(_newPlayer);
        }
    }
}
