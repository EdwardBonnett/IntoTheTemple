using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextAdventure.Models
{
    public class Room
    {
        [JsonProperty("l")]
        public string LastAction { get; set; }

        [JsonProperty("r")]
        public string RoomText { get; set; }

        [JsonProperty("o")]
        public List<OptionsText> Options { get; set; }

        [JsonProperty("c")]
        public string Class { get; set; }

        [JsonProperty("f")]
        public string Font { get; set; }
    }

    public class OptionsText
    {
        [JsonProperty("i")]
        public int Id { get; set; }

        [JsonProperty("t")]
        public string Text { get; set; }
    }
}
