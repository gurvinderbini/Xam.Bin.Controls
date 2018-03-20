using System;
using System.Collections.Generic;
using System.Text;
using Xam.Bin.Controls.Controls;
using Xamarin.Forms;

namespace Xam.Bin.Controls
{
    public class App : Application
    {

        public App()
        {
            StackLayout stackLayout = new StackLayout();

            BinSegmentedControl bin=new BinSegmentedControl();
            bin.Children.Add(new BinSegmentedControlOption(){Text = "test"});
            bin.Children.Add(new BinSegmentedControlOption() { Text = "test2" });

            stackLayout.Children.Add(bin);
            MainPage = new ContentPage()
            {

                Content = stackLayout
            };
        }
    }
}
