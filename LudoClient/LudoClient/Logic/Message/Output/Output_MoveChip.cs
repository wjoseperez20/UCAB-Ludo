using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoClient.Common.Entities;
using LudoClient.Logic.Message.Core;
using LudoClient.Logic.Message.Core.Constants;

namespace LudoClient.Logic.Message.Output
{
   public  class Output_MoveChip : BuiltOutputPackage
    {
        public Output_MoveChip(Player player, int idChip)
        {
            AddElement(OutputCipher.Output_Move_Chip.ToString());
            AddElement(player.Id.ToString());
            AddElement(idChip.ToString());
        }
    }
}
