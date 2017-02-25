using System;
using System.Collections.Generic;
using LoLInfo.ViewModels;
using Xamarin.Forms;

namespace LoLInfo.Views
{
    public class ItemsViewBase : BaseView<ItemsViewModel> { }
    
    public partial class ItemsView : ItemsViewBase
    {
        public ItemsView()
        {
            InitializeComponent();

            ItemListView.ItemTapped += OnItemTapped;
            ItemListView.IsPullToRefreshEnabled = true;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (Device.OS == TargetPlatform.iOS)
            {
                ItemSearchBar.BackgroundColor = Color.Black;
            }

            //only get items on first load (or until PTR)
            if (ViewModel.Items == null || ViewModel.Items.Count == 0)
            {
                var success = await ViewModel.LoadItems();
                if (!success)
                {
                    DisplayAlert("Error", "Failed to load items", "OK");
                }
            }
        }

        public void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            base.OnItemTapped(sender, e);
            ItemSearchBar.Unfocus();
        }
    }
}
