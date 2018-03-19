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
using Android.Graphics.Drawables;
using Android.Util;
using Xamarin.Forms.Platform.Android;
using Xam.Bin.Controls;
using Xam.Bin.Controls.Droid.Implementations;
using Xam.Bin.Controls.Controls;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]

namespace Xam.Bin.Controls.Droid.Implementations
{
    class CustomEntryRenderer : Xamarin.Forms.Platform.Android.EntryRenderer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public CustomEntryRenderer(Context context) : base(context)
        {
        }
        //protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        //{
        //    base.OnElementChanged(e);

        //    var entry = e.NewElement as CustomEntry;
        //    if (Control == null || e.NewElement == null) return;

        //    if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
        //        Control.BackgroundTintList = ColorStateList.ValueOf(ColorExtensions.ToAndroid(entry.UnderlineColor));
        //    else
        //        Control.Background.SetColorFilter(ColorExtensions.ToAndroid(entry.UnderlineColor), PorterDuff.Mode.SrcAtop);

        //    // "#ffffff" White Color
        //}


        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var view = (CustomEntry)Element;

                if (view.IsCurvedCornersEnabled)
                {
                    // creating gradient drawable for the curved background
                    var _gradientBackground = new GradientDrawable();
                    _gradientBackground.SetShape(ShapeType.Rectangle);
                    _gradientBackground.SetColor(view.BackgroundColor.ToAndroid());

                    // Thickness of the stroke line
                    _gradientBackground.SetStroke(view.BorderWidth, view.BorderColor.ToAndroid());

                    // Radius for the curves
                    _gradientBackground.SetCornerRadius(
                        DpToPixels(this.Context,
                            Convert.ToSingle(view.CornerRadius)));

                    // set the background of the label
                    Control.SetBackground(_gradientBackground);
                }

                // Set padding for the internal text from border
                Control.SetPadding(
                    (int)DpToPixels(this.Context, Convert.ToSingle(12)),
                    Control.PaddingTop,
                    (int)DpToPixels(this.Context, Convert.ToSingle(12)),
                    Control.PaddingBottom);
            }
        }
        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }

}