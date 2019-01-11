using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoServer.Common.Entities;
using LudoServer.Logic.Message.Core;
using LudoServer.Logic.Message.Core.Interfaces;
using LudoServer.Logic.Message.Output;
using LudoServer.View;

namespace LudoServer.Logic.Message.Input
{
    public class Input_Login : IMessageInput
    {
        public void Execute(PackageClient message, Player player, Game game, ServerView serverView)
        {
            player.User = message.PopString();
            player.Password = message.PopString();

            MessageBox.Show(string.Format("Name {0}, PassWord {1}!!!", player.User, player.Password), "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            Player _newJugador = null;

            _newJugador = game.PlayersRegistered.Find(j => j.User.ToLower() == player.User.ToLower() && j.Password == player.Password);

            if (_newJugador == null)
            {
                game.PlayersConnected.Remove(player);
                player.SendMessage(new Output_FailedLogin());
                return;
            }

            player.Id = _newJugador.Id;
            player.Name = _newJugador.Name;
            player.Lastname = _newJugador.Lastname;
            game.AssignChipPlayer(player);

            serverView.ShowPlayerEntryConnected(player, false);

            player.SendMessage(new Output_CreatePlayer(player, game));

        }
    }
}
