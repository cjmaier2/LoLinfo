using LoLInfo.Services.WebServices;
using LoLInfo.Views;
using Xamarin.Forms;

namespace LoLInfo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS)
                MainPage = new MasterDetailContainer();
            else
                MainPage = new RootTabPage();
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
