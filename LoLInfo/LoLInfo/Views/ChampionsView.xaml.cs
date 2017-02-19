using System;
using System.Collections.Generic;
using LoLInfo.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using LolInfo.Models;

namespace LoLInfo.Views
{
    public class ChampionsViewBase : BaseView<ChampionsViewModel> { }

    public partial class ChampionsView : ChampionsViewBase
    {
        public ChampionsView()
        {
            InitializeComponent();

            ChampionListView.ItemTapped += OnItemTapped;
            ChampionListView.IsPullToRefreshEnabled = true;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //only get champions on first load (or until PTR)
            if (ViewModel.Champions == null || ViewModel.Champions.Count == 0)
            {
                var success = await ViewModel.LoadChampions();
                if (!success)
                {
                    DisplayAlert("Error", "Failed to load champions", "OK");
                }
                else
                {
                    ChampionListView.ItemsSource = new ObservableCollection<Champion>(ViewModel.Champions);
                }
            }
        }
    }
}
