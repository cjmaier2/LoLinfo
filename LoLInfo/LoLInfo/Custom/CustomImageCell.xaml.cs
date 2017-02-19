using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoLInfo.Custom
{
    public partial class CustomImageCell : ViewCell
    {
        public static readonly BindableProperty ImageSourceProperty =
        BindableProperty.Create("ImageSource", typeof(string), typeof(CustomImageCell), "");

        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public CustomImageCell()
        {
            InitializeComponent();
        }
    }
}
