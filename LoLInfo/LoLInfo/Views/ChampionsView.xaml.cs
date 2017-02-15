using System;
using System.Collections.Generic;
using LoLInfo.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;

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
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var success = await ViewModel.LoadChampions();
        }
    }
}
