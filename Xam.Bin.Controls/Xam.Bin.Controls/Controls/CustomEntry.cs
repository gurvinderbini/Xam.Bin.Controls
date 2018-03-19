using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xam.Bin.Controls.Controls
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty UnderlineColorProperty = BindableProperty.Create(nameof(UnderlineColor),
            typeof(Xamarin.Forms.Color), typeof(CustomPicker), Xamarin.Forms.Color.Transparent, BindingMode.TwoWay);
        public Xamarin.Forms.Color UnderlineColor
        {
            get { return (Xamarin.Forms.Color)this.GetValue(UnderlineColorProperty); }
            set { this.SetValue(UnderlineColorProperty, value); }
        }
    }

}
