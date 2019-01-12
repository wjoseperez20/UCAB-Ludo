using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoServer.Logic.Message.Core.Constants
{
    class OutputCipher
    {
        public const int Output_Create_Player = 1;
        public const int Output_Failed_Login = 2;
        public const int Output_Close_Connection = 3;
        public const int Output_Reject_Player = 4;
        public const int Output_Delete_Player = 5;
        public const int Output_Start_Game = 6;
        public const int Output_Assing_Player = 7;
    }
}
