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
    class Output_StartGame : BuiltOutputPackage
    {
        public Output_StartGame(Game game)
        {
            AddElement(OutputCipher.Output_Start_Game.ToString());
            AddElement(game.PlayersConnected.Count.ToString());

            foreach (Player player in game.PlayersConnected)
            {
                AddElement(player.Id.ToString());
                AddElement(player.Turn.ToString());
            }
        }
    }
}
