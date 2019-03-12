

namespace PatchNotes
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using SQLite;


    public partial class Response
    {
        [JsonProperty("game_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? GameCount { get; set; }

        [JsonProperty("games", NullValueHandling = NullValueHandling.Ignore)]
        public Game[] Games { get; set; }
    }

    public partial class Game
    {
        [PrimaryKey, AutoIncrement]
        [JsonProperty("appid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Appid { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("playtime_forever", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlaytimeForever { get; set; }

        [JsonProperty("img_icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImgIconUrl { get; set; }

        [JsonProperty("img_logo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImgLogoUrl { get; set; }

        [JsonProperty("has_community_visible_stats", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasCommunityVisibleStats { get; set; }

        [JsonProperty("playtime_2weeks", NullValueHandling = NullValueHandling.Ignore)]
        public long? Playtime2Weeks { get; set; }
    }




}
