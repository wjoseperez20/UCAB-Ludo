using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoClient.Common.Entities;
using LudoClient.Logic.Message.Core;
using LudoClient.Logic.Message.Core.Constants;
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
        }
    }
}
