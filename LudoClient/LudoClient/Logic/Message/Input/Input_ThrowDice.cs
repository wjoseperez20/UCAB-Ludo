using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoClient.Common.Entities;
using LudoClient.Logic.Message.Core;
using LudoClient.Logic.Message.Core.Constants;
using LudoClient.Logic.Message.Core.Interfaces;
using LudoClient.View.Controller;

namespace LudoClient.Logic.Message.Input
{
    class Input_ThrowDice : IMessageInput
    {
        public void Execute(PackageServer message, Player player, Game game, ViewsController viewsController)
        {
            int resultDice = message.PopInt();
            bool throwAgain = message.PopBool();

            MessageBox.Show("Saque:" + resultDice+" - Again:"+throwAgain.ToString());            

        }
    }
}
