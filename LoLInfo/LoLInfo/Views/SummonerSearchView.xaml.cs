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
                    DisplayAlert("Error", "Failed to load champions", "OK");
                }
                else
                {
                    //navigate to match history page
                }
            }
        }
    }
}
