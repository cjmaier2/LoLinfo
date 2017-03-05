using System;
using System.Collections.Generic;

namespace LolInfo.Services.ServiceModels
{
    public class ChampionListDto
    {
        public Dictionary<string, ChampionDto> Data { get; set; } 

        public string Format { get; set; }

        public Dictionary<string, string> Keys { get; set; }

        public string Type { get; set; }

        public string Version { get; set; }
    }
}
