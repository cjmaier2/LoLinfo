using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LoLInfo.Models;
using LoLInfo.Services.Extensions;
using LoLInfo.Services.ServiceModels;
using LoLInfo.Services.WebServices;
using Newtonsoft.Json;

namespace LoLInfo.Services.WebServices
{
    public class ChampionService : BaseService
    {
        //dictionary to get champion image in match history
        public static Dictionary<int, string> ChampionImageDictionary = new Dictionary<int, string>();

        public async Task<List<Champion>> GetChampions()
        {
            using (var client = new HttpClient())
            {
                var coreUrl = string.Format(ServiceConstants.GetChampionsUrl, ServiceConstants.CurrentRegionCode);
                var queries = new List<string>() { "champData=all" };
                var url = GetRequestUrl(coreUrl, queries);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                var champsDto = JsonConvert.DeserializeObject<ChampionListDto>(json);
                var champs = champsDto.ToChampions();

                foreach (var champ in champs)
                {
                    if (!ChampionImageDictionary.ContainsKey(champ.Id))
                    {
                        ChampionImageDictionary.Add(champ.Id, champ.SquareImageUrl);
                    }
                }

                return champs;
            }
        }
    }
}
