using System;
using System.Collections.Generic;
using LoLInfo.ViewModels;
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
    }
}
