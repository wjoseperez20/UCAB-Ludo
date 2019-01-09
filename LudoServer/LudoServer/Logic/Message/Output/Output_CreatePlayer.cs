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
    public class Output_CreatePlayer : BuiltOutputPackage
    {
        public Output_CreatePlayer(Player player, Game game)
        {
            AddElement(OutputCipher.Output_Create_Player.ToString());
            AddElement(player.Id.ToString());
            AddElement(player.Position.ToString());
            AddElement(player.Chip.Id.ToString());

            AddElement((game.PlayersConnected.Count - 1).ToString());

            foreach (Player j in game.PlayersConnected.Where(u => u.Id != player.Id))
            {
                AddElement(j.User);
                AddElement(j.Id.ToString());
                AddElement(j.Position.ToString());
                AddElement(j.Chip.Id.ToString());
            }
        }
    }
}
