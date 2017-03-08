using System;
using System.Collections.Generic;
using LoLInfo.ViewModels;
using LoLInfo.Views;
using Xamarin.Forms;

namespace LoLInfo.Views
{
    public class SettingsViewBase : BaseView<SettingsViewModel> { }

    public partial class SettingsView : SettingsViewBase
    {
        public SettingsView()
        {
            InitializeComponent();
        }
    }
}
