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
            //if (Device.OS == TargetPlatform.iOS)
            //    Icon = new FileImageSource { File = "todo.png" };
        }
    }
}
