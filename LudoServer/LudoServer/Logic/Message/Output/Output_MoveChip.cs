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
    class Output_MoveChip : BuiltOutputPackage
    {
        public Output_MoveChip(Player player, Chip chip)
        {
            AddElement(OutputCipher.Output_Move_Chip.ToString());
            AddElement(chip.Id.ToString());
            AddElement(chip.Position.ToString());
        }
    }
}
