using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using LolInfo.Models;
using LolInfo.Services.Services;
using Xamarin.Forms;
using System.Linq;

namespace LoLInfo.ViewModels
{
    public class ChampionsViewModel : BaseViewModel
    {
        ChampionService ChampService { get; } = new ChampionService();

        private string searchText;
        public string SearchText
        {
            get
            {
                return searchText;
            }
            set
            {
                searchText = value;
                FilterChampions();
            }
        }

        private List<Champion> AllChampions;

        private ObservableCollection<Champion> champions;
        public ObservableCollection<Champion> Champions
        {
            get
            {
                return champions;
            }
            set
            {
                champions = value;
                OnPropertyChanged();
            }
        }

        public ChampionsViewModel()
        {

        }

        public async Task<bool> LoadChampions()
        {
            try
            {
                IsBusy = true;
                AllChampions = await ChampService.GetChampions();
                Champions = new ObservableCollection<Champion>(AllChampions);
                if (!string.IsNullOrWhiteSpace(searchText)) //user could enter search text before champions finish loading
                    FilterChampions();
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

        public void FilterChampions()
        {
            if (AllChampions == null || AllChampions.Count == 0)
            {
                Champions = new ObservableCollection<Champion>();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    Champions = new ObservableCollection<Champion>(AllChampions);
                }
                else
                {
                    Champions = new ObservableCollection<Champion>(AllChampions.Where(c => c.SearchName.Contains(searchText.ToUpper())).ToList());
                }
            }
        }
    }
}
