using System;
using System.Collections.Generic;
using LoLInfo.ViewModels;
using Xamarin.Forms;

namespace LoLInfo.Views
{
    public class SummonerSearchViewBase : BaseView<SummonerSearchViewModel> { }

    public partial class SummonerSearchView : SummonerSearchViewBase
    {
        public SummonerSearchView()
        {
            InitializeComponent();

            foreach (var region in ViewModel.Regions)
            {
                regionPicker.Items.Add(region);
            }
            regionPicker.SelectedIndex = 0;
        }

        async void OnSearchClicked(object sender, EventArgs args)
        {
            var searchText = searchInput.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var matchHistory = await ViewModel.GetMatchHistory(searchText, regionPicker.Items[regionPicker.SelectedIndex]);
                if (matchHistory == null)
                {
                    await DisplayAlert("Error", "Failed to retrieve match history", "OK");
                }
                else
                {
                    await Navigation.PushAsync(new MatchHistoryView(matchHistory));
                }
            }
        }

        async void OnMyMatchHistoryClicked(object sender, EventArgs args)
        {
            var matchHistory = await ViewModel.GetMyMatchHistory();
            if (matchHistory == null)
            {
                await DisplayAlert("Error", "Failed to retrieve match history", "OK");
            }
            else
            {
                await Navigation.PushAsync(new MatchHistoryView(matchHistory));
            }
        }
    }
}
