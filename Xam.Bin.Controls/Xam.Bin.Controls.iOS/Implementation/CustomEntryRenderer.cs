using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using CoreAnimation;
using Xamarin.Forms;
using CoreGraphics;
using Xam.Bin.Controls.Controls;
using Xam.Bin.Controls.iOS.Implementation;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]

namespace Xam.Bin.Controls.iOS.Implementation
{
    class CustomEntryRenderer : EntryRenderer
    {
        private CALayer _line;

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            _line = null;

            if (Control == null || e.NewElement == null)
                return;

            Control.BorderStyle = UITextBorderStyle.None;
            var entry = e.NewElement as CustomEntry;

            /* Spliting the color */
            string color = entry.UnderlineColor.Split('#')[1];
            string[] split = new string[color.Length / 2 + (color.Length % 2 == 0 ? 0 : 1)];
            for (int i = 0; i < split.Length; i++)
            {
                split[i] = color.Substring(i * 2, i * 2 + 2 > color.Length ? 1 : 2);
            }

            /* Creating a new frame  */
            _line = new CALayer
            {
                BorderColor = UIColor.FromRGB(Convert.ToInt32(split[0]), Convert.ToInt32(split[1]), Convert.ToInt32(split[2])).CGColor,
                BackgroundColor = UIColor.FromRGB(Convert.ToInt32(split[0]), Convert.ToInt32(split[1]), Convert.ToInt32(split[2])).CGColor,
                Frame = new CGRect(0, Frame.Height / 1.2, Frame.Width, 1f)
            };

            Control.Layer.AddSublayer(_line);
        }


    }

}
