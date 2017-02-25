﻿using System;
using LoLInfo.ViewModels;
using Xamarin.Forms;

namespace LoLInfo.Views
{
    public class BaseView<T> : ContentPage where T : BaseViewModel, new()
    {
        public T ViewModel { get; private set; }

        public BaseView()
        {
            ViewModel = new T();
            BindingContext = ViewModel;
        }

        public void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}
