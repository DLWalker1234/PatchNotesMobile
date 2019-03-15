using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PatchNotes
{
    public class SteamService : ISteamService
    {
        private string Url = "https://api.steampowered.com/";

        public async Task<List<Game>> GetGames()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(Url);

            var Games = JsonConvert.DeserializeObject<List<Game>>(json);

            return Games;
        }

        public async Task<Player>GetPlayer()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(Url);

            var Player = JsonConvert.DeserializeObject<Player>(json);

            return Player;
        }


    }
}


