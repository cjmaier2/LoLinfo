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
        }

        async void OnSearchClicked(object sender, EventArgs args)
        {
            var searchText = searchInput.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var matchHistory = await ViewModel.GetMatchHistory(searchText);
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
}
