using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoClient.Logic.Message.Core.Constants
{
    public static class InputCipher
    {
        public const int Input_Create_Player = 1;
        public const int Input_Failed_Login = 2;
        public const int Input_Close_Connection = 3;
        public const int Input_Reject_Player = 4;
        public const int Input_Delete_Player = 5;
        public const int Input_Start_Game = 6;
        public const int Input_Assing_Player = 7;
    }
}
