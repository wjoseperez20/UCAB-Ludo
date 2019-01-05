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
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            using (StreamReader JsonFile = new StreamReader(@"Players.txt"))
            {
                string json = JsonFile.ReadToEnd();
                List<Player> _players = new List<Player>();
                _players.Clear();
                _players = JsonConvert.DeserializeObject<List<Player>>(json);

                if (_players != null)
                {
                    _game.PlayersRegistered.Clear();
                    _game.PlayersRegistered = _players;
                }
            }
        }

        public bool RegisterPlayer(Player player)
        {
            if (Exist(player))
                return false;

            if (_game.Connected)
                return false;

            if (_game.PlayersRegistered.Count < 1)
            {
                player.Id = 1;
            }
            else
            {
                player.Id = (_game.PlayersRegistered.OrderBy(j => j.Id).Last().Id + 1);
            }

            _game.PlayersRegistered.Add(player);

            JsonSerializer serializer = new JsonSerializer();

            File.Delete(@"Players.txt");

            using (StreamWriter jsonFile = File.AppendText(@"Players.txt"))

            using (JsonWriter writer = new JsonTextWriter(jsonFile))
            {
                serializer.Serialize(writer, _game.PlayersRegistered);
            }

            return true;

        }

        private bool Exist(Player player)
        {
            bool exist = _game.PlayersRegistered.Exists(j => j.User.ToLower() == player.User.ToLower());

            return exist;
        }
    }
}

