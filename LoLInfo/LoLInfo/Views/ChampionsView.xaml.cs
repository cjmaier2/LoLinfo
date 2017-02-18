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
            //if (Device.OS == TargetPlatform.iOS)
            //    Icon = new FileImageSource { File = "todo.png" };

            ChampionListView.ItemTapped += OnItemTapped;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

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
