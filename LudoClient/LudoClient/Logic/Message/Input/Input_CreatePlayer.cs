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
   public  class Input_CreatePlayer : IMessageInput
    {
        public void Execute(PackageServer message, Player player, Game game, ViewsController viewsController) {

            player.Id = message.PopInt();
            player.Position = message.PopInt();
            player.Turn_Active = message.PopBool();
            game.AssignPlayerChip(player, message.PopInt());

            game.CountPlayers = message.PopInt();
            int _connectedPlayers = message.PopInt();

            Player _assignPlayer;

            for (int i = 0; i < _connectedPlayers; i++)
            {
                _assignPlayer = new Player(message.PopString());
                _assignPlayer.Id = message.PopInt();
                _assignPlayer.Position = message.PopInt();
                _assignPlayer.Turn_Active = message.PopBool();

                game.AssignPlayerChip(_assignPlayer, message.PopInt());
                _assignPlayer.PrincipalPlayer = false;

                game.Players.Add(_assignPlayer);

            }

            game.Players.Add(player);
        }
    }
}
