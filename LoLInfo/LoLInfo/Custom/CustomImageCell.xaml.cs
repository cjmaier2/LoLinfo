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

        public static readonly BindableProperty NameProperty =
        BindableProperty.Create("Name", typeof(string), typeof(CustomImageCell), "");
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public static readonly BindableProperty TitleProperty =
        BindableProperty.Create("Title", typeof(string), typeof(CustomImageCell), "");
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public CustomImageCell()
        {
            InitializeComponent();
        }
    }
}
