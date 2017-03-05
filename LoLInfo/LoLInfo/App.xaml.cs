using LolInfo.Services.Services;
using LoLInfo.Views;
using Xamarin.Forms;

namespace LoLInfo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //tab icons taken from https://material.io/icons/
            var championTab = new NavigationPage(new ChampionsView())
            {
                Title = "Champions",
                BarBackgroundColor = Color.Black,
                BarTextColor = Color.White
            };

            if (Device.OS == TargetPlatform.iOS)
                championTab.Icon = new FileImageSource { File = "ic_face.png" };

            var itemTab = new NavigationPage(new ItemsView())
            {
                Title = "Items",
                BarBackgroundColor = Color.Black,
                BarTextColor = Color.White
            };
            if (Device.OS == TargetPlatform.iOS)
                itemTab.Icon = new FileImageSource { File = "ic_monetization_on.png" };
            
            var tabs = new TabbedPage
            {
                Children =
                {
                    championTab,
                    itemTab
                }
            };

            if (Device.OS == TargetPlatform.Windows || Device.OS == TargetPlatform.WinPhone)
                tabs.BarTextColor = Color.White;

            MainPage = tabs;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
