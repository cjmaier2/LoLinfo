using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LolInfo.Models;
using LolInfo.Services.Services;

[assembly: Xamarin.Forms.Dependency(typeof(ChampionService))]
namespace LolInfo.Services.Services
{
    public class ChampionService
    {
        public ChampionService() { }

        public async Task<List<Champion>> GetChampions()
        {
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
