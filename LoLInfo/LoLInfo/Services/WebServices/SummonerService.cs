using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LoLInfo.Models;
using LoLInfo.Services;
using LoLInfo.Services.ServiceModels;
using LoLInfo.Services.WebServices;
using Newtonsoft.Json;

namespace LoLInfo.Services.WebServices
{
    public class SummonerService : BaseService
    {
        public async Task<long> GetSummonerId(string summonerName, string regionCode = ServiceConstants.CurrentRegionCode)
        {
            //Note: this service can accept a comma-separated list of summoner names but we're assuming only one here
            using (var client = new HttpClient())
            {
                var coreUrl = string.Format(ServiceConstants.GetSummonerIdUrl, regionCode, summonerName);
                var url = GetRegionRequestUrl(coreUrl, regionCode, null);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return -1;

                var summonerDictionary = JsonConvert.DeserializeObject<Dictionary<string,SummonerDto>>(json);
                return summonerDictionary[summonerName.ToLower()].Id;
            }
        }

        public async Task<List<MatchInfo>> GetMatchHistory(string summonerName, string regionCode = ServiceConstants.CurrentRegionCode)
        {
            var summonerId = await GetSummonerId(summonerName, regionCode);
            using (var client = new HttpClient())
            {
                var coreUrl = string.Format(ServiceConstants.GetMatchHistoryUrl, regionCode, summonerId);
                var url = GetRegionRequestUrl(coreUrl, regionCode, null);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                var recentGames = JsonConvert.DeserializeObject<RecentGamesDto>(json);
                return recentGames.ToMatchHistory();
            }
        }
    }
}
