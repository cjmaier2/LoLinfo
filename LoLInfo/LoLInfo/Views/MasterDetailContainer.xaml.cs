using System;

using Xamarin.Forms;

namespace LoLInfo.Views
{
    public partial class MasterDetailContainer : MasterDetailPage
    {
        MasterPage masterPage;
        
        public MasterDetailContainer()
        {
            InitializeComponent();

            masterPage = new MasterPage();
            Master = masterPage;
            Detail = new RootTabPage();
        }
    }

    public class MasterPageItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}
