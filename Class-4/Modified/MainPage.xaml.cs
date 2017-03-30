using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        byte Red = 0;
        byte Green = 0;
        byte Blue = 0;
        byte Alpha = 255;
        byte[] rgbhex = { 0, 0, 0 };
        string hex;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Red_Slider_Value_Changed(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            if (slider != null)
            {
                Red = Convert.ToByte(slider.Value);
                ConstListener();
            }
        }

        private void Green_Slider_Value_Changed(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            if (slider != null)
            {
                Green = Convert.ToByte(slider.Value);
                ConstListener();
            }
        }

        private void Blue_Slider_Value_Changed(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            if (slider != null)
            {
                Blue = Convert.ToByte(slider.Value);
                ConstListener();
            }
        }

        private void ConstListener()
        {
            BGColor.Fill = new SolidColorBrush(Color.FromArgb(Alpha, Red, Green, Blue));
            if(Red==255 && Green==255 && Blue == 255)
            {
                RowOneTextBlock.Foreground = new SolidColorBrush(Colors.Black);
                RowOneTextBlock.Text = "Too white Mon";
            }
            else
            {
                RowOneTextBlock.Foreground = new SolidColorBrush(Color.FromArgb(Alpha, Red, Green, Blue));
                RowOneTextBlock.Text = "Hex Colour Picker";
            }
            rgbhex[0] = Red;
            rgbhex[1] = Green;
            rgbhex[2] = Blue;
            hex = BitConverter.ToString(rgbhex).Replace("-", string.Empty);
            HexColorTextBlock.Text = hex;

        }

        private void Alpha_Slider_Value_Changed(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            if (slider != null)
            {
                Alpha = Convert.ToByte(slider.Value);
                ConstListener();
            }
        }
    }
}