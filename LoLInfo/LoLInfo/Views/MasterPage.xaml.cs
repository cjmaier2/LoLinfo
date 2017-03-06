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
                Title = "About",
                IconSource = "ic_info_outline.png",
                TargetType = typeof(AboutView)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
