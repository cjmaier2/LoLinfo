using System;
using LoLInfo.Custom;
using LoLInfo.iOS.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchBarRenderer))]
namespace LoLInfo.iOS.CustomRenderers
{
    //hides the cancel button
    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            //need to do this because Xamarin Forms shows the cancel button whenever text changes
            if (e.PropertyName == "Text" && Control != null)
                Control.ShowsCancelButton = false;
        }
    }
}
