using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoClient.Common.Entities;
using LudoClient.Logic.Message.Core;
using LudoClient.Logic.Message.Core.Interfaces;
using LudoClient.View.Controller;

namespace LudoClient.Logic.Message.Input
{
    class Input_DeletePlayer : IMessageInput
    {
        public void Execute(PackageServer message, Player player, Game game, ViewsController viewsController)
        {
            int idPlayer = message.PopInt();
            bool reassignTurn = message.PopBool();
            int idPlayerTurn = message.PopInt();

            Player _deletePlayer = game.GetPlayerById(idPlayer);

            if (_deletePlayer == null)
                return;

            game.Players.Remove(_deletePlayer);

            //lista de players

            if (game.StartedGame)
            {
                if (game.Players.Count == 1)
                {
                    MessageBox.Show("Felicidades ganaste la partida!");
                    viewsController.CloseWindows();
                    return;
                }

                if (reassignTurn)
                {
                    Player _playerTurn = game.GetPlayerById(idPlayerTurn);

                    if (_playerTurn == null)
                        return;

                    _playerTurn.Turn_Active = true;
                   // grafico.ActualizarTurno();
                }

                //grafico.EliminarFichaJugador(_jugadorBorrado);
                //grafico.ActualizarInfoJugadores();

            }
        }
    }
}
