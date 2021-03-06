﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoServer.Logic.Message.Core
{
    public class PackageClient
    {
        private string[] _message;
        private int _position;

        public PackageClient(string[] message)
        {
            _message = message;
            _position = 0;
        }

        public string PopString()
        {
            _position++;
            return _message[_position - 1];
        }

        public int PopInt()
        {
            _position++;
            return Convert.ToInt32(_message[_position - 1]);
        }

        public bool PopBool()
        {
            _position++;
            return Convert.ToBoolean(_message[_position - 1]);
        }

        public string GetITem(int pos)
        {
            return _message[pos];
        }

    }
}
