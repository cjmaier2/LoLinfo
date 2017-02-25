using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using LolInfo.Models;
using LolInfo.Services;
using Xamarin.Forms;

namespace LoLInfo.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        ItemService ItemService { get; } = new ItemService();

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
                FilterItems();
            }
        }

        private List<Item> AllItems;

        private ObservableCollection<Item> items;
        public ObservableCollection<Item> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }

        public ItemsViewModel()
        {

        }

        public async Task<bool> LoadItems()
        {
            try
            {
                IsBusy = true;
                AllItems = await ItemService.GetItems();
                Items = new ObservableCollection<Item>(AllItems);
                if (!string.IsNullOrWhiteSpace(searchText))
                    FilterItems();
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
            await LoadItems();
        }

        public void FilterItems()
        {
            if (AllItems == null || AllItems.Count == 0)
            {
                Items = new ObservableCollection<Item>();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    Items = new ObservableCollection<Item>(AllItems);
                }
                else
                {
                    Items = new ObservableCollection<Item>(AllItems.Where(c => c.SearchName.Contains(searchText.ToUpper())).ToList());
                }
            }
        }
    }
}
