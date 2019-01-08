using LudoServer.Logic.Message.Core;
using LudoServer.Logic.Message.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoServer.Logic.Message.Output
{
    class Output_FailedLogin : BuiltOutputPackage
    {
        public Output_FailedLogin()
        {
            AddElement(OutputCipher.Output_Failed_Login.ToString());
            AddElement("Error al iniciar sesion, datos incorrectos.");
        }
    }
}
