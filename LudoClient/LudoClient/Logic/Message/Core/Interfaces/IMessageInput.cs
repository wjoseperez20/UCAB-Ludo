using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoClient.Logic.Message.Core;
using LudoClient.Common.Entities;
using LudoClient.View.Controller;

namespace LudoClient.Logic.Message.Core.Interfaces
{
    public interface IMessageInput
    {
        void Execute(PackageServer message, Player player, Game game, ViewsController viewsController);
    }
}
