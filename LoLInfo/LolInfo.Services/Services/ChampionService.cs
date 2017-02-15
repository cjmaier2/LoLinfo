using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LolInfo.Models;
using LolInfo.Services.Services;

namespace LolInfo.Services.Services
{
    public class ChampionService : BaseService
    {
        public ChampionService() { }

        public async Task<List<Champion>> GetChampions()
        {
            using (var client = new HttpClient())
            {
                var queryUrl = string.Format(ServiceConstants.GetChampionsUrl, ServiceConstants.CurrentRegionCode);
                var url = GetRequestUrl(queryUrl);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                return new List<Champion>();
                //return DeserializeObject<Champion>(json);
            }

            return new List<Champion>()
            {
                new Champion()
                {
                    Id = 1,
                    Name = "Thresh"
                }
            };
        }
    }
}
