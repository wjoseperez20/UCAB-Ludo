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
    class Output_RejectPlayer : BuiltOutputPackage
    {
        public Output_RejectPlayer(Game _game, string message)
        {
            AddElement(OutputCipher.Output_Reject_Player.ToString());
            AddElement(message);
        }
    }
}
