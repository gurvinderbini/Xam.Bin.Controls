using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Android.Graphics;
using Android.Content.Res;
using Xamarin.Forms.Platform.Android;
using Xam.Bin.Controls.Controls;
using Xam.Bin.Controls.Droid.Implementations;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]

namespace Xam.Bin.Controls.Droid.Implementations
{
    class CustomEntryRenderer : Xamarin.Forms.Platform.Android.EntryRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            var entry = e.NewElement as CustomEntry;
            if (Control == null || e.NewElement == null) return;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                Control.BackgroundTintList = ColorStateList.ValueOf(ColorExtensions.ToAndroid(entry.UnderlineColor));
            else
                Control.Background.SetColorFilter(ColorExtensions.ToAndroid(entry.UnderlineColor), PorterDuff.Mode.SrcAtop);

            // "#ffffff" White Color
        }
    }

}