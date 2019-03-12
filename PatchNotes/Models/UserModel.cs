namespace PatchNotes
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using SQLite;
   

    public partial class Response
    {
        [JsonProperty("players", NullValueHandling = NullValueHandling.Ignore)]
        public Player[] Players { get; set; }
    }

    public partial class Player
    {
        [PrimaryKey, AutoIncrement]
        [JsonProperty("steamid", NullValueHandling = NullValueHandling.Ignore)]
        public string Steamid { get; set; }

        [JsonProperty("communityvisibilitystate", NullValueHandling = NullValueHandling.Ignore)]
        public long? Communityvisibilitystate { get; set; }

        [JsonProperty("profilestate", NullValueHandling = NullValueHandling.Ignore)]
        public long? Profilestate { get; set; }

        [JsonProperty("personaname", NullValueHandling = NullValueHandling.Ignore)]
        public string Personaname { get; set; }

        [JsonProperty("lastlogoff", NullValueHandling = NullValueHandling.Ignore)]
        public long? Lastlogoff { get; set; }

        [JsonProperty("profileurl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Profileurl { get; set; }

        [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Avatar { get; set; }

        [JsonProperty("avatarmedium", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Avatarmedium { get; set; }

        [JsonProperty("avatarfull", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Avatarfull { get; set; }

        [JsonProperty("personastate", NullValueHandling = NullValueHandling.Ignore)]
        public long? Personastate { get; set; }

        [JsonProperty("realname", NullValueHandling = NullValueHandling.Ignore)]
        public string Realname { get; set; }

        [JsonProperty("primaryclanid", NullValueHandling = NullValueHandling.Ignore)]
        public string Primaryclanid { get; set; }

        [JsonProperty("timecreated", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timecreated { get; set; }

        [JsonProperty("personastateflags", NullValueHandling = NullValueHandling.Ignore)]
        public long? Personastateflags { get; set; }

        [JsonProperty("loccountrycode", NullValueHandling = NullValueHandling.Ignore)]
        public string Loccountrycode { get; set; }
    }


}