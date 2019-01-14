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
            int idChip = message.PopInt();
            int newPositionChip = message.PopInt();

            viewsController.MoveChip(newPositionChip, idChip);


            
            

        }
    }
}
