using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoServer.Common.Entities;
using LudoServer.Logic.Message.Core;
using LudoServer.Logic.Message.Core.Constants;
namespace LudoServer.Logic.Message.Output
{
    class Output_DeletePlayer : BuiltOutputPackage
    {
        public Output_DeletePlayer(Player player, bool reassign)
        {
            AddElement(OutputCipher.Output_Delete_Player.ToString());
            AddElement(player.Id.ToString());
            AddElement(reassign.ToString());

            if (reassign)
                AddElement(Game.GetGame.GetActiveTurnPlayer().Id.ToString());
            else
                AddElement("-1");
        }
    }
}
