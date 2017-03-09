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
        public async Task<long> GetSummonerId(string summonerName)
        {
            //Note: this service can accept a comma-separated list of summoner names but we're assuming only one here
            using (var client = new HttpClient())
            {
                var coreUrl = string.Format(ServiceConstants.GetSummonerIdUrl, ServiceConstants.CurrentRegionCode, summonerName);
                var url = GetRequestUrl(coreUrl, null);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return -1;

                var summonerDictionary = JsonConvert.DeserializeObject<Dictionary<string,SummonerDto>>(json);
                return summonerDictionary[summonerName.ToLower()].Id;
            }
        }

        public async Task<List<MatchInfo>> GetMatchHistory(string summonerName)
        {
            var summonerId = await GetSummonerId(summonerName);
            using (var client = new HttpClient())
            {
                var coreUrl = string.Format(ServiceConstants.GetMatchHistoryUrl, ServiceConstants.CurrentRegionCode, summonerId);
                var url = GetRequestUrl(coreUrl, null);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                var recentGames = JsonConvert.DeserializeObject<RecentGamesDto>(json);
                return recentGames.ToMatchHistory();
            }
        }
    }
}
