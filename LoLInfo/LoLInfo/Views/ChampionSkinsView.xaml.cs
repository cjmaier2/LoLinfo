using System;
using System.Collections.Generic;
using LolInfo.Models;
using Xamarin.Forms;

namespace LoLInfo.Views
{
    public partial class ChampionSkinsView : ContentPage
    {
        public List<Skin> Skins { get; set; }

        public ChampionSkinsView(List<Skin> skins)
        {
            InitializeComponent();

            Skins = skins;
        }
    }
}
