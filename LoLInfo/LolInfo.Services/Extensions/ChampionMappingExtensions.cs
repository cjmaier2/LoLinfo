using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using LolInfo.Models;
using LolInfo.Services.ServiceModels;

namespace LolInfo.Services.Extensions
{
    public static class ChampionMappingExtensions
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
                    SearchName = Regex.Replace(champ.Name.ToUpper(), @"[^\w\.@-]", ""), //strip special characters
                    Title = champ.Title,
                    SquareImageUrl = string.Format(ServiceConstants.ChampionSquareImageUrl, champ.Image.Full),
                    Skins = GetSkins(champ.Key, champ.Skins)
                });
            }
            return champions.OrderBy(c => c.Name).ToList();
        }

        public static List<Skin> GetSkins(string champKey, List<SkinDto> skinDtos)
        {
            var skins = new List<Skin>();
            foreach (var skinDto in skinDtos)
            {
                skins.Add(new Skin
                {
                    Name = skinDto.Name,
                    LoadingImageUrl = $"http://ddragon.leagueoflegends.com/cdn/img/champion/loading/{champKey}_{skinDto.Num}.jpg",
                    SplashImageUrl = $"http://ddragon.leagueoflegends.com/cdn/img/champion/splash/{champKey}_{skinDto.Num}.jpg"
                });
            }
            return skins;
        }
    }
}
