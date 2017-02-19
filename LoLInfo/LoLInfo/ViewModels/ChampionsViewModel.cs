﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LolInfo.Models;
using LolInfo.Services.Services;
using Xamarin.Forms;

namespace LoLInfo.ViewModels
{
    public class ChampionsViewModel : BaseViewModel
    {
        ChampionService ChampService { get; } = new ChampionService();

        public List<Champion> Champions { get; private set; }

        public ChampionsViewModel()
        {

        }

        public async Task<bool> LoadChampions()
        {
            try
            {
                IsBusy = true;
                Champions = await ChampService.GetChampions();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                IsBusy = false;
            }
        }

        private Command refreshCommand;
        public Command RefreshCommand
        {
            get
            {
                return refreshCommand ?? new Command(ExecuteRefreshCommand);
            }
        }

        async void ExecuteRefreshCommand(object obj)
        {
            await LoadChampions();
        }

   }
}
