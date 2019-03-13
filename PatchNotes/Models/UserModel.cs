namespace PatchNotes
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using SQLite;


    public partial class Welcome
    {
        public Response Response { get; set; }
    }

    public partial class Response
    {
        public List<Player> Players { get; set; }
    }

    public partial class Player
    {
        public string Steamid { get; set; }
        public long Communityvisibilitystate { get; set; }
        public long Profilestate { get; set; }
        public string Personaname { get; set; }
        public long Lastlogoff { get; set; }
        public Uri Profileurl { get; set; }
        public Uri Avatar { get; set; }
        public Uri Avatarmedium { get; set; }
        public Uri Avatarfull { get; set; }
        public long Personastate { get; set; }
        public string Realname { get; set; }

    }
}