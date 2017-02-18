using System;
using System.Collections.Generic;

namespace LolInfo.Services.ServiceModels
{
    public class ChampionDto
    {
        public List<string> AllyTips { get; set; }

        public string Blurb { get; set; }

        public List<string> EnemyTips { get; set; }

        public int Id { get; set; }

        public ImageDto Image { get; set; }

        //public InfoDto Info { get; set; }

        public string Key { get; set; }

        public string Lore { get; set; }

        public string Name { get; set; }

        public string ParType { get; set; }

        //public PassiveDto Passive { get; set; }

        //public List<RecommendedDto> Recommended { get; set; }

        //public List<SkinDto> Skins { get; set; }

        //public List<ChampionSpellDto> Spells { get; set; }

        //public StatsDto Stats { get; set; }

        public List<string> Tags { get; set; }

        public string Title { get; set; }
    }
}
