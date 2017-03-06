using System;

using Xamarin.Forms;

namespace LoLInfo.Views
{
    public partial class MasterDetailContainer : MasterDetailPage
    {
        MasterPage masterPage;
        RootTabPage rootPage;
        
        public MasterDetailContainer()
        {
            InitializeComponent();

            masterPage = new MasterPage();
            masterPage.ListView.ItemSelected += OnItemSelected;

            Master = masterPage;
            rootPage = new RootTabPage();
            Detail = rootPage;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;

            if (item != null)
            {
                if (item.TargetType == typeof(RootTabPage))
                {
                    Detail = rootPage;
                }
                else
                {
                    
                    var newNavPage = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                    newNavPage.BarBackgroundColor = Color.Black;
                    newNavPage.BarTextColor = Color.White;
                    Detail = newNavPage;
                }
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }

    public class MasterPageItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}
