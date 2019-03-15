aqusing System;
namespace PatchNotes
{
    public class SteamCreds
    {
        // public static string steamURL = "https://api.steampowered.com/";
        

        public static string APIkey = "192C0E2A89AEDE4560CED98B453747FC";
        public static string steamID = "76561198029031522";

        public static string GetOwnedGames = "https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key=192C0E2A89AEDE4560CED98B453747FC&include_appinfo=1&steamid=76561198029031522";
        public static string GetRecentlyPlayed = "https://api.steampowered.com/IPlayerService/GetRecentlyPlayedGames/v1/?key=192C0E2A89AEDE4560CED98B453747FC&steamid=76561198029031522";
        public static string AppNews = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?appid=220&count=5&maxlength=300&format=json";
        public static string PlayerSummaries = "http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=192C0E2A89AEDE4560CED98B453747FC&steamids=76561198029031522";`

    }
}
