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
   public  class Output_CreatePlayer : BuiltOutputPackage
    {
        public Output_CreatePlayer(Player player)
        {
            AddElement(OutputCipher.Output_Create_Player.ToString());
            AddElement(player.Name);
            AddElement(player.Password);
        }
    }
}
