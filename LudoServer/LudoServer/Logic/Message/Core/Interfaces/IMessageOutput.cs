using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoServer.Logic.Message.Core;
using LudoServer.Common.Entities;
using LudoServer.View;


namespace LudoServer.Logic.Message.Core.Interfaces
{
    public interface IMessageOutput
    {
        void Execute(PackageClient message, Player player, Game game, ServerView serverView);
    }
}
