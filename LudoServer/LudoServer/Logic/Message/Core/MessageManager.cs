using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoServer.Common.Entities;
using LudoServer.Logic.Message.Core.Constants;
using LudoServer.Logic.Message.Core.Interfaces;
using LudoServer.Logic.Message.Input;
using LudoServer.View;

namespace LudoServer.Logic.Message.Core
{
    public class MessageManager
    {
        private Dictionary<int, IMessageInput> _messagesInput;

        public MessageManager()
        {
            _messagesInput = new Dictionary<int, IMessageInput>();
            RegisterMessages();
        }

        private void RegisterMessages()
        {
            _messagesInput.Add(InputCipher.Input_Login, new Input_Login());
        }

        public void RunMessage(PackageClient message, Player player, Game game, ServerView serverView)
        {
            IMessageInput IMessageInput = VerifyMessage(message, serverView);

            if (IMessageInput == null)
                return;

            try
            {
                IMessageInput.Execute(message, player, game, serverView);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
        }

        private IMessageInput VerifyMessage(PackageClient Split, ServerView serverView)
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
