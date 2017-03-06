﻿using System;
using Xamarin.Forms;

namespace LoLInfo.Views
{
    public class RootTabPage : TabbedPage
    {
        public RootTabPage()
        {
            //tab icons taken from https://material.io/icons/
            var championTab = new NavigationPage(new ChampionsView())
            {
                Title = "Champions",
                BarBackgroundColor = Color.Black,
                BarTextColor = Color.White
            };

            if (Device.OS == TargetPlatform.iOS)
                championTab.Icon = new FileImageSource { File = "ic_face.png" };

            var itemTab = new NavigationPage(new ItemsView())
            {
                Title = "Items",
                BarBackgroundColor = Color.Black,
                BarTextColor = Color.White
            };
            if (Device.OS == TargetPlatform.iOS)
                itemTab.Icon = new FileImageSource { File = "ic_monetization_on.png" };

            this.Children.Add(championTab);
            this.Children.Add(itemTab);

            if (Device.OS == TargetPlatform.Windows || Device.OS == TargetPlatform.WinPhone)
                BarTextColor = Color.White;
        }
    }
}
