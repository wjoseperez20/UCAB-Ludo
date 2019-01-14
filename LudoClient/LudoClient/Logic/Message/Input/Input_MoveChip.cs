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
    class Input_MoveChip : IMessageInput
    {
        public void Execute(PackageServer message, Player player, Game game, ViewsController viewsController)
        {
            int idPlayer = message.PopInt();
            int idChip = message.PopInt();
            int newPositionChip = message.PopInt();
            int idPlayerTurnActive = message.PopInt();

            Game.GetGame.Players.Find(j => j.Turn_Active).Turn_Active = false;

            Game.GetGame.Players.Find(j => j.Id == idPlayerTurnActive).Turn_Active = true;

            viewsController.MoveChip(idPlayer, newPositionChip, idChip);
            viewsController.UpdateTurning();


            
            

        }
    }
}
