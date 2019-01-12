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
    class Output_AssingPlayer : BuiltOutputPackage
    {
        public Output_AssingPlayer(Player player)
        {
            AddElement(OutputCipher.Output_Close_Connection.ToString());
            AddElement(player.Id.ToString()); 
            AddElement(player.User.ToString());
            AddElement(player.Position.ToString()); 
            AddElement(false.ToString());
            AddElement(player.Chip.Id.ToString());
        }
    }
}
