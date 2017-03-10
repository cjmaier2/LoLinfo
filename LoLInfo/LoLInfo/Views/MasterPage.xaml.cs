using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoLInfo.Views
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Home",
                IconSource = "ic_home.png",
                TargetType = typeof(RootTabPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Settings",
                IconSource = "ic_settings.png",
                TargetType = typeof(SettingsView)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "About",
                IconSource = "ic_info_outline.png",
                TargetType = typeof(AboutView)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
