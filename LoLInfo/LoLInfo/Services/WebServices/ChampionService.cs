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
