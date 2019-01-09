using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoServer.Common.Entities;
using LudoServer.Logic.Message.Core;
using LudoServer.Logic.Message.Core.Constants;
namespace LudoServer.Logic.Message.Output
{
    class Output_ConnectionClose : BuiltOutputPackage
    {
        public Output_ConnectionClose()
        {
            AddElement(OutputCipher.Output_Close_Connection.ToString());
            AddElement("El servidor ha cerrado la conexion.");
        }
    }
}
