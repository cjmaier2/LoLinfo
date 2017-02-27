using System;
using Xamarin.Forms;

namespace LoLInfo.Custom
{
    public class OpacityLabel : Label
    {
        public OpacityLabel()
        {
            BackgroundColor = Color.FromRgba(0, 0, 0, .5);
        }
    }
}
