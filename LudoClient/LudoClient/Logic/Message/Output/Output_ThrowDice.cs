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
   public  class Output_ThrowDice : BuiltOutputPackage
    {
        public Output_ThrowDice(Player player)
        {
            AddElement(OutputCipher.Output_Throw_Dice.ToString());
            AddElement(player.Id.ToString());
        }
    }
}
