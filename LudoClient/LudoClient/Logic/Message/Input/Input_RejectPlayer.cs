using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoClient.Common.Entities;
using LudoClient.Logic.Message.Core;
using LudoClient.Logic.Message.Core.Interfaces;
using LudoClient.View.Controller;

namespace LudoClient.Logic.Message.Input
{
    class Input_RejectPlayer : IMessageInput
    {
        public void Execute(PackageServer message, Player player, Game game, ViewsController viewsController)
        {
            MessageBox.Show(message.PopString());
            viewsController.CloseWindows();
        }
    }
}
