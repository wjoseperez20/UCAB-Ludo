using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoServer.Logic.Message.Core.Interfaces;

namespace LudoServer.Logic.Message.Core
{
    public class BuiltOutputPackage : IMessageOutput
    {
        private string[] _message;

        public BuiltOutputPackage()
        {
            _message = new string[0];
        }

        public string[] GetMessage()
        {
            return _message;
        }


        public void AddElement(string element)
        {
            int lengthMessage = _message.Length;

            Array.Resize(ref _message, lengthMessage + 1);
            _message[lengthMessage] = element;

        }
    }
}
