using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.Bin.Controls.Controls;
using Xamarin.Forms;

namespace Xam.Example
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CustomPicker customPicker = new CustomPicker();
            customPicker.TitleColor = Color.Aqua;
            customPicker.Title = "abcd";
            Content = customPicker;
        }
    }
}
