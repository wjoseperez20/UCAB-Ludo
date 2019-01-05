using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LudoServer.Common.Entities;

namespace LudoServer.Persistence
{
    public class UserJson
    {
        private Game _game;

        public UserJson(Game game)
        {
            _game = game;
            LoadGamers();
        }

        private void LoadGamers()
        {
            using (StreamReader JsonFile = new StreamReader(@"jugadores.txt"))
            {
                string json = JsonFile.ReadToEnd();
                List<Gamer> _gamers = new List<Gamer>();
                _gamers.Clear();
                _gamers = JsonConvert.DeserializeObject<List<Gamer>>(json);

                if (_gamers != null)
                {
                    _game.PlayersRegistered.Clear();
                    _game.PlayersRegistered = _gamers;
                }
            }
        }

        //todo hacer todo esto y pasar esto
        public bool RegistrarJugador(Gamer gamer)
        {
            if (VerificarExiste(gamer))
                return false;

            if (_game.Connected)
                return false;

            if (_game.PlayersRegistered.Count < 1)
            {
                gamer.Id = 1;
            }
            else
            {
                gamer.Id = (_game.PlayersRegistered.OrderBy(j => j.Id).Last().Id + 1);
            }

            _game.PlayersRegistered.Add(gamer);

            JsonSerializer serializer = new JsonSerializer();

            File.Delete(@"jugadores.txt");

            using (StreamWriter jsonFile = File.AppendText(@"jugadores.txt"))
            using (JsonWriter writer = new JsonTextWriter(jsonFile))
            {
                serializer.Serialize(writer, _game.PlayersRegistered);
            }

            return true;

        }

        private bool VerificarExiste(Gamer gamer)
        {
            bool exist = _game.PlayersRegistered.Exists(j => j.User.ToLower() == gamer.User.ToLower());

            return exist;
        }
    }
}
}
