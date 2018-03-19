using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xam.Bin.Controls.Controls;
using Xam.Bin.Controls.Droid.Implementations;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace Xam.Bin.Controls.Droid.Implementations
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            var picker = e.NewElement as CustomPicker;
          
            if (Control == null || e.NewElement == null) return;

            Control.SetBackgroundColor(ColorExtensions.ToAndroid(picker.UnderlineColor)); //Setting underline color/background color
            Control.TextSize = Convert.ToSingle(picker.TitleFontSize);                 //Setting text size
            Control.SetHintTextColor(ColorExtensions.ToAndroid(picker.TitleColor));   //Setting title color
         
          if(!String.IsNullOrEmpty(picker.PickerIcon))     // Setting picker icon
            SetControlStyle(picker);
      
        }

        private void SetControlStyle(CustomPicker picker)
        {
            if (Control != null)
            {
                Drawable imgDropDownArrow = Resources.GetDrawable(picker.PickerIcon);
                Bitmap b = ((BitmapDrawable)imgDropDownArrow).Bitmap;
                Bitmap bitmapResized = Bitmap.CreateScaledBitmap(b, 30, 20, false);   //changing size of image
                var drawable = new BitmapDrawable(Resources, bitmapResized);
                Control.SetCompoundDrawablesRelativeWithIntrinsicBounds(null, null, drawable, null);
            }
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete

}