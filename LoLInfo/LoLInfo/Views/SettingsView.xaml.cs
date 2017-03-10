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

            foreach (var region in ViewModel.Regions)
            {
                regionPicker.Items.Add(region);
            }
            regionPicker.SelectedIndex = 0;

            ToolbarItems.Add(new ToolbarItem("Save", "ic_save.png", () =>
            {
                var result = ViewModel.SaveSettings();
                if (result)
                    DisplayAlert("Success", "Your settings have been saved.", "OK");
                else
                    DisplayAlert("Error", "There was an issue saving your settings.", "OK");
            }));
        }
    }
}
