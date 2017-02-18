using System;
using Xamarin.Forms;

namespace LoLInfo.Custom
{
    public class RecycleListView : ListView
    {
        public RecycleListView() : base(ListViewCachingStrategy.RecycleElement)
        {
        }
    }
}
