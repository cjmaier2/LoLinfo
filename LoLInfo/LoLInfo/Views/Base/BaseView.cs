using System;
using LoLInfo.ViewModels;
using Xamarin.Forms;

namespace LoLInfo
{
    public class BaseView<T> : ContentPage where T : BaseViewModel, new()
    {
        public T ViewModel { get; private set; }

        public BaseView()
        {
            ViewModel = new T();
            BindingContext = ViewModel;
        }
    }
}
