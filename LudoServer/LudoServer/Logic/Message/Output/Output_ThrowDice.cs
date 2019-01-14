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
    class Output_ThrowDice : BuiltOutputPackage
    {
        public Output_ThrowDice(Player player)
        {
            AddElement(OutputCipher.Output_Throw_Dice.ToString());
            AddElement(player.ResultDice.ToString());
            AddElement(Dice.ThrowAgain.ToString());
        }
    }
}
