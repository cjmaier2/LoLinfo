using System;
using System.Collections.Generic;
using LoLInfo.Models;
using LoLInfo.Services;
using LoLInfo.Services.ServiceModels;
using LoLInfo.Services.WebServices;

namespace LoLInfo
{
    public static class MatchHistoryExtensions
    {
        public static List<MatchInfo> ToMatchHistory(this RecentGamesDto recentGamesDto)
        {
            var matchHistory = new List<MatchInfo>();
            foreach (var game in recentGamesDto.Games)
            {
                matchHistory.Add(new MatchInfo
                {
                    ChampionImage = ChampionService.ChampionImageDictionary[game.ChampionId],
                    WinLossText = game.Stats.Win ? "Win" : "Loss",
                    GameMode = game.GameMode,
                    Kills = game.Stats.ChampionsKilled,
                    Deaths = game.Stats.NumDeaths,
                    Assists = game.Stats.Assists,
                    Item0Image = ItemService.ItemImageDictionary.ContainsKey(game.Stats.Item0) ? ItemService.ItemImageDictionary[game.Stats.Item0] : null,
                    Item1Image = ItemService.ItemImageDictionary.ContainsKey(game.Stats.Item1) ? ItemService.ItemImageDictionary[game.Stats.Item1] : null,
                    Item2Image = ItemService.ItemImageDictionary.ContainsKey(game.Stats.Item2) ? ItemService.ItemImageDictionary[game.Stats.Item2] : null,
                    Item3Image = ItemService.ItemImageDictionary.ContainsKey(game.Stats.Item3) ? ItemService.ItemImageDictionary[game.Stats.Item3] : null,
                    Item4Image = ItemService.ItemImageDictionary.ContainsKey(game.Stats.Item4) ? ItemService.ItemImageDictionary[game.Stats.Item4] : null,
                    Item5Image = ItemService.ItemImageDictionary.ContainsKey(game.Stats.Item5) ? ItemService.ItemImageDictionary[game.Stats.Item5] : null,
                    Item6Image = ItemService.ItemImageDictionary.ContainsKey(game.Stats.Item6) ? ItemService.ItemImageDictionary[game.Stats.Item6] : null
                });
            }
            return matchHistory;
        }
    }
}
