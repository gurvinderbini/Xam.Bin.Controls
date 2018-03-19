using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xam.Bin.Controls.Controls
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty UnderlineColorProperty = BindableProperty.Create(nameof(UnderlineColor),
                                 typeof(string), typeof(CustomEntry), null, BindingMode.TwoWay);
        public string UnderlineColor
        {
            get { return (string)this.GetValue(UnderlineColorProperty); }
            set { this.SetValue(UnderlineColorProperty, value); }
        }

    }

}
