using System;
using System.Collections.Generic;
using LolInfo.Models;
using Xamarin.Forms;

namespace LoLInfo.Views
{
    public partial class ChampionSkinsView : CarouselPage
    {
        public ChampionSkinsView(List<Skin> skins)
        {
            InitializeComponent();

            ItemsSource = skins;
        }
    }
}
