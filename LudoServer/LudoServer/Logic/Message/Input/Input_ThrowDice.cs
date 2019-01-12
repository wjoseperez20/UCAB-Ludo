using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoServer.Common.Entities;
using LudoServer.Logic.Message.Core;
using LudoServer.Logic.Message.Core.Interfaces;
using LudoServer.Logic.Message.Output;
using LudoServer.View;

namespace LudoServer.Logic.Message.Input
{
    public class Input_ThrowDice : IMessageInput
    {
        public void Execute(PackageClient message, Player player, Game game, ServerView serverView)
        {
            int idPlayer = message.PopInt();

            Player _player = game.GetPlayerByTurn(idPlayer);

            if (_player == null)
                return;

            game.ManagePlayPlayer(_player);
        }
    }
}
