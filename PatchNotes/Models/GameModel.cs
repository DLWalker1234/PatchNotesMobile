

namespace PatchNotes
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using SQLite;


    public partial class Welcome
    {
        public Response Response { get; set; }
    }

    public partial class Response
    {
        public long GameCount { get; set; }
        public List<Game> Games { get; set; }
    }

    public partial class Game
    {
        public long Appid { get; set; }
        public string Name { get; set; }
        public long PlaytimeForever { get; set; }
        public string ImgIconUrl { get; set; }
        public string ImgLogoUrl { get; set; }
        public bool HasCommunityVisibleStats { get; set; }
        public long? Playtime2Weeks { get; set; }
    }
}