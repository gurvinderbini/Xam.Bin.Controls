﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xam.Bin.Controls.Controls
{
    public class CustomPicker : Picker
    {
        #region Constructor
        public CustomPicker()
        {
            //This helps in adjusting the image along with the text of Picker
            if (Device.OS == TargetPlatform.iOS)
            {
                Margin = new Thickness(0, 0, 5, 0);
            }
        }
        #endregion

        //Picker Under Line Color
        #region Picker Underline property
        public static readonly BindableProperty UnderlineColorProperty = BindableProperty.Create(nameof(UnderlineColor),
                                      typeof(Xamarin.Forms.Color), typeof(CustomPicker), Xamarin.Forms.Color.Transparent, BindingMode.TwoWay);
        public Xamarin.Forms.Color UnderlineColor
        {
            get { return (Xamarin.Forms.Color)this.GetValue(UnderlineColorProperty); }
            set { this.SetValue(UnderlineColorProperty, value); }
        }
        #endregion

        //Picker Title Text Color
        #region Title Text Color Property
        public static readonly BindableProperty TitleColorProperty = BindableProperty.Create(nameof(TitleColor),
                                    typeof(Xamarin.Forms.Color), typeof(CustomPicker), Xamarin.Forms.Color.White, BindingMode.TwoWay);
        public Xamarin.Forms.Color TitleColor
        {
            get { return (Xamarin.Forms.Color)this.GetValue(TitleColorProperty); }
            set { this.SetValue(TitleColorProperty, value); }
        }
        #endregion

        //Picker Title Font Size
        #region Title Font Size Property
        public static readonly BindableProperty TitleFontSizeProperty = BindableProperty.Create(nameof(TitleFontSize),
                                    typeof(double), typeof(CustomPicker), 0d, BindingMode.TwoWay);
        public double TitleFontSize
        {
            get { return (double)this.GetValue(TitleFontSizeProperty); }
            set { this.SetValue(TitleFontSizeProperty, value); }
        }
        #endregion

        // Picker Icon 
        #region Picker Icon Property
        public static readonly BindableProperty PickerIconProperty = BindableProperty.Create(nameof(PickerIcon),
                                   typeof(string), typeof(CustomPicker), String.Empty, BindingMode.TwoWay);
        public string PickerIcon
        {
            get { return (string)this.GetValue(PickerIconProperty); }
            set { this.SetValue(PickerIconProperty, value); }
        }
        #endregion
    }

}
