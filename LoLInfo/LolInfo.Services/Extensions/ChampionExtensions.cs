using System;
using System.Collections.Generic;
using LolInfo.Models;
using LolInfo.Services.ServiceModels;

namespace LolInfo.Services.Extensions
{
    public static class ChampionExtensions
    {
        public static List<Champion> ToChampions(this ChampionListDto champListDto)
        {
            var champions = new List<Champion>();
            foreach (KeyValuePair<string, ChampionDto> entry in champListDto.Data)
            {
                var champ = entry.Value;
                champions.Add(new Champion()
                {
                    Id = champ.Id,
                    Name = champ.Name,
                    Title = champ.Title
                });
            }
            return champions;
        }
    }
}
