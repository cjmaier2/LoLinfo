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

            MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new ChampionsView())
                    {
                        Title = "Champions",
                        BarBackgroundColor = Color.Black,
                        BarTextColor = Color.White
                    },
                    new NavigationPage(new ItemsView())
                    {
                        Title = "Items",
                        BarBackgroundColor = Color.Black,
                        BarTextColor = Color.White
                    }
                }
            };
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
