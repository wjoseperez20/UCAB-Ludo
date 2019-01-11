using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoClient.Common.Entities;
using LudoClient.Logic.Message.Core.Constants;
using LudoClient.Logic.Message.Core.Interfaces;
using LudoClient.Logic.Message.Input;
using LudoClient.View.Controller;

namespace LudoClient.Logic.Message.Core
{
    class MessageManager
    {
        private Dictionary<int, IMessageInput> _messagesInput;

        public MessageManager()
        {
            _messagesInput = new Dictionary<int, IMessageInput>();
            RegisterMessages();
        }

        private void RegisterMessages()
        {
            _messagesInput.Add(InputCipher.Input_Create_Player, new Input_CreatePlayer());
            _messagesInput.Add(InputCipher.Input_Failed_Login, new Input_FailedLogin());
            _messagesInput.Add(InputCipher.Input_Close_Connection, new Input_ConnectionClose());
            _messagesInput.Add(InputCipher.Input_Reject_Player, new Input_RejectPlayer());
            _messagesInput.Add(InputCipher.Input_Delete_Player, new Input_DeletePlayer());
            _messagesInput.Add(InputCipher.Input_Start_Game, new Input_StartGame());
        }

        public void RunMessage(PackageServer message, Player player, Game game, ViewsController viewsController)
        {
            IMessageInput IMessageInput = VerifyMessage(message, viewsController);

            if (IMessageInput == null)
                return;

            try
            {
                IMessageInput.Execute(message, player, game, viewsController);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
        }

        private IMessageInput VerifyMessage(PackageServer Split, ViewsController viewsController)
        {
            int Entrycode = -1;
            IMessageInput IMessageInput = null;

            try
            {
                Entrycode = Convert.ToInt32(Split.PopString());

                if (!_messagesInput.TryGetValue(Entrycode, out IMessageInput))
                {
                    return null;
                }

                return IMessageInput;

            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
