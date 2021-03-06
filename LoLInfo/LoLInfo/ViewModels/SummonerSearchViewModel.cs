﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoLInfo.Models;
using LoLInfo.Services;
using LoLInfo.Services.ServiceModels;
using LoLInfo.Services.WebServices;

namespace LoLInfo.ViewModels
{
    public class SummonerSearchViewModel : BaseViewModel
    {
        ChampionService ChampionService { get; } = new ChampionService();
        ItemService ItemService { get; } = new ItemService();
        SummonerService SummonerService { get; } = new SummonerService();

        public SummonerSearchViewModel()
        {
            
        }

        public async Task<List<MatchInfo>> GetMyMatchHistory()
        {
            var summonerName = AppSettings.GetValueOrDefault<string>(Constants.SummonerNameSettingsKey, string.Empty);
            var regionCode = AppSettings.GetValueOrDefault<string>(Constants.RegionCodeSettingsKey, string.Empty);
            return await GetMatchHistory(summonerName, regionCode);
        }

        public async Task<List<MatchInfo>> GetMatchHistory(string summonerName, string regionCode)
        {
            try
            {
                IsBusy = true;
                if (ChampionService.ChampionImageDictionary == null || ChampionService.ChampionImageDictionary.Count == 0)
                    await ChampionService.GetChampions(); //need champion image urls for match historys
                if (ItemService.ItemImageDictionary == null || ItemService.ItemImageDictionary.Count == 0)
                    await ItemService.GetItems(); //need item image urls for match history
                var matchHistory = await SummonerService.GetMatchHistory(summonerName, regionCode);
                return matchHistory;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
