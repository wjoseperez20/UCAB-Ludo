using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoServer.Common.Entities.Square
{
    class Start : Square
    {
        public override void ExecuteEffect(Player player)
        {
            Game.GetGame.ManageTurn();

          //  Game.GetGame.SendBroadCastMessage(new Servidor_TurnoSencillo(player));
        }
    }
}
