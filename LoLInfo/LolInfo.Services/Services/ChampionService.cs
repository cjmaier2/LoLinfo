using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LolInfo.Models;
using LolInfo.Services.Extensions;
using LolInfo.Services.ServiceModels;
using LolInfo.Services.Services;
using Newtonsoft.Json;

namespace LolInfo.Services.Services
{
    public class ChampionService : BaseService
    {
        public ChampionService() { }

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
                return champsDto.ToChampions();
            }
        }
    }
}
