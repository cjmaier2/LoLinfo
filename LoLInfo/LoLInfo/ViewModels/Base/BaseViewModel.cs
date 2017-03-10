using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LoLInfo.Services;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace LoLInfo.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private bool isBusy;
        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        protected static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public List<string> Regions
        {
            get
            {
                return ServiceConstants.Regions;
            }
        }
    }
}
