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
    }
}
