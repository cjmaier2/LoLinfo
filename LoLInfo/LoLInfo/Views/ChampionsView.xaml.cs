using System;
using System.Collections.Generic;
using LoLInfo.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using LoLInfo.Models;

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

            if (Device.OS == TargetPlatform.iOS)
            {
                ChampionSearchBar.BackgroundColor = Color.Black;
            }

            //only get champions on first load (or until PTR)
            if (ViewModel.Champions == null || ViewModel.Champions.Count == 0)
            {
                var success = await ViewModel.LoadChampions();
                if (!success)
                {
                    DisplayAlert("Error", "Failed to load champions", "OK");
                }
            }
        }

        public void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            base.OnItemTapped(sender, e);
            var skinsView = new ChampionSkinsView(((Champion)e.Item).Skins);
			skinsView.Title = ((Champion)e.Item).Name;
            Navigation.PushAsync(skinsView);
        }
    }
}
